using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Data;

namespace WindowsFormsApp1
{
    public partial class ResumeForm : Form
    {
        private ResumeManager manager;
        public ResumeForm(ResumeManager manager)
        {
            this.manager = manager;
            InitializeComponent();
            txt_addr.TextChanged += SaveResumeHandler;
            txt_email.TextChanged += SaveResumeHandler;
            txt_name.TextChanged += SaveResumeHandler;
            txt_phone.TextChanged += SaveResumeHandler;
            txt_tel.TextChanged += SaveResumeHandler;
            dateTime_birthday.ValueChanged += SaveResumeHandler;
            LoadResume();
        }
        private void LoadResume()
        {
            Resume resume = manager.GetResume();
            txt_addr.Text = resume.Address;
            txt_email.Text = resume.Email;
            txt_name.Text = resume.Name;
            txt_phone.Text = resume.PhoneNumber;
            txt_tel.Text = resume.Telephone;
            dateTime_birthday.Value = resume.Birthday;
            if (resume.Picture != null)
                image_picture.Image = resume.Picture;

            // 학력
            listView1.BeginUpdate();
            listView1.Items.Clear();
            int realIndex = 0;
            foreach(Education i in resume.Educations)
            {
                ListViewItem item = new ListViewItem();
                item.Text = i.SchoolName;
                if (i.SchoolType == SchoolType.HighSchool)
                {
                    item.SubItems.AddRange(new string[] { "(고졸)", "(고졸)", "(고졸)", i.EnrolledAt.ToShortDateString(), i.GraduatedAt.ToShortDateString() });
                } else
                {
                    HigherEducation higherI = (HigherEducation)i;
                    item.SubItems.AddRange(new string[] {  higherI.DegreeName, higherI.Major, $"{higherI.GPA}/{higherI.MaximumGPA}", i.EnrolledAt.ToShortDateString(), i.GraduatedAt.ToShortDateString() });
                }
                item.Tag = realIndex++;
                listView1.Items.Add(item);
            }
            listView1.EndUpdate();

            // 자격증
            realIndex = 0;
            listView2.BeginUpdate();
            listView2.Items.Clear();
            foreach (Qualification i in resume.Certificates)
            {
                ListViewItem item = new ListViewItem();
                item.Text = i.Name;
                item.SubItems.AddRange(new string[] { i.AwardingInstitution, i.AcquisitiedAt.ToShortDateString(), i.ValidForever ? "" : i.ValidUntil.ToShortDateString() });
                item.Tag = realIndex++;
                listView2.Items.Add(item);
            }
            listView2.EndUpdate();

            //경력
            realIndex = 0;
            listView3.BeginUpdate();
            listView3.Items.Clear();
            foreach (Career i in resume.Careers)
            {
                ListViewItem item = new ListViewItem();
                item.Text = i.CompanyName;
                item.SubItems.AddRange(new string[] { i.Position, i.Responsibilities, i.WorkedSince.ToShortDateString(), i.WorkedUntil.ToShortDateString() });
                item.Tag = realIndex++;
                listView3.Items.Add(item);
            }
            listView3.EndUpdate();
        }

        private void SaveResumeHandler(object sender, EventArgs e)
        {
            Resume resume = manager.GetResume();
            resume.Address = txt_addr.Text;
            resume.Email = txt_email.Text;
            resume.Name = txt_name.Text;
            resume.Telephone = txt_tel.Text;
            resume.PhoneNumber = txt_phone.Text;
            resume.Birthday = dateTime_birthday.Value;
            manager.SetResume(resume);
        }

        private void btn_changePicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "이미지 파일|*.png;*.jpg;*.jpeg;*.bmp|PNG 파일|*.png|JPEG 파일|*.jpg;*.jpeg|BMP 파일|*.bmp|모든 파일|*.*";
            openFileDialog.Title = "사진 선택";
            openFileDialog.CheckFileExists = true;
            openFileDialog.Multiselect = false;
            DialogResult dialogResult = openFileDialog.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                Image image = Image.FromFile(openFileDialog.FileName);
                Resume resume = manager.GetResume();
                resume.Picture = image;
                image_picture.Image = image;
                manager.SetResume(resume);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EducationDialog dialog = new EducationDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                Resume resume = manager.GetResume();
                resume.Educations.Add(dialog.Education);
                manager.SetResume(resume);
                LoadResume();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                Resume resume = manager.GetResume();
                resume.Educations.RemoveAt((int)listView1.SelectedItems[0].Tag);
                manager.SetResume(resume);
                LoadResume();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                return;
            }
            EducationDialog dialog = new EducationDialog();
            Resume resume = manager.GetResume();
            int selectedIndex = (int)listView1.SelectedItems[0].Tag;
            dialog.Education = resume.Educations[selectedIndex];
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                resume.Educations[selectedIndex] = dialog.Education;
                manager.SetResume(resume);
                LoadResume();
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            QualificationDialog dialog = new QualificationDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                Resume resume = manager.GetResume();
                resume.Certificates.Add(dialog.Qualification);
                manager.SetResume(resume);
                LoadResume();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count != 0)
            {
                Resume resume = manager.GetResume();
                resume.Certificates.RemoveAt((int)listView2.SelectedItems[0].Tag);
                manager.SetResume(resume);
                LoadResume();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (listView2.SelectedItems.Count == 0)
            {
                return;
            }
            QualificationDialog dialog = new QualificationDialog();
            Resume resume = manager.GetResume();
            int selectedIndex = (int)listView2.SelectedItems[0].Tag;
            dialog.Qualification = resume.Certificates[selectedIndex];
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                resume.Certificates[selectedIndex] = dialog.Qualification;
                manager.SetResume(resume);
                LoadResume();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            CareerDialog dialog = new CareerDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                Resume resume = manager.GetResume();
                resume.Careers.Add(dialog.Career);
                manager.SetResume(resume);
                LoadResume();
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (listView3.SelectedItems.Count != 0)
            {
                Resume resume = manager.GetResume();
                resume.Careers.RemoveAt((int)listView3.SelectedItems[0].Tag);
                manager.SetResume(resume);
                LoadResume();
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (listView3.SelectedItems.Count == 0)
            {
                return;
            }
            CareerDialog dialog = new CareerDialog();
            Resume resume = manager.GetResume();
            int selectedIndex = (int)listView3.SelectedItems[0].Tag;
            dialog.Career = resume.Careers[selectedIndex];
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                resume.Careers[selectedIndex] = dialog.Career;
                manager.SetResume(resume);
                LoadResume();
            }

        }
    }
}
