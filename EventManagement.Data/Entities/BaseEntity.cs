using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagement.Data.Entities
{
    public class BaseEntity : IBaseEntity
    {
        [Key]
        public int Id { get; set; }
    }

    public interface IBaseEntity
    {
        int Id { get; set; }
    }
}
