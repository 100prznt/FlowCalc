using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowCalc.Objects
{
    public class Pool
    {
        #region Member
        double m_Volume;

        #endregion Member

        #region Properties
        public PoolShape Shape { get; set; }

        /// <summary>
        /// Length
        /// </summary>
        public double DimensionA { get; set; }

        /// <summary>
        /// Width or Diameter
        /// </summary>
        public double DimensionB { get; set; }

        /// <summary>
        /// Pooldepth
        /// </summary>
        public double Depth { get; set; }

        /// <summary>
        /// Filllevel in percent [0..1]
        /// </summary>
        public double FillLevel { get; set; }

        /// <summary>
        /// Filldepth in m
        /// </summary>
        public double FillDepth { get; set; }

        /// <summary>
        /// Watervolume
        /// </summary>
        public double Volumen
        {
            get => CalcVolume();
            set => m_Volume = value;
        }

        #endregion Properties

        #region Constructor
        /// <summary>
        /// Empty constructor for Pool
        /// </summary>
        public Pool()
        {

        }

        #endregion Constructor

        #region Services
        public double CalcVolume()
        {
            double volume = double.NaN;

            switch (Shape)
            {
                case PoolShape.Square:
                    volume = DimensionA * DimensionB * FillDepth;
                    break;
                case PoolShape.Round:
                    volume = Math.PI * Math.Pow((DimensionA / 2), 2) * FillDepth;
                    break;
                case PoolShape.Oval:
                    var circleA = Math.PI * Math.Pow((DimensionB / 2), 2);
                    var sqareA = DimensionB * (DimensionA - DimensionB);
                    volume = (circleA + sqareA) * FillDepth;
                    break;
                case PoolShape.Eight:
                    var r = DimensionB / 2;
                    var h = r - (DimensionA - DimensionB) / 2;
                    var s = 2 * Math.Sqrt(2 * r * h - Math.Pow(h, 2));
                    var alpha = Math.Asin((s / 2) / r);
                    var circleSegA = (Math.Pow(r, 2) / 2) * (alpha - Math.Sin(alpha));
                    var a = 2 * (Math.PI * Math.Pow(r, 2) - circleSegA);
                    volume = a * FillDepth;
                    break;
            }

            return volume;
        }

        #endregion Services

        #region Internal services


        #endregion Internal services

        #region Events


        #endregion Events
    }
}
