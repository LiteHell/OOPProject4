namespace WindowsFormsApp1
{
    partial class EducationDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_schoolName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radio_highSchool = new System.Windows.Forms.RadioButton();
            this.radio_University = new System.Windows.Forms.RadioButton();
            this.radio_graduateSchool = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_schoolYear = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox_Status = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_degreeName = new System.Windows.Forms.TextBox();
            this.dateTime_admissionDate = new System.Windows.Forms.DateTimePicker();
            this.dateTime_graduationDate = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_major = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_gpa = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_maxGpa = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_schoolName
            // 
            this.txt_schoolName.Location = new System.Drawing.Point(114, 43);
            this.txt_schoolName.Name = "txt_schoolName";
            this.txt_schoolName.Size = new System.Drawing.Size(203, 21);
            this.txt_schoolName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "학교명";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "학교구분";
            // 
            // radio_highSchool
            // 
            this.radio_highSchool.AutoSize = true;
            this.radio_highSchool.Location = new System.Drawing.Point(114, 21);
            this.radio_highSchool.Name = "radio_highSchool";
            this.radio_highSchool.Size = new System.Drawing.Size(71, 16);
            this.radio_highSchool.TabIndex = 2;
            this.radio_highSchool.TabStop = true;
            this.radio_highSchool.Text = "고등학교";
            this.radio_highSchool.UseVisualStyleBackColor = true;
            // 
            // radio_University
            // 
            this.radio_University.AutoSize = true;
            this.radio_University.Location = new System.Drawing.Point(191, 21);
            this.radio_University.Name = "radio_University";
            this.radio_University.Size = new System.Drawing.Size(59, 16);
            this.radio_University.TabIndex = 2;
            this.radio_University.TabStop = true;
            this.radio_University.Text = "대학교";
            this.radio_University.UseVisualStyleBackColor = true;
            // 
            // radio_graduateSchool
            // 
            this.radio_graduateSchool.AutoSize = true;
            this.radio_graduateSchool.Location = new System.Drawing.Point(258, 21);
            this.radio_graduateSchool.Name = "radio_graduateSchool";
            this.radio_graduateSchool.Size = new System.Drawing.Size(59, 16);
            this.radio_graduateSchool.TabIndex = 2;
            this.radio_graduateSchool.TabStop = true;
            this.radio_graduateSchool.Text = "대학원";
            this.radio_graduateSchool.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "학적";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "입학일";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "졸업/수료일";
            // 
            // txt_schoolYear
            // 
            this.txt_schoolYear.Location = new System.Drawing.Point(114, 70);
            this.txt_schoolYear.Mask = "9";
            this.txt_schoolYear.Name = "txt_schoolYear";
            this.txt_schoolYear.Size = new System.Drawing.Size(23, 21);
            this.txt_schoolYear.TabIndex = 3;
            this.txt_schoolYear.ValidatingType = typeof(int);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(143, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "학년";
            // 
            // comboBox_Status
            // 
            this.comboBox_Status.FormattingEnabled = true;
            this.comboBox_Status.Items.AddRange(new object[] {
            "재학",
            "휴학",
            "수료",
            "졸업",
            "제적"});
            this.comboBox_Status.Location = new System.Drawing.Point(178, 70);
            this.comboBox_Status.Name = "comboBox_Status";
            this.comboBox_Status.Size = new System.Drawing.Size(139, 20);
            this.comboBox_Status.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "학위명";
            // 
            // txt_degreeName
            // 
            this.txt_degreeName.Location = new System.Drawing.Point(89, 17);
            this.txt_degreeName.Name = "txt_degreeName";
            this.txt_degreeName.Size = new System.Drawing.Size(197, 21);
            this.txt_degreeName.TabIndex = 0;
            // 
            // dateTime_admissionDate
            // 
            this.dateTime_admissionDate.Location = new System.Drawing.Point(114, 97);
            this.dateTime_admissionDate.Name = "dateTime_admissionDate";
            this.dateTime_admissionDate.Size = new System.Drawing.Size(203, 21);
            this.dateTime_admissionDate.TabIndex = 6;
            // 
            // dateTime_graduationDate
            // 
            this.dateTime_graduationDate.Location = new System.Drawing.Point(114, 124);
            this.dateTime_graduationDate.Name = "dateTime_graduationDate";
            this.dateTime_graduationDate.Size = new System.Drawing.Size(203, 21);
            this.dateTime_graduationDate.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "취소";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(161, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "확인";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_maxGpa);
            this.groupBox1.Controls.Add(this.txt_gpa);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_major);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_degreeName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(25, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 104);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "대학/대학원";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "전공";
            // 
            // txt_major
            // 
            this.txt_major.Location = new System.Drawing.Point(89, 44);
            this.txt_major.Name = "txt_major";
            this.txt_major.Size = new System.Drawing.Size(197, 21);
            this.txt_major.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 1;
            this.label9.Text = "평점";
            // 
            // txt_gpa
            // 
            this.txt_gpa.Location = new System.Drawing.Point(89, 74);
            this.txt_gpa.Mask = "9.99";
            this.txt_gpa.Name = "txt_gpa";
            this.txt_gpa.Size = new System.Drawing.Size(81, 21);
            this.txt_gpa.TabIndex = 2;
            this.txt_gpa.ValidatingType = typeof(int);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(176, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 12);
            this.label10.TabIndex = 1;
            this.label10.Text = "/";
            // 
            // txt_maxGpa
            // 
            this.txt_maxGpa.Location = new System.Drawing.Point(193, 74);
            this.txt_maxGpa.Mask = "9.99";
            this.txt_maxGpa.Name = "txt_maxGpa";
            this.txt_maxGpa.Size = new System.Drawing.Size(93, 21);
            this.txt_maxGpa.TabIndex = 2;
            this.txt_maxGpa.ValidatingType = typeof(int);
            // 
            // EducationDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 296);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTime_graduationDate);
            this.Controls.Add(this.dateTime_admissionDate);
            this.Controls.Add(this.comboBox_Status);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_schoolYear);
            this.Controls.Add(this.radio_graduateSchool);
            this.Controls.Add(this.radio_University);
            this.Controls.Add(this.radio_highSchool);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_schoolName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EducationDialog";
            this.Text = "학력사항 추가 및 수정";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_schoolName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radio_highSchool;
        private System.Windows.Forms.RadioButton radio_University;
        private System.Windows.Forms.RadioButton radio_graduateSchool;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txt_schoolYear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_Status;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_degreeName;
        private System.Windows.Forms.DateTimePicker dateTime_admissionDate;
        private System.Windows.Forms.DateTimePicker dateTime_graduationDate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_major;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txt_maxGpa;
        private System.Windows.Forms.MaskedTextBox txt_gpa;
        private System.Windows.Forms.Label label10;
    }
}