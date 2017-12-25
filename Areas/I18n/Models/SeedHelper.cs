using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EF7TEST.Areas.I18n.Models
{
    public class SeedHelper
    {
        public static void SeedEnumData<TData, TEnum>(IDbSet<TData> items)
            where TData : EnumBase<TEnum>
            where TEnum : struct
        {
            // check if TEnum is Enum
            var etype = typeof(TEnum);
            if (etype.IsEnum == false)
                throw new ArgumentException($"type {etype.AssemblyQualifiedName} must be enum");

            foreach (TEnum evalue in Enum.GetValues(etype))
            {
                var item = Activator.CreateInstance<TData>();
                item.Id = evalue;
                item.Name = Enum.GetName(etype, evalue);
                item.Description = GetEnumDescription(evalue);
                items.Add(item);
            }
        }

        public static string GetEnumDescription<TEnum>(TEnum item)
        {
            Type type = item.GetType();
            var attribute = type.GetField(item.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false).Cast<DescriptionAttribute>().FirstOrDefault();
            return attribute == null ? string.Empty : attribute.Description;
        }

    }
}