using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

using Microsoft.Extensions.Configuration;
using Norbit.Gcrm.Kholodov.Final.App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Norbit.Gcrm.Kholodov.Final.App.Controllers
{
	[Authorize]
	[ApiController]
	[Route("DbController")]
	public class DbController : Controller
	{
		

        private readonly IConfiguration _configuration;
		private string connectionString = "";

		/// <summary>
		/// Получает строку подключения к БД из файла конфигурации.
		/// </summary>
		/// <param name="configuration">Конфигурация</param>
		public DbController(IConfiguration configuration)
		{
			_configuration = configuration;
			connectionString = _configuration.GetConnectionString("LEARN_training01");
		}

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        /// <summary>
        /// Передает данныев представление C#.
        /// </summary>
        /// <returns>Страница, демонстрирующая вызов метода из C# кода</returns>
        [HttpGet]
        [Route("CS")]
        public IActionResult CS()
        {
            var trade = GetLastTradeJson();
            ViewBag.Message = JsonConvert.SerializeObject(trade.Value);
            return View("CS");
        }

        /// <summary>
        /// Обеспечивает работу JS страницы.
        /// </summary>
        /// <returns>Страница, демонстрирующая вызов метода с помощью JS</returns>
        [HttpGet]
        [Route("JS")]
        public IActionResult JS()
        {
            return View();
        }

        /// <summary>
        /// Возвращает информацию о последней сделке пользователя в виде JSON строки.
        /// </summary>
        /// <returns>JSON-строка с информацией о сделке</returns>
        [HttpGet]
        [Route("Last")]
        public JsonResult GetLastTradeJson()
        {
            var transaction = GetLast();
            return Json(transaction);
        }

        /// <summary>
        /// Возвращает информацию из БД о последней сделке пользователя, отправившего запрос.
        /// </summary>
        /// <returns>Объект Trade с информацией о сделке</returns>
        private TransactionEntity GetLast()
        {
            // Получает имя пользователя
            var username = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            username = username.Replace(@"\\", @"\");

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                
                // Получает Guid пользователя с этим именем в базе
                SqlCommand getIdCommand =
                    new SqlCommand($"SELECT [Id] FROM [User] WHERE UserDomainName = '{username}'", connection);
                /*
                SqlCommand getIdCommand =
                    new SqlCommand($"SELECT [Id] FROM [User] WHERE UserDomainName = 'NORBIT\\Petr.Korchagin'", connection);
                */
                
                SqlDataReader reader = getIdCommand.ExecuteReader();

                Guid id = new Guid("00000000000000000000000000000000");
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        id = reader.GetGuid(0);
                    }
                }
                reader.Close();

                // Получает список из всех JSON-строк с данными о сделках этого пользователя
                SqlCommand getEntityCommand = new SqlCommand($"SELECT [Entity] FROM [Data] WHERE [UserId] = '{id}'", connection);
                reader = getEntityCommand.ExecuteReader();

                var dataList = new List<string>();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var data = reader.GetString(0);

                        dataList.Add(data);
                    }
                }
                reader.Close();

                if (dataList.Count() == 0)
                {
                    return new TransactionEntity();
                }

                // Опции сериализатора, чтобы он мог парсить числа из строк

                // Создает список сделок пользователя
                List<TransactionEntity> tradeList = new List<TransactionEntity>();
                foreach (string str in dataList)
                {
                    tradeList.Add(JsonConvert.DeserializeObject<TransactionEntity>(str));
                }

                // Находит последнюю сделку
                TransactionEntity result = (from t in tradeList
                                where t.Created.Equals(
                                tradeList.Max(t => t.Created))
                                select t).FirstOrDefault();

                return result;
            }
        
        }
        
    }
}
