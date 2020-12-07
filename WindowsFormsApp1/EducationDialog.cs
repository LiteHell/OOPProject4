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
    public partial class EducationDialog : Form
    {
        private Data.Education education;

        public Data.Education GetEducation()
        {
            return education;
        }

        public void SetEducation(Data.Education value)
        {
            education = value;
        }

        public EducationDialog()
        {
            InitializeComponent();
            SetEducation(new Data.Education());
            this.Load += EducationDialog_Load;
        }

        private void EducationDialog_Load(object sender, EventArgs e)
        {
            LoadEducation();
        }

        private void LoadEducation()
        {
            switch (GetEducation().GetSchoolType())
            {
                case Data.SchoolType.HighSchool:
                    radio_highSchool.Checked = true;
                    break;
                case Data.SchoolType.University:
                    radio_University.Checked = true;
                    break;
                case Data.SchoolType.GraduateSchool:
                    radio_graduateSchool.Checked = true;
                    break;
            }
            switch (GetEducation().GetStatus())
            {
                case Data.SchoolRegistrationType.Enrolled:
                    comboBox_Status.SelectedIndex = 0;
                    break;
                case Data.SchoolRegistrationType.LeaveOfAbsence:
                    comboBox_Status.SelectedIndex = 1;
                    break;
                case Data.SchoolRegistrationType.Completed:
                    comboBox_Status.SelectedIndex = 2;
                    break;
                case Data.SchoolRegistrationType.Graduated:
                    comboBox_Status.SelectedIndex = 3;
                    break;
                case Data.SchoolRegistrationType.Expelled:
                    comboBox_Status.SelectedIndex = 4;
                    break;
            }
            txt_schoolName.Text = GetEducation().GetSchoolName();
            txt_schoolYear.Text = GetEducation().GetSchoolYear().ToString();
            dateTime_admissionDate.Value = GetEducation().GetEnrolledAt();
            dateTime_graduationDate.Value = GetEducation().GetGraduatedAt();
            if (GetEducation().GetSchoolType() != Data.SchoolType.HighSchool)
            {
                Data.HigherEducation higherEducation = (Data.HigherEducation)GetEducation();
                txt_degreeName.Text = higherEducation.GetDegreeName();
                txt_major.Text = higherEducation.GetMajor();
                txt_gpa.Text = higherEducation.GetGPA().ToString();
                txt_maxGpa.Text = higherEducation.GetMaximumGPA().ToString();
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (radio_highSchool.Checked)
                GetEducation().SetSchoolType(Data.SchoolType.HighSchool);
            else if (radio_University.Checked)
                GetEducation().SetSchoolType(Data.SchoolType.University);
            else if (radio_graduateSchool.Checked)
                GetEducation().SetSchoolType(Data.SchoolType.GraduateSchool);
            if (GetEducation().GetSchoolType() != Data.SchoolType.HighSchool)
            {
                Data.HigherEducation higherEducation = new Data.HigherEducation();
                higherEducation.SetSchoolType(GetEducation().GetSchoolType());
                higherEducation.SetDegreeName(txt_degreeName.Text);
                higherEducation.SetMajor(txt_major.Text);
                if (float.TryParse(txt_gpa.Text, out float gpa))
                    higherEducation.SetGPA(gpa);
                if (float.TryParse(txt_maxGpa.Text, out float maxGpa))
                    higherEducation.SetMaximumGPA(maxGpa);
                SetEducation(higherEducation);
            }
            switch (comboBox_Status.SelectedIndex)
            {
                case 0:
                    GetEducation().SetStatus(Data.SchoolRegistrationType.Enrolled);
                    break;
                case 1:
                    GetEducation().SetStatus(Data.SchoolRegistrationType.LeaveOfAbsence);
                    break;
                case 2:
                    GetEducation().SetStatus(Data.SchoolRegistrationType.Completed);
                    break;
                case 3:
                    GetEducation().SetStatus(Data.SchoolRegistrationType.Graduated);
                    break;
                case 4:
                    GetEducation().SetStatus(Data.SchoolRegistrationType.Expelled);
                    break;
            }
            GetEducation().SetSchoolName(txt_schoolName.Text);
            if (int.TryParse(txt_schoolYear.Text, out int schoolYear))
                GetEducation().SetSchoolYear(schoolYear);
            GetEducation().SetEnrolledAt(dateTime_admissionDate.Value);
            GetEducation().SetGraduatedAt(dateTime_graduationDate.Value);
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
