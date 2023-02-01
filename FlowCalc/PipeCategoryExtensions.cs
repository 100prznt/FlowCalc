using FlowCalc.PhysicalUnits;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowCalc
{
    public static class PipeCategoryExtensions
    {
        public static string GetDescription(this PipeCategories category)
        {
            Attribute[] attributes = category.GetAttributes();

            DescriptionAttribute attr = null;

            for (int i = 0; i < attributes.Length; i++)
            {
                if (attributes[i].GetType() == typeof(DescriptionAttribute))
                {
                    attr = (DescriptionAttribute)attributes[i];
                    break;
                }
            }

            if (attr == null)
                return category.ToString();
            else
                return attr.Description;
        }

        public static Attribute[] GetAttributes(this PipeCategories category)
        {
            var fi = category.GetType().GetField(category.ToString());
            Attribute[] attributes = (Attribute[])fi.GetCustomAttributes(typeof(Attribute), false);

            return attributes;
        }
    }
}
