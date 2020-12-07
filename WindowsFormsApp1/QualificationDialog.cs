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
        private Data.Qualification qualification;

        public Data.Qualification GetQualification()
        {
            return qualification;
        }

        public void SetQualification(Data.Qualification value)
        {
            qualification = value;
        }

        public QualificationDialog()
        {
            InitializeComponent();
            SetQualification(new Data.Qualification());
            this.Shown += QualificationDialog_Shown;
        }

        private void QualificationDialog_Shown(object sender, EventArgs e)
        {
            txt_name.Text = GetQualification().GetName();
            txt_institution.Text = GetQualification().GetAwardingInstitution();
            dateTime_acquired.Value = GetQualification().GetAcquisitiedAt();
            dateTime_validUntil.Value = GetQualification().GetValidUntil();
            check_validForever.Checked = GetQualification().GetValidForever();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetQualification().SetName(txt_name.Text);
            GetQualification().SetAwardingInstitution(txt_institution.Text);
            GetQualification().SetAcquisitiedAt(dateTime_acquired.Value);
            GetQualification().SetValidUntil(dateTime_validUntil.Value);
            GetQualification().SetValidForever(check_validForever.Checked);
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
