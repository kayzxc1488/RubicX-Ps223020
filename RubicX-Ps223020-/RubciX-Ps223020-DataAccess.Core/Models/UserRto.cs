using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RubciX_Ps223020_DataAccess.Core.Models
{
    [Table("User")]
    public class UserRto
    {
        [Key] public int Id { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        [Required]public string PhoneNumberPrefix { get; set; }
        [Required]public string PhoneNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public DateTimeOffset Birtday { get; set; }
        public string AvatarUrl { get; set; }
        public UserRoleRto Role { get; set; }
    }
}
