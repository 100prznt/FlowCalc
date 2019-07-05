using FlowCalc.PhysicalUnits;
using FlowCalc.PoolSystem;
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
    public partial class FilterSpeedCalcView : Form
    {
        public Pipe Filter { get; set; }

        public Units CurrentFlowRateUnit { get; set; }
        public Units CurrentFlowVelocityUnit { get; set; }

        /// <summary>
        /// Flowrate in [m³/h]
        /// </summary>
        public double FlowRate { get; set; } = double.NaN;

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

        public FilterSpeedCalcView()
        {
            InitializeComponent();

            this.Text = WindowTitle + " - Filtergeschwindigkeit"; //Title
            this.Icon = Properties.Resources.iconfinder_100_Pressure_Reading_183415;

            cmb_FlowRateUnit.ValueMember = nameof(DisplayUnit.DisplayName);
            cmb_FlowVelocityUnit.ValueMember = nameof(DisplayUnit.DisplayName);

            foreach (Units unit in Enum.GetValues(typeof(Units)))
            {
                switch (unit.GetDimension())
                {
                    case Dimensions.FlowRate:
                        cmb_FlowRateUnit.Items.Add(new DisplayUnit(unit));
                        break;
                    case Dimensions.Velocity:
                        cmb_FlowVelocityUnit.Items.Add(new DisplayUnit(unit));
                        break;
                }
            }

            var flowRateBaseUnit = new DisplayUnit(Dimensions.FlowRate.GetBaseUnit());
            var velocityBaseUnit = new DisplayUnit(Units.M_Per_H);

            cmb_FlowRateUnit.SelectedItem = flowRateBaseUnit;
            cmb_FlowVelocityUnit.SelectedItem = velocityBaseUnit;

            CurrentFlowRateUnit = flowRateBaseUnit.Unit;
            CurrentFlowVelocityUnit = velocityBaseUnit.Unit;

            if (Properties.Settings.Default.CalcPipeDiameter > 0)
                txt_FilterDiameter.Text = Properties.Settings.Default.FilterDiameter.ToString();

            txt_FilterSpeedInfo.Text = "Im privaten Poolbereich sollte die Filtergeschwindigkeit nicht über 50 m/h betragen." +
                "\r\nMit einer langsameren Filtergeschwindigkeit von rund 30 m/h würde das Ergebnis der Filtration zwar verbessert, " +
                "jedoch sind für Rückspülung (Reinigung des Filters) Spülgeschwindigkeiten von 50-60 m/h erforderlich. Da die Filterpumpe in privaten " +
                "Pool für Filtration und Rückspülung ausgelegt wird, wählt man als Kompromiss eine Filtergeschwindigkeit um 50 m/h.";
        }

        public new void Show()
        {
            if (!double.IsNaN(FlowRate) && FlowRate > 0)
                txt_FlowRate.Text = FlowRate.ToString("f2");

            base.Show();
        }

        private void btn_Clac_Click(object sender, EventArgs e)
        {
            txt_FlowVelocity.Font = new Font(new FontFamily("Microsoft Sans Serif"), 8.25F);
            txt_FlowRate.Font = new Font(new FontFamily("Microsoft Sans Serif"), 8.25F);

            try
            {
                //TODO: TryParse in Pipe bereitstellen
                var fd = double.Parse(txt_FilterDiameter.Text); //mm

                Properties.Settings.Default.FilterDiameter = fd;
                Properties.Settings.Default.Save();

                Filter = new Pipe(1, fd, 0.1);
            }
            catch (Exception)
            {
                MessageBox.Show("Der eingegebene Filterdurchmesser ist fehlerhaft, Berechnung nicht möglich.",
                    "Eingabe Fehlerhaft", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            double flowRate = 0;
            double flowVelocity = 0;

            if (double.TryParse(txt_FlowRate.Text, out flowRate))
            {
                flowVelocity = Filter.CalcFlowVelocity(UnitConverter.ToBase(flowRate, ((DisplayUnit)cmb_FlowRateUnit.SelectedItem).Unit));
                txt_FlowVelocity.Text = UnitConverter.ToUnit(flowVelocity, Dimensions.Velocity.GetBaseUnit(), ((DisplayUnit)cmb_FlowVelocityUnit.SelectedItem).Unit).ToString("f3");
                txt_FlowVelocity.Font = new Font(new FontFamily("Microsoft Sans Serif"), 8.25F, FontStyle.Bold);
            }
            else
                MessageBox.Show("Der eingegebene Volumenstrom ist fehlerhaft, Berechnung nicht möglich.",
                    "Eingabe Fehlerhaft", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void cmb_FlowRateUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            var newUnit = (DisplayUnit)cmb_FlowRateUnit.SelectedItem;

            if (double.TryParse(txt_FlowRate.Text, out double flowRate))
            {
                txt_FlowRate.Text = UnitConverter.ToUnit(flowRate,
                    CurrentFlowRateUnit,
                    newUnit.Unit
                    ).ToString("f3");
            }

            CurrentFlowRateUnit = newUnit.Unit;
        }

        private void cmb_FlowVelocityUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            var newUnit = (DisplayUnit)cmb_FlowVelocityUnit.SelectedItem;

            if (double.TryParse(txt_FlowVelocity.Text, out double flowVelocity))
            {
                txt_FlowVelocity.Text = UnitConverter.ToUnit(flowVelocity,
                    CurrentFlowVelocityUnit,
                    newUnit.Unit
                    ).ToString("f3");
            }

            CurrentFlowVelocityUnit = newUnit.Unit;
        }
    }
}
