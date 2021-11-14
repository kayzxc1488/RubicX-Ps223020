using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubciX_Ps223020_DataAccess.Core.Models
{
    [Table("UserRole")]
    public class UserRoleRto
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }   
    }
}
