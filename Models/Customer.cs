using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace EF7TEST.Models
{
    public class Customer
    {
        // Primary Key
        public int Id { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Password { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public DateTime RegisterOn { get; set; }
        // Navigation Properties
        [JsonIgnore]
        public virtual ICollection<Order> Oreders { get; set; }
    }
}