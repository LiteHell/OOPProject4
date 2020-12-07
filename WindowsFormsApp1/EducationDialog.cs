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
        public Data.Education Education { get; set; }
        public EducationDialog()
        {
            InitializeComponent();
            Education = new Data.Education();
            this.Load += EducationDialog_Load;
        }

        private void EducationDialog_Load(object sender, EventArgs e)
        {
            LoadEducation();
        }

        private void LoadEducation()
        {
            switch (Education.SchoolType)
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
            switch (Education.Status)
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
            txt_schoolName.Text = Education.SchoolName;
            txt_schoolYear.Text = Education.SchoolYear.ToString();
            dateTime_admissionDate.Value = Education.EnrolledAt;
            dateTime_graduationDate.Value = Education.GraduatedAt;
            if (Education.SchoolType != Data.SchoolType.HighSchool)
            {
                Data.HigherEducation higherEducation = (Data.HigherEducation)Education;
                txt_degreeName.Text = higherEducation.DegreeName;
                txt_major.Text = higherEducation.Major;
                txt_gpa.Text = higherEducation.GPA.ToString();
                txt_maxGpa.Text = higherEducation.MaximumGPA.ToString();
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (radio_highSchool.Checked)
                Education.SchoolType = Data.SchoolType.HighSchool;
            else if (radio_University.Checked)
                Education.SchoolType = Data.SchoolType.University;
            else if (radio_graduateSchool.Checked)
                Education.SchoolType = Data.SchoolType.GraduateSchool;
            if (Education.SchoolType != Data.SchoolType.HighSchool)
            {
                Data.HigherEducation higherEducation = new Data.HigherEducation();
                higherEducation.SchoolType = Education.SchoolType;
                higherEducation.DegreeName = txt_degreeName.Text;
                higherEducation.Major = txt_major.Text;
                if (float.TryParse(txt_gpa.Text, out float gpa))
                    higherEducation.GPA = gpa;
                if (float.TryParse(txt_maxGpa.Text, out float maxGpa))
                    higherEducation.MaximumGPA = maxGpa;
                Education = higherEducation;
            }
            switch (comboBox_Status.SelectedIndex)
            {
                case 0:
                    Education.Status = Data.SchoolRegistrationType.Enrolled;
                    break;
                case 1:
                    Education.Status = Data.SchoolRegistrationType.LeaveOfAbsence;
                    break;
                case 2:
                    Education.Status = Data.SchoolRegistrationType.Completed;
                    break;
                case 3:
                    Education.Status = Data.SchoolRegistrationType.Graduated;
                    break;
                case 4:
                    Education.Status = Data.SchoolRegistrationType.Expelled;
                    break;
            }
            Education.SchoolName = txt_schoolName.Text;
            if (int.TryParse(txt_schoolYear.Text, out int schoolYear))
                Education.SchoolYear = schoolYear;
            Education.EnrolledAt = dateTime_admissionDate.Value;
            Education.GraduatedAt = dateTime_graduationDate.Value;
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
