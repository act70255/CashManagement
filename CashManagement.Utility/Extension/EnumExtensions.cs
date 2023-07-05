using System;
using System.Collections.Generic;
using System.Text;

namespace CashManagement.Utility.Extension
{
    public class DisplayNameAttribute : Attribute
    {
        public string Description { get; set; }

        public DisplayNameAttribute(string value)
        {
            this.Description = value;
        }

        public override string ToString()
        {
            return this.Description;
        }

    }
    public static class EnumExtensions
    {
        public static string GetDisplayName(this Enum enumValue)
        {
            var field = enumValue.GetType().GetField(enumValue.ToString());
            if (Attribute.GetCustomAttribute(field, typeof(DisplayNameAttribute)) is DisplayNameAttribute attribute)
            {
                return attribute.Description;
            }
            throw new ArgumentException("Item not found.", nameof(enumValue));
        }
    }

}
