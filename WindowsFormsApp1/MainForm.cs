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
    public partial class MainForm : Form
    {
        private MemoForm memoForm;
        private ResumeForm resumeForm;
        private ResumeManager resumeManager;
        private SelfIntroductionManager selfIntroductionManager;
        public MainForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            resumeManager = new ResumeManager();
            selfIntroductionManager = new SelfIntroductionManager();
            resumeForm = null;
            memoForm = null;
            this.WindowState = FormWindowState.Maximized;

            if (selfIntroductionManager.GetSelfIntroductionNames().Length == 0)
                selfIntroductionManager.SaveSelfIntroduction("기본", null);

            refreshSelfIntroductionToolStrip();
        }

        private void refreshSelfIntroductionToolStrip()
        {
            while (자기소개서ToolStripMenuItem.DropDownItems.Count > 2)
                자기소개서ToolStripMenuItem.DropDownItems.RemoveAt(2);

            foreach (string i in selfIntroductionManager.GetSelfIntroductionNames())
            {
                ToolStripDropDownItem item = new ToolStripMenuItem();
                item.Text = i;
                item.Tag = i;
                item.Click += OnSelfIntroductionMenuClicked;

                자기소개서ToolStripMenuItem.DropDownItems.Add(item);
            }
        }

        private void OnSelfIntroductionMenuClicked(object sender, EventArgs e)
        {
            string name = (string)(sender as ToolStripMenuItem).Tag;
            SelfIntroductionDialog dialog = new SelfIntroductionDialog(name, selfIntroductionManager);
            dialog.MdiParent = this;
            dialog.OnFileRenamedOrDeleted += OnSelfIntroductionFileChanged;
            dialog.Show();
        }

        private void OnSelfIntroductionFileChanged(object sender, EventArgs e)
        {
            refreshSelfIntroductionToolStrip();
        }

        private void 메모ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (memoForm == null || memoForm.IsDisposed)
            {
                memoForm = new MemoForm();
                memoForm.TopMost = true;
                memoForm.Show();
            }
        }

        private void 이력서ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (resumeForm == null || resumeForm.IsDisposed)
            {
                resumeForm = new ResumeForm(resumeManager);
                resumeForm.MdiParent = this;
                resumeForm.Show();
            }
        }

        private void 새로만들기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputBoxDialog inputBox = new InputBoxDialog();
            inputBox.SetDescription("새로 만들 자기소개서 이름을 입력하세요.");
            if (inputBox.ShowDialog() == DialogResult.OK)
            {
                string name = inputBox.GetResult();
                if (name.Any((char i) => System.IO.Path.GetInvalidFileNameChars().Contains(i))) {
                    MessageBox.Show("잘못된 이름입니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                } else if(selfIntroductionManager.GetSelfIntroductionNames().Contains(name))
                {
                    MessageBox.Show("이미 존재하는 이름입니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                selfIntroductionManager.SaveSelfIntroduction(name, null);
                refreshSelfIntroductionToolStrip();

                SelfIntroductionDialog dialog = new SelfIntroductionDialog(name, selfIntroductionManager);
                dialog.OnFileRenamedOrDeleted += OnSelfIntroductionFileChanged;
                dialog.MdiParent = this;
                dialog.Show();
            }
        }
    }
}
