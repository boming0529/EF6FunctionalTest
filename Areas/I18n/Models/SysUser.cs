using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace EF7TEST.Areas.I18n.Models
{
    public class SysUser
    {
        //Properties
        [Key]
        [DisplayName("User Id")]
        [Required]
        [MaxLength(50)]
        [Description("Logon system by user id")]
        public string SysUserId { get; set; }

        [DisplayName("Name")]
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        // Foreign Key
        public LanguageEnum LanguageId { get; set; }

        // Navigation Properties
        [JsonIgnore]
        [DisplayName("Langurage")]
        public virtual Language Language { get; set; }
    }
}