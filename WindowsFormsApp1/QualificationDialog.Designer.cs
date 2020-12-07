namespace WindowsFormsApp1
{
    partial class QualificationDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_institution = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.check_validForever = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTime_acquired = new System.Windows.Forms.DateTimePicker();
            this.dateTime_validUntil = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "자격증 이름";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(102, 12);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(271, 21);
            this.txt_name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "기관명";
            // 
            // txt_institution
            // 
            this.txt_institution.Location = new System.Drawing.Point(102, 41);
            this.txt_institution.Name = "txt_institution";
            this.txt_institution.Size = new System.Drawing.Size(271, 21);
            this.txt_institution.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "취득일";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "만료일";
            // 
            // check_validForever
            // 
            this.check_validForever.AutoSize = true;
            this.check_validForever.Location = new System.Drawing.Point(102, 124);
            this.check_validForever.Name = "check_validForever";
            this.check_validForever.Size = new System.Drawing.Size(100, 16);
            this.check_validForever.TabIndex = 2;
            this.check_validForever.Text = "유효기간 없음";
            this.check_validForever.UseVisualStyleBackColor = true;
            this.check_validForever.CheckedChanged += new System.EventHandler(this.check_validForever_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(286, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "취소";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(193, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "확인";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTime_acquired
            // 
            this.dateTime_acquired.Location = new System.Drawing.Point(102, 68);
            this.dateTime_acquired.Name = "dateTime_acquired";
            this.dateTime_acquired.Size = new System.Drawing.Size(271, 21);
            this.dateTime_acquired.TabIndex = 4;
            // 
            // dateTime_validUntil
            // 
            this.dateTime_validUntil.Location = new System.Drawing.Point(102, 95);
            this.dateTime_validUntil.Name = "dateTime_validUntil";
            this.dateTime_validUntil.Size = new System.Drawing.Size(271, 21);
            this.dateTime_validUntil.TabIndex = 4;
            // 
            // QualificationDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 180);
            this.ControlBox = false;
            this.Controls.Add(this.dateTime_validUntil);
            this.Controls.Add(this.dateTime_acquired);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.check_validForever);
            this.Controls.Add(this.txt_institution);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "QualificationDialog";
            this.Text = "자격증 추가 및 삭제";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_institution;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox check_validForever;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTime_acquired;
        private System.Windows.Forms.DateTimePicker dateTime_validUntil;
    }
}