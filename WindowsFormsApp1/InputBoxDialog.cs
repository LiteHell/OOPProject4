using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class InputBoxDialog : Form
    {
        public string Result { get; set; }
        public void SetDescription(string description)
        {
            label_description.Text = description;
        }
        public InputBoxDialog()
        {
            InitializeComponent();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Result = txt_Result.Text;
            this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txt_Result_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_Ok_Click(null, null);
        }
    }
}
