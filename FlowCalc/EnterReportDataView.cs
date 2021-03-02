using FlowCalc.PhysicalUnits;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowCalc
{
    public partial class EnterReportDataView : Form
    {
        public Units CurrentVolumeUnit { get; set; }

        /// <summary>
        /// Poolinhalt in [m³]
        /// </summary>
        public double PoolVolume { get; set; }

        /// <summary>
        /// Filterdurchmesser in [mm]
        /// </summary>
        public double FilterDiameter { get; set; }

        public string WindowTitle
        {
            get
            {
#if DEBUG
                return typeof(MainView).Assembly.GetName().Name;
#else
                var versionInfo = FileVersionInfo.GetVersionInfo(Assembly.GetEntryAssembly().Location);
                return string.Concat(typeof(MainView).Assembly.GetName().Name, " ", versionInfo.ProductVersion);
#endif
            }
        }

        public EnterReportDataView()
        {
            InitializeComponent();

            this.Text = WindowTitle + " - Erstelle Report..."; //Title
            this.Icon = Properties.Resources.iconfinder_100_Pressure_Reading_183415;

            cmb_VolumeUnit.ValueMember = nameof(DisplayUnit.DisplayName);

            foreach (Units unit in Enum.GetValues(typeof(Units)))
                if (unit.GetDimension() == Dimensions.Volume)
                    cmb_VolumeUnit.Items.Add(new DisplayUnit(unit));

            var volumeBaseUnit = new DisplayUnit(Dimensions.Volume.GetBaseUnit());

            cmb_VolumeUnit.SelectedItem = volumeBaseUnit;

            CurrentVolumeUnit = volumeBaseUnit.Unit;

            if (Properties.Settings.Default.CalcVolume > 0)
                txt_Volume.Text = Properties.Settings.Default.CalcVolume.ToString("f2");

            if (Properties.Settings.Default.FilterDiameter > 0)
                txt_FilterDiameter.Text = Properties.Settings.Default.FilterDiameter.ToString("f0");


        }

        private void cmb_VolumeUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            var newUnit = (DisplayUnit)cmb_VolumeUnit.SelectedItem;

            if (double.TryParse(txt_Volume.Text, out double volume))
            {
                txt_Volume.Text = UnitConverter.ToUnit(volume,
                    CurrentVolumeUnit,
                    newUnit.Unit
                    ).ToString("f3");
            }

            CurrentVolumeUnit = newUnit.Unit;
        }

        private void btn_Accept_Click(object sender, EventArgs e)
        {
            double vUser;

            try
            {
                vUser = double.Parse(txt_Volume.Text); //cust. unit
                FilterDiameter = double.Parse(txt_FilterDiameter.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Die eingegebenen Daten sind fehlerhaft.",
                    "Eingabe Fehlerhaft", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }


            PoolVolume = UnitConverter.ToUnit(vUser, CurrentVolumeUnit, Units.M3);

            Properties.Settings.Default.CalcVolume = PoolVolume;
            Properties.Settings.Default.FilterDiameter = FilterDiameter;
            Properties.Settings.Default.Save();

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btn_OpenCalculator_Click(object sender, EventArgs e)
        {
            var volumeCalcView = new VolumeCalcView();

            if (volumeCalcView.ShowDialog() == DialogResult.OK)
            {
                var volumeBaseUnit = new DisplayUnit(Dimensions.Volume.GetBaseUnit());
                cmb_VolumeUnit.SelectedItem = volumeBaseUnit;
                CurrentVolumeUnit = volumeBaseUnit.Unit;
                txt_Volume.Text = volumeCalcView.Pool.Volumen.ToString("F2");
            }
        }
    }
}
