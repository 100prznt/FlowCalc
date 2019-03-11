using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowCalc.PhysicalUnits
{
    public static class UnitExtensions
    {
        public static Dimensions GetDimension(this Units unit)
        {
            Attribute[] attributes = unit.GetAttributes();

            PhysicalDimensionAttribute attr = null;

            for (int i = 0; i < attributes.Length; i++)
            {
                if (attributes[i].GetType() == typeof(PhysicalDimensionAttribute))
                {
                    attr = (PhysicalDimensionAttribute)attributes[i];
                    break;
                }
            }

            if (attr == null)
                return Dimensions.None;
            else
                return attr.Dimension;
        }

        public static double GetBaseFactor(this Units unit)
        {
            Attribute[] attributes = unit.GetAttributes();

            PhysicalUnitAttribute attr = null;

            for (int i = 0; i < attributes.Length; i++)
            {
                if (attributes[i].GetType() == typeof(PhysicalUnitAttribute))
                {
                    attr = (PhysicalUnitAttribute)attributes[i];
                    break;
                }
            }

            if (attr == null)
                return 1;
            else
                return attr.BaseFactor;
        }

        public static double GetBaseOffset(this Units unit)
        {
            Attribute[] attributes = unit.GetAttributes();

            PhysicalUnitAttribute attr = null;

            for (int i = 0; i < attributes.Length; i++)
            {
                if (attributes[i].GetType() == typeof(PhysicalUnitAttribute))
                {
                    attr = (PhysicalUnitAttribute)attributes[i];
                    break;
                }
            }

            if (attr == null)
                return 0;
            else
                return attr.BaseOffset;
        }

        public static string GetName(this Units unit)
        {
            Attribute[] attributes = unit.GetAttributes();

            PhysicalUnitAttribute attr = null;

            for (int i = 0; i < attributes.Length; i++)
            {
                if (attributes[i].GetType() == typeof(PhysicalUnitAttribute))
                {
                    attr = (PhysicalUnitAttribute)attributes[i];
                    break;
                }
            }

            if (attr == null)
                return unit.ToString();
            else
                return attr.Name;
        }

        public static bool IsBase(this Units unit)
        {
            Attribute[] attributes = unit.GetAttributes();

            PhysicalUnitAttribute attr = null;

            for (int i = 0; i < attributes.Length; i++)
            {
                if (attributes[i].GetType() == typeof(PhysicalUnitAttribute))
                {
                    attr = (PhysicalUnitAttribute)attributes[i];
                    break;
                }
            }

            if (attr == null)
                return false;
            else
                return attr.IsBaseUnit;
        }

        public static Attribute[] GetAttributes(this Units unit)
        {
            var fi = unit.GetType().GetField(unit.ToString());
            Attribute[] attributes = (Attribute[])fi.GetCustomAttributes(typeof(Attribute), false);

            return attributes;
        }
    }
}
