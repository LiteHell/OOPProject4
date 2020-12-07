namespace WindowsFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.이력서ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.자기소개서ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새로만들기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.메모ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.이력서ToolStripMenuItem,
            this.자기소개서ToolStripMenuItem,
            this.메모ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(599, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 이력서ToolStripMenuItem
            // 
            this.이력서ToolStripMenuItem.Name = "이력서ToolStripMenuItem";
            this.이력서ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.이력서ToolStripMenuItem.Text = "이력서";
            this.이력서ToolStripMenuItem.Click += new System.EventHandler(this.이력서ToolStripMenuItem_Click);
            // 
            // 자기소개서ToolStripMenuItem
            // 
            this.자기소개서ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새로만들기ToolStripMenuItem,
            this.toolStripSeparator1});
            this.자기소개서ToolStripMenuItem.Name = "자기소개서ToolStripMenuItem";
            this.자기소개서ToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.자기소개서ToolStripMenuItem.Text = "자기소개서";
            // 
            // 새로만들기ToolStripMenuItem
            // 
            this.새로만들기ToolStripMenuItem.Name = "새로만들기ToolStripMenuItem";
            this.새로만들기ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.새로만들기ToolStripMenuItem.Text = "새로 만들기";
            this.새로만들기ToolStripMenuItem.Click += new System.EventHandler(this.새로만들기ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // 메모ToolStripMenuItem
            // 
            this.메모ToolStripMenuItem.Name = "메모ToolStripMenuItem";
            this.메모ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.메모ToolStripMenuItem.Text = "메모";
            this.메모ToolStripMenuItem.Click += new System.EventHandler(this.메모ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "스펙관리프로그램";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 이력서ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 자기소개서ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 새로만들기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 메모ToolStripMenuItem;
    }
}

