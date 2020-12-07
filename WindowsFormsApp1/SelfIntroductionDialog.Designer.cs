namespace WindowsFormsApp1
{
    partial class SelfIntroductionDialog
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.복제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtn_renameSelfIntroduction = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtn_cloneSelfIntroduction = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtn_deleteSelfIntroduction = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtn_exportSelfIntroduction = new System.Windows.Forms.ToolStripMenuItem();
            this.질문ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtn_deleteQuestion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtn_cloneQuestion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtn_addQuestion = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(660, 533);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(652, 507);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 533);
            this.panel1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.복제ToolStripMenuItem,
            this.질문ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(657, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 복제ToolStripMenuItem
            // 
            this.복제ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBtn_renameSelfIntroduction,
            this.menuBtn_cloneSelfIntroduction,
            this.menuBtn_deleteSelfIntroduction,
            this.menuBtn_exportSelfIntroduction});
            this.복제ToolStripMenuItem.Name = "복제ToolStripMenuItem";
            this.복제ToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.복제ToolStripMenuItem.Text = "자기소개서";
            // 
            // menuBtn_renameSelfIntroduction
            // 
            this.menuBtn_renameSelfIntroduction.Name = "menuBtn_renameSelfIntroduction";
            this.menuBtn_renameSelfIntroduction.Size = new System.Drawing.Size(180, 22);
            this.menuBtn_renameSelfIntroduction.Text = "이름 바꾸기";
            this.menuBtn_renameSelfIntroduction.Click += new System.EventHandler(this.menuBtn_renameSelfIntroduction_Click);
            // 
            // menuBtn_cloneSelfIntroduction
            // 
            this.menuBtn_cloneSelfIntroduction.Name = "menuBtn_cloneSelfIntroduction";
            this.menuBtn_cloneSelfIntroduction.Size = new System.Drawing.Size(180, 22);
            this.menuBtn_cloneSelfIntroduction.Text = "복제";
            this.menuBtn_cloneSelfIntroduction.Click += new System.EventHandler(this.menuBtn_cloneSelfIntroduction_Click);
            // 
            // menuBtn_deleteSelfIntroduction
            // 
            this.menuBtn_deleteSelfIntroduction.Name = "menuBtn_deleteSelfIntroduction";
            this.menuBtn_deleteSelfIntroduction.Size = new System.Drawing.Size(180, 22);
            this.menuBtn_deleteSelfIntroduction.Text = "삭제";
            this.menuBtn_deleteSelfIntroduction.Click += new System.EventHandler(this.menuBtn_deleteSelfIntroduction_Click);
            // 
            // menuBtn_exportSelfIntroduction
            // 
            this.menuBtn_exportSelfIntroduction.Name = "menuBtn_exportSelfIntroduction";
            this.menuBtn_exportSelfIntroduction.Size = new System.Drawing.Size(180, 22);
            this.menuBtn_exportSelfIntroduction.Text = "내보내기";
            this.menuBtn_exportSelfIntroduction.Click += new System.EventHandler(this.menuBtn_exportSelfIntroduction_Click);
            // 
            // 질문ToolStripMenuItem
            // 
            this.질문ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBtn_deleteQuestion,
            this.menuBtn_cloneQuestion,
            this.menuBtn_addQuestion});
            this.질문ToolStripMenuItem.Name = "질문ToolStripMenuItem";
            this.질문ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.질문ToolStripMenuItem.Text = "질문";
            // 
            // menuBtn_deleteQuestion
            // 
            this.menuBtn_deleteQuestion.Name = "menuBtn_deleteQuestion";
            this.menuBtn_deleteQuestion.Size = new System.Drawing.Size(180, 22);
            this.menuBtn_deleteQuestion.Text = "해당 질문 삭제";
            this.menuBtn_deleteQuestion.Click += new System.EventHandler(this.menuBtn_deleteQuestion_Click);
            // 
            // menuBtn_cloneQuestion
            // 
            this.menuBtn_cloneQuestion.Name = "menuBtn_cloneQuestion";
            this.menuBtn_cloneQuestion.Size = new System.Drawing.Size(180, 22);
            this.menuBtn_cloneQuestion.Text = "해당 질문 복제";
            this.menuBtn_cloneQuestion.Click += new System.EventHandler(this.menuBtn_cloneQuestion_Click);
            // 
            // menuBtn_addQuestion
            // 
            this.menuBtn_addQuestion.Name = "menuBtn_addQuestion";
            this.menuBtn_addQuestion.Size = new System.Drawing.Size(180, 22);
            this.menuBtn_addQuestion.Text = "새로운 질문 추가";
            this.menuBtn_addQuestion.Click += new System.EventHandler(this.menuBtn_addQuestion_Click);
            // 
            // SelfIntroductionDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "SelfIntroductionDialog";
            this.Text = "자기소개서";
            this.tabControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 복제ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuBtn_renameSelfIntroduction;
        private System.Windows.Forms.ToolStripMenuItem menuBtn_cloneSelfIntroduction;
        private System.Windows.Forms.ToolStripMenuItem menuBtn_deleteSelfIntroduction;
        private System.Windows.Forms.ToolStripMenuItem menuBtn_exportSelfIntroduction;
        private System.Windows.Forms.ToolStripMenuItem 질문ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuBtn_deleteQuestion;
        private System.Windows.Forms.ToolStripMenuItem menuBtn_cloneQuestion;
        private System.Windows.Forms.ToolStripMenuItem menuBtn_addQuestion;
    }
}