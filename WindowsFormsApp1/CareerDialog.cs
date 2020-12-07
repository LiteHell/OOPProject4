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
        private Data.Career career;

        public Data.Career GetCareer()
        {
            return career;
        }

        public void SetCareer(Data.Career value)
        {
            career = value;
        }

        public CareerDialog()
        {
            InitializeComponent();
            SetCareer(new Data.Career());
            this.Shown += QualificationDialog_Shown;
        }

        private void QualificationDialog_Shown(object sender, EventArgs e)
        {
            txt_name.Text = GetCareer().GetCompanyName();
            txt_position.Text = GetCareer().GetPosition();
            txt_responsiblities.Text = GetCareer().GetResponsibilities();
            dateTime_workedFrom.Value = GetCareer().GetWorkedSince();
            dateTime_workedUntil.Value = GetCareer().GetWorkedUntil();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            GetCareer().SetCompanyName(txt_name.Text);
            GetCareer().SetPosition(txt_position.Text);
            GetCareer().SetResponsibilities(txt_responsiblities.Text);
            GetCareer().SetWorkedSince(dateTime_workedFrom.Value);
            GetCareer().SetWorkedUntil(dateTime_workedUntil.Value);
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
