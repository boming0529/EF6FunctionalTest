using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace EF7TEST.Areas.I18n.Models
{
    public enum LanguageEnum
    {
        [Description("zh-TW")]
        ZhongHua = 1,
        [Description("en-US")]
        English = 2,
        [Description("ja-JP")]
        Japanese = 3,
    }

    public class EnumBase<TEnum> where TEnum : struct
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public virtual TEnum Id { get; set; }

        [Required]
        [MaxLength(100)]
        public virtual string Name { get; set; }

        [MaxLength(100)]
        public virtual string Description { get; set; }
    }

    public class Language : EnumBase<LanguageEnum>
    {

    }
}