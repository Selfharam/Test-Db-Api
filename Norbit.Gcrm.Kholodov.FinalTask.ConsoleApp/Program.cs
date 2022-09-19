using System;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Net.Http.Headers;

namespace Norbit.Gcrm.Kholodov.FinalTask.ConsoleApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			RunAsync().GetAwaiter().GetResult();
		}

        private static HttpClient client;

        /// <summary>
        /// Выводит результат запроса в консоль.
        /// </summary>
        /// <param name="entity">Объект транзакции</param>
        private static void ShowTransactionEntity(TransactionEntity entity)
        {
            Console.WriteLine($"Дата тразакции: {entity.Created.ToLocalTime()}, сумма: {entity.Amount}");

            Console.ReadLine();
        }

        /// <summary>
        /// Десериализует объект тразакции из JSON строки.
        /// </summary>
        /// <param name="jsonString">JSON строка</param>
        /// <returns>Объект класса транзакции</returns>
        private static TransactionEntity GetEntityFromJson(string jsonString)
        {
            TransactionEntity entity = JsonConvert.DeserializeObject<TransactionEntity>(jsonString);
            return entity;
        }

        /// <summary>
        /// Получает информацию о последней транзакции из Web API.
        /// </summary>
        /// <param name="path">Адрес сервера</param>
        /// <returns>JSON строка результата</returns>
        private static async Task<string> GetEntityAsync(string path)
        {
            string tradeJson = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                tradeJson = await response.Content.ReadAsStringAsync();
            }
            return tradeJson;
        }

        /// <summary>
        /// Осуществляет обращение к серверу и выполнение запроса.
        /// </summary>
        private static async Task RunAsync()
        {
            HttpClientHandler handler = new HttpClientHandler() { UseDefaultCredentials = true };
            using (client = new HttpClient(handler))
            {
                client.BaseAddress = new Uri("https://localhost:44373/DbController/Last");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                try
                {
                    string tradeJson = await GetEntityAsync(client.BaseAddress.AbsoluteUri);
                    ShowTransactionEntity(GetEntityFromJson(tradeJson));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                Console.ReadLine();
            }
        }
    }
}
