using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandevuSistemi.WFA.BaseForms
{
    public partial class EklemeBaseForm : Form
    {
        public EklemeBaseForm()
        {
            InitializeComponent();
        }

        public static void FormTemizle(Control.ControlCollection controls)
        {
            foreach (var item in controls)
            {
                if (item is TextBox)
                    (item as TextBox).Text = string.Empty;
                else if (item is NumericUpDown)
                    (item as NumericUpDown).Value = 0;
                else if (item is ComboBox)
                    (item as ComboBox).SelectedIndex = 0;
                else if (item is DateTimePicker)
                    (item as DateTimePicker).Value = DateTime.Now;
                else if (item is CheckBox)
                    (item as CheckBox).Checked = false;
                else if (item is GroupBox)
                    FormTemizle((item as GroupBox).Controls);
                else if (item is Panel)
                    FormTemizle((item as Panel).Controls);
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            FormTemizle(this.Controls);
        }
    }
}
