using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace EF7TEST.Models
{
    public class Order
    {
        // primary key
        public int OrderId { get; set; }
        public string Memo { get; set; }
        // Foreign Key
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        // Navigation Properties
        [JsonIgnore]
        public virtual Customer Customer { get; set; }
        [JsonIgnore]
        public virtual Product Product { get; set; }
    }
}