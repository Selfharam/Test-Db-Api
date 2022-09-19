using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Norbit.Gcrm.Kholodov.Final.App.Models
{
    /// <summary>
    /// Сущность базы данных - информация о сделке пользователя.
    /// </summary>
    public class Data
	{
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            [Key]
            public Guid Id { get; set; }
            public string UserId { get; set; }
            public string Entity { get; set; }
    }
}
