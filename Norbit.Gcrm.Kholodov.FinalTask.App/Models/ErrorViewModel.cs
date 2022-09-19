using System;

namespace Norbit.Gcrm.Kholodov.FinalTask.App.Models
{
	public class ErrorViewModel
	{
		public string RequestId { get; set; }

		public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
	}
}
