using System;

namespace Norbit.Gcrm.Kholodov.Final.App.Models
{
	public class TransactionEntity
	{
		/// <summary>
		/// Содержит дату и сумму сделки.
		/// </summary>
		public decimal Amount { get; set; }
		public DateTime Created { get; set; }
	}
}
