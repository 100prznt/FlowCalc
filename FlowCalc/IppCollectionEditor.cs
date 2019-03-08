using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowCalc
{
    public class IppCollectionEditor : System.ComponentModel.Design.ArrayEditor
    {
        public IppCollectionEditor(Type type) : base(type)
        {
            var test = this.CollectionItemType;
        }

        protected override CollectionForm CreateCollectionForm()
        {
            var form = base.CreateCollectionForm();
            form.Text = "Kennlinienstützpunkte";
            form.Icon = Properties.Resources.iconfinder_100_Pressure_Reading_183415;
            form.ShowIcon = true;
            form.HelpButton = false;
            form.Size = new System.Drawing.Size(500, 300);

            return form as CollectionForm;
        }
    }
}
