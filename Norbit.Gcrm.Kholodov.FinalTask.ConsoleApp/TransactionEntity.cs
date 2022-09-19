using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Norbit.Gcrm.Kholodov.FinalTask.ConsoleApp
{
	/// <summary>
	/// Содержит дату и сумму транзакции.
	/// </summary>
	public class TransactionEntity
	{
		[JsonProperty("amount")]
		public decimal Amount { get; set; }

		[JsonProperty("created")]
		public DateTime Created { get; set; }
	}
}
