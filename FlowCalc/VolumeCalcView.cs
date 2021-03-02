using FlowCalc.Objects;
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
    public partial class VolumeCalcView : Form
    {
        private bool m_AsDialog = false;

        public Pool Pool { get; set; }

        public Units CurrentFillLevelUnit { get; set; }
        public Units CurrentVolumenUnit { get; set; }

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

        public VolumeCalcView()
        {
            InitializeComponent();

            this.Text = WindowTitle + " - Poolvolumen"; //Title
            this.Icon = Properties.Resources.iconfinder_100_Pressure_Reading_183415;

            cmb_LevelUnit.ValueMember = nameof(DisplayUnit.DisplayName);
            cmb_VolumeUnit.ValueMember = nameof(DisplayUnit.DisplayName);

            cmb_LevelUnit.Items.Add(new DisplayUnit(Units.M));
            cmb_LevelUnit.Items.Add(new DisplayUnit(Units.Percent));

            foreach (Units unit in Enum.GetValues(typeof(Units)))
            {
                if (unit.GetDimension() == Dimensions.Volume)
                    cmb_VolumeUnit.Items.Add(new DisplayUnit(unit));
            }

            var volumeBaseUnit = new DisplayUnit(Dimensions.Volume.GetBaseUnit());

            cmb_LevelUnit.SelectedItem = new DisplayUnit(Units.Percent);
            cmb_VolumeUnit.SelectedItem = volumeBaseUnit;

            CurrentFillLevelUnit = Units.Percent;
            CurrentVolumenUnit = volumeBaseUnit.Unit;

            rb_Square.Checked = true;
            txt_Level.Text = "93";
        }

        private void btn_Clac_Click(object sender, EventArgs e)
        {
            try
            {
                //TODO: TryParse in Pipe bereitstellen
                var a = double.Parse(txt_DimA.Text); //m
                var b = double.NaN;
                if (!string.IsNullOrWhiteSpace(txt_DimB.Text))
                    b = double.Parse(txt_DimB.Text); //m
                var d = double.Parse(txt_DimDepth.Text); //m

                var l = double.Parse(txt_Level.Text);

                if (Pool.Shape != PoolShape.Round && a < b)
                    throw new ArgumentException("TODO: Input validation!");

                //TODO: Eingabe in Settings sichern

                Pool.DimensionA = a;
                Pool.DimensionB = b;
                if (((DisplayUnit)cmb_LevelUnit.SelectedItem).Unit == Units.Percent)
                    Pool.FillDepth = d * l / 100;
                else
                    Pool.FillDepth = l;
            }
            catch (Exception)
            {
                MessageBox.Show("Die eingegebenen Pooldaten sind fehlerhaft.",
                    "Eingabe Fehlerhaft", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            Properties.Settings.Default.CalcVolume = Pool.Volumen;
            Properties.Settings.Default.Save();

            txt_Volume.Text = UnitConverter.ToUnit(Pool.Volumen, Units.M3, CurrentVolumenUnit).ToString("F2");

            if (m_AsDialog && MessageBox.Show($"Berechnetes Volumen übernehmen?\n\n{UnitConverter.ToUnit(Pool.Volumen, Units.M3, CurrentVolumenUnit).ToString("F2")} m³", "Poolvolumen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                base.DialogResult = DialogResult.OK;
                base.Close();
            }
        }

        private void cmb_FillLevelUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            var newUnit = (DisplayUnit)cmb_LevelUnit.SelectedItem;

            if (!string.IsNullOrWhiteSpace(txt_Level.Text))
            {
                if (!double.TryParse(txt_DimDepth.Text, out var d))
                {
                    MessageBox.Show("Zur Umrechnung wird muss die nominale Pooltiefe angegeben werden.",
                        "Fehlende Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }


                if (double.TryParse(txt_Level.Text, out double level))
                {
                    if (newUnit.Unit == Units.Percent)
                    {
                        var levelPercent = level * 100 / d;
                        txt_Level.Text = levelPercent.ToString("f1");
                    }
                    else
                    {
                        var levelAbs = level * d / 100;
                        txt_Level.Text = levelAbs.ToString("f2");
                    }
                }
            }

            CurrentFillLevelUnit = newUnit.Unit;
        }

        private void cmb_VolumenUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            var newUnit = (DisplayUnit)cmb_VolumeUnit.SelectedItem;

            if (double.TryParse(txt_Volume.Text, out double volume))
            {
                txt_Volume.Text = UnitConverter.ToUnit(volume,
                    CurrentVolumenUnit,
                    newUnit.Unit
                    ).ToString("f3");
            }

            CurrentVolumenUnit = newUnit.Unit;
        }

        private void rb_Shape_CheckedChanged(object sender, EventArgs e)
        {
            Pool = new Pool();

            switch (((RadioButton)sender).Name)
            {
                case nameof(rb_Square):
                    Pool.Shape = PoolShape.Square;
                    setLengthWidth();
                    break;
                case nameof(rb_Round):
                    Pool.Shape = PoolShape.Round;
                    lbl_DimA.Text = "Durchmesser";
                    lbl_DimA.Visible = true;
                    txt_DimA.Visible = true;
                    lbl_DimAUnit.Visible = true;
                    lbl_DimB.Visible = false;
                    txt_DimB.Visible = false;
                    lbl_DimBUnit.Visible = false;
                    break;
                case nameof(rb_Oval):
                    Pool.Shape = PoolShape.Oval;
                    setLengthWidth();
                    break;
                case nameof(rb_Eight):
                    Pool.Shape = PoolShape.Eight;
                    setLengthWidth();
                    break;
            }

            void setLengthWidth()
            {
                lbl_DimA.Text = "Länge";
                lbl_DimA.Visible = true;
                txt_DimA.Visible = true;
                lbl_DimAUnit.Visible = true;
                lbl_DimB.Text = "Breite";
                lbl_DimB.Visible = true;
                txt_DimB.Visible = true;
                lbl_DimBUnit.Visible = true;
            }
        }

        public new DialogResult ShowDialog()
        {
            m_AsDialog = true;

            base.ShowDialog();
            return base.DialogResult;
        }
    }
}
