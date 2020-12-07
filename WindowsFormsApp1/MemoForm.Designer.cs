namespace WindowsFormsApp1
{
    partial class MemoForm
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
            this.txt_memo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_memo
            // 
            this.txt_memo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_memo.Location = new System.Drawing.Point(0, 0);
            this.txt_memo.Multiline = true;
            this.txt_memo.Name = "txt_memo";
            this.txt_memo.Size = new System.Drawing.Size(776, 401);
            this.txt_memo.TabIndex = 0;
            // 
            // MemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 401);
            this.Controls.Add(this.txt_memo);
            this.Name = "MemoForm";
            this.Text = "메모";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_memo;
    }
}