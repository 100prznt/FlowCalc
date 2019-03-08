﻿using FlowCalc.Mathematics;
using FlowCalc.PoolSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace FlowCalc
{
    public class Controller : INotifyPropertyChanged
    {
        #region Member


        #endregion Member

        #region Properties
        /// <summary>
        /// Geladene Pumpe
        /// </summary>
        public Pump Pump { get; set; }

        /// <summary>
        /// Pfad zur aktuell verwendeten Pumpendefinition
        /// </summary>
        public string PumpDefinitionPath { get; set; }

        /// <summary>
        /// Aktueller Systemdruck
        /// in [bar]
        /// </summary>
        public double SystemPressure { get; set; }

        /// <summary>
        /// Aktuelle Wassersäule
        /// in [m]
        /// berechnet aus dem aktuellen Systemdruck
        /// </summary>
        public double SystemHead
        {
            get
            {
                return SystemPressure / 0.0980665;
            }
        }

        /// <summary>
        /// Aktueller Systemvolumenstrom
        /// in [m³/h]
        /// </summary>
        public double SystemFlowRate { get; set; }

        public Pipe SuctionPipe { get; set; }

        public double SuctionPressureDrop { get; set; }

        #endregion Properties

        #region Constructor
        /// <summary>
        /// Empty constructor for Controller
        /// </summary>
        public Controller()
        {

        }

        #endregion Constructor

        #region Services
        /// <summary>
        /// Pumpendefinitionsdatei laden und in <see cref="Pump"/> ablegen
        /// </summary>
        /// <param name="path">Pafd zur Pumpendefinitionsdatei</param>
        /// <exception cref="InvalidDataException">Fehler beim laden der Pumpendefinitionsdatei</exception>
        public void LoadPump(string path)
        {
            Pump = Pump.FromFile(path);
            PumpDefinitionPath = path;
        }

        public void NewPump()
        {
            PumpDefinitionPath = null;
            Pump = new Pump();
        }

        public void CalcFlowRate(double pressure)
        {
            SystemPressure = pressure;

            if (SystemHead > Pump.MaxTotalHead)
            {
                ResetSystem();
                return;
            }

            var systemFlowRate = LinInterp.LinearInterpolation(Pump.GetPerformanceHeadValues(), Pump.GetPerformanceFlowValues(), SystemHead);

            if (SuctionPipe == null)
            {
                SystemFlowRate = systemFlowRate;
                return;
            }

            //Iterative Berechnung, da Volumenstrom auch vom suagseitigen Druckverlust abhängt

            double lastFlowRate = 0;
            double pressureDrop = 0;
            double systemPressure = 0;
            while (Math.Round(systemFlowRate, 4) != Math.Round(lastFlowRate, 4))
            {
                pressureDrop = SuctionPipe.CalcPressureDrop(Medium.Water20, systemFlowRate);
                systemPressure = pressure + pressureDrop;
                lastFlowRate = systemFlowRate;
                systemFlowRate = LinInterp.LinearInterpolation(Pump.GetPerformanceHeadValues(), Pump.GetPerformanceFlowValues(), systemPressure / 0.0980665);
            }

            if (SystemHead > Pump.MaxTotalHead || double.IsInfinity(systemPressure) || double.IsInfinity(systemFlowRate) || double.IsInfinity(pressureDrop))
                ResetSystem();
            else
            {
                SystemPressure = systemPressure;
                SystemFlowRate = systemFlowRate;
                SuctionPressureDrop = -pressureDrop;
            }
        }

        public void ResetSystem()
        {
            SuctionPipe = null;
            SystemPressure = 0;
            SystemFlowRate = 0;
            SuctionPressureDrop = 0;
        }

        #endregion Services

        #region Internal services

        #endregion Internal services

        #region Events


        #endregion Events

        #region INotifyPropertyChanged Member
        /// <summary>
        /// Helpmethod, to call the <see cref="PropertyChanged"/> event
        /// </summary>
        /// <param name="propName">Name of changed property</param>
        protected void PropChanged([CallerMemberName] string propName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }

        /// <summary>
        /// Updated property values available
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}
