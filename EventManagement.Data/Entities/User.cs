using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagement.Data.Entities
{
    [Table("Users")]
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string IdCardNo { get; set; }
        public string Mobile { get; set; }

        public string Password { get; set; }
    }
}
