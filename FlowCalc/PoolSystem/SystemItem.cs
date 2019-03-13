using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowCalc.PoolSystem
{
    public class SystemItem
    {
        #region Member


        #endregion Member

        #region Properties
        public string DisplayName { get; set; }

        public NominalDiameters NominalDiameter { get; set; }

        public string Diameter
        {
            get
            {
                if (NominalDiameter != NominalDiameters.NotSpecified)
                    return NominalDiameter.ToString();
                else if (BasePipe != null)
                    return BasePipe.Diameter.ToString("f2") + " mm";
                else
                    return string.Empty;
            }
        }

        public int Amount { get; set; }

        public double Length { get; set; }

        public bool IsEquivalentLength { get; set; }

        public Fitting BaseFitting { get; private set; }

        public Pipe BasePipe { get; private set; }

        #endregion Properties

        #region Constructor
        /// <summary>
        /// Empty constructor for SystemItem
        /// </summary>
        public SystemItem()
        {

        }

        public SystemItem(Fitting fitting)
        {
            DisplayName = fitting.DisplayName;
            NominalDiameter = fitting.Diameter;
            Amount = 1;
            Length = fitting.EquivalentLength;
            IsEquivalentLength = true;
            BaseFitting = fitting;
        }

        public SystemItem(Pipe pipe)
        {
            DisplayName = "Rohr";
            Amount = 1;
            Length = pipe.Length;
            IsEquivalentLength = false;
            BasePipe = pipe;
        }

        #endregion Constructor

        #region Services


        #endregion Services

        #region Internal services


        #endregion Internal services

        #region Events


        #endregion Events
    }
}
