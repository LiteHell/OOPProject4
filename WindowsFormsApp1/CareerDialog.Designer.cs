namespace WindowsFormsApp1
{
    partial class CareerDialog
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
            this.txt_position = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTime_workedFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTime_workedUntil = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_responsiblities = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "회사명";
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
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "직위";
            // 
            // txt_position
            // 
            this.txt_position.Location = new System.Drawing.Point(102, 41);
            this.txt_position.Name = "txt_position";
            this.txt_position.Size = new System.Drawing.Size(271, 21);
            this.txt_position.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "입사일";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "퇴사일";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(285, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "취소";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(192, 149);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "확인";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTime_workedFrom
            // 
            this.dateTime_workedFrom.Location = new System.Drawing.Point(102, 95);
            this.dateTime_workedFrom.Name = "dateTime_workedFrom";
            this.dateTime_workedFrom.Size = new System.Drawing.Size(271, 21);
            this.dateTime_workedFrom.TabIndex = 4;
            // 
            // dateTime_workedUntil
            // 
            this.dateTime_workedUntil.Location = new System.Drawing.Point(102, 122);
            this.dateTime_workedUntil.Name = "dateTime_workedUntil";
            this.dateTime_workedUntil.Size = new System.Drawing.Size(271, 21);
            this.dateTime_workedUntil.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "담당업무";
            // 
            // txt_responsiblities
            // 
            this.txt_responsiblities.Location = new System.Drawing.Point(102, 68);
            this.txt_responsiblities.Name = "txt_responsiblities";
            this.txt_responsiblities.Size = new System.Drawing.Size(271, 21);
            this.txt_responsiblities.TabIndex = 1;
            // 
            // CareerDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 180);
            this.ControlBox = false;
            this.Controls.Add(this.dateTime_workedUntil);
            this.Controls.Add(this.dateTime_workedFrom);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_responsiblities);
            this.Controls.Add(this.txt_position);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CareerDialog";
            this.Text = "자격증 추가 및 삭제";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_position;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTime_workedFrom;
        private System.Windows.Forms.DateTimePicker dateTime_workedUntil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_responsiblities;
    }
}