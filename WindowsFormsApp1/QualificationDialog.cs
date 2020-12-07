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
    public partial class QualificationDialog : Form
    {
        public Data.Qualification Qualification { get; set; }
        public QualificationDialog()
        {
            InitializeComponent();
            Qualification = new Data.Qualification();
            this.Shown += QualificationDialog_Shown;
        }

        private void QualificationDialog_Shown(object sender, EventArgs e)
        {
            txt_name.Text = Qualification.Name;
            txt_institution.Text = Qualification.AwardingInstitution;
            dateTime_acquired.Value = Qualification.AcquisitiedAt;
            dateTime_validUntil.Value = Qualification.ValidUntil;
            check_validForever.Checked = Qualification.ValidForever;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Qualification.Name = txt_name.Text;
            Qualification.AwardingInstitution = txt_institution.Text;
            Qualification.AcquisitiedAt = dateTime_acquired.Value;
            Qualification.ValidUntil = dateTime_validUntil.Value;
            Qualification.ValidForever = check_validForever.Checked;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void check_validForever_CheckedChanged(object sender, EventArgs e)
        {
            dateTime_validUntil.Enabled = !check_validForever.Checked;
        }
    }
}
