using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Norbit.Gcrm.Kholodov.Final.App.Models
{
	/// <summary>
	/// Сущность базы данных - информация о пользователе.
	/// </summary>
	public class User
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Key]
		public Guid Id { get; set; }

		public string UserDomainName { get; set; }
	}
}
