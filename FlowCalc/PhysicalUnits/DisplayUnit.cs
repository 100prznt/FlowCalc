using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowCalc.PhysicalUnits
{
    /// <summary>
    /// Hilfsklasse zur Anzeige von Units in z.B. Comboboxen
    /// </summary>
    public class DisplayUnit
    {
        public Units Unit { get; set; }

        public string DisplayName
        {
            get
            {
                return Unit.GetName();
            }
        }

        public DisplayUnit(Units unit)
        {
            Unit = unit;
        }
    }
}
