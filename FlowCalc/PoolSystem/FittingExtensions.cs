using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowCalc.PoolSystem
{
    public static class FittingExtensions
    {
        public static string GetDisplayName(this Fittings fitting)
        {
            Attribute[] attributes = fitting.GetAttributes();

            FittingDetailAttribute attr = null;

            for (int i = 0; i < attributes.Length; i++)
            {
                if (attributes[i].GetType() == typeof(FittingDetailAttribute))
                {
                    attr = (FittingDetailAttribute)attributes[i];
                    break;
                }
            }

            if (attr == null)
                return fitting.ToString();
            else
                return attr.DisplayName;

        }

        public static NominalDiameters GetNominalDiameter(this Fittings fitting)
        {
            Attribute[] attributes = fitting.GetAttributes();

            FittingDetailAttribute attr = null;

            for (int i = 0; i < attributes.Length; i++)
            {
                if (attributes[i].GetType() == typeof(FittingDetailAttribute))
                {
                    attr = (FittingDetailAttribute)attributes[i];
                    break;
                }
            }

            if (attr == null)
                return NominalDiameters.NotSpecified;
            else
                return attr.NominalDiameter;
        }

        public static Attribute[] GetAttributes(this Fittings fitting)
        {
            var fi = fitting.GetType().GetField(fitting.ToString());
            Attribute[] attributes = (Attribute[])fi.GetCustomAttributes(typeof(Attribute), false);

            return attributes;
        }
    }
}
