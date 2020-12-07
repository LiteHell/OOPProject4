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
    public partial class CareerDialog : Form
    {
        public Data.Career Career { get; set; }
        public CareerDialog()
        {
            InitializeComponent();
            Career = new Data.Career();
            this.Shown += QualificationDialog_Shown;
        }

        private void QualificationDialog_Shown(object sender, EventArgs e)
        {
            txt_name.Text = Career.CompanyName;
            txt_position.Text = Career.Position;
            txt_responsiblities.Text = Career.Responsibilities;
            dateTime_workedFrom.Value = Career.WorkedSince;
            dateTime_workedUntil.Value = Career.WorkedUntil;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Career.CompanyName = txt_name.Text;
            Career.Position = txt_position.Text;
            Career.Responsibilities = txt_responsiblities.Text;
            Career.WorkedSince = dateTime_workedFrom.Value;
            Career.WorkedUntil = dateTime_workedUntil.Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
