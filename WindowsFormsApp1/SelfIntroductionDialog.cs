using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SelfIntroductionDialog : Form
    {
        public event EventHandler OnFileRenamedOrDeleted;
        private string selfIntroductionName;
        private SelfIntroductionManager selfIntroductionManager;

        public string GetSelfIntroductionName()
        {
            return selfIntroductionName;
        }

        public void SetSelfIntroductionName(string value)
        {
            selfIntroductionName = value;
        }


        public SelfIntroductionManager GetSelfIntroductionManager()
        {
            return selfIntroductionManager;
        }

        public void SetSelfIntroductionManager(SelfIntroductionManager value)
        {
            selfIntroductionManager = value;
        }

        public SelfIntroductionDialog(string name, SelfIntroductionManager manager)
        {
            this.SetSelfIntroductionName(name);
            this.SetSelfIntroductionManager(manager);
            InitializeComponent();
            this.Text = "자기소개서 - " + this.GetSelfIntroductionName();
            loadIntroductions();
            OnFileRenamedOrDeleted += (object sender, EventArgs e) => { };
         }
        private void loadIntroductions()
        {
            Data.SelfIntroduction data = GetSelfIntroductionManager().GetSelfIntroduction(GetSelfIntroductionName());
            tabControl1.SuspendLayout();
            tabControl1.Controls.Clear();
            for (int i = 0; i < data.Questions.Count; i++)
            {
                createQuestionTabPage(i, data.Questions[i]);
            }
            tabControl1.ResumeLayout(false);
            tabControl1.PerformLayout();
        }
        private void createQuestionTabPage(int questionIndex, Data.SelfIntroductionQuestion question)
        {
            // 질문/답변 라벨
            Label questionLabel = new Label();
            questionLabel.AutoSize = true;
            questionLabel.Location = new System.Drawing.Point(18, 13);
            questionLabel.Size = new System.Drawing.Size(29, 12);
            questionLabel.TabIndex = 0;
            questionLabel.Text = "질문";
            Label answerLabel = new Label();
            answerLabel.AutoSize = true;
            answerLabel.Location = new System.Drawing.Point(18, 91);
            answerLabel.Name = "answerLabel";
            answerLabel.Size = new System.Drawing.Size(29, 12);
            answerLabel.TabIndex = 0;
            answerLabel.Text = "답변";

            // 
            // 글자수 세는 라벨
            // 
            Label countLabel = new Label();
            countLabel.AutoSize = true;
            countLabel.Location = new System.Drawing.Point(18, 476);
            countLabel.Name = "countLabel";
            countLabel.Size = new System.Drawing.Size(87, 12);
            countLabel.TabIndex = 0;
            countLabel.Text = "현재 글자수 : " + question.GetAnswer().Length;

            // 
            // 텍스트박스와 패널 변수 선언
            // 
            TextBox questionTextBox = new TextBox();
            TextBox answerTextBox = new TextBox();
            Panel panel = new Panel();

            // 
            // 탭페이지
            // 
            TabPage tabpage = new TabPage();
            tabpage.Controls.Add(panel);
            tabpage.Location = new System.Drawing.Point(4, 22);
            tabpage.Name = "tabpage";
            tabpage.Padding = new System.Windows.Forms.Padding(3);
            tabpage.Size = new System.Drawing.Size(652, 507);
            tabpage.TabIndex = 0;
            tabpage.Text = (questionIndex + 1) + "번 질문";
            tabpage.Tag = questionIndex;
            tabpage.UseVisualStyleBackColor = true;


            // 질문 텍스트박스

            questionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            questionTextBox.Location = new System.Drawing.Point(20, 28);
            questionTextBox.Multiline = true;
            questionTextBox.Name = "questionTextBox";
            questionTextBox.Size = new System.Drawing.Size(600, 48);
            questionTextBox.TabIndex = 1;
            questionTextBox.Text = question.GetQuestion();
            questionTextBox.Tag = questionIndex;
            questionTextBox.TextChanged += OnQuestionTextChanged;

            // 
            // 답변 텍스트박스
            // 
            answerTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            answerTextBox.Location = new System.Drawing.Point(20, 106);
            answerTextBox.Multiline = true;
            answerTextBox.Name = "answerTextBox";
            answerTextBox.Size = new System.Drawing.Size(600, 367);
            answerTextBox.TabIndex = 2;
            answerTextBox.Text = question.GetAnswer();
            answerTextBox.Tag = questionIndex;
            answerTextBox.TextChanged += OnAnswerTextChanged;

            // 패널
            panel.Dock = System.Windows.Forms.DockStyle.Fill;
            panel.Location = new System.Drawing.Point(3, 3);
            panel.Name = "panel";
            panel.Size = new System.Drawing.Size(646, 501);
            panel.TabIndex = 0;
            panel.Controls.Add(questionLabel);
            panel.Controls.Add(answerLabel);
            panel.Controls.Add(countLabel);
            panel.Controls.Add(questionTextBox);
            panel.Controls.Add(answerTextBox);

            // 탭컨트롤에 추가
            tabControl1.Controls.Add(tabpage);
        }

        private void OnQuestionTextChanged(object sender, EventArgs e)
        {
            int questionIndex = (int)(sender as Control).Tag;
            Data.SelfIntroduction selfIntroduction = GetSelfIntroductionManager().GetSelfIntroduction(GetSelfIntroductionName());
            selfIntroduction.Questions[questionIndex].SetQuestion((sender as TextBox).Text);
            GetSelfIntroductionManager().SaveSelfIntroduction(GetSelfIntroductionName(), selfIntroduction);
        }
        private void OnAnswerTextChanged(object sender, EventArgs e)
        {
            int questionIndex = (int)(sender as Control).Tag;
            Data.SelfIntroduction selfIntroduction = GetSelfIntroductionManager().GetSelfIntroduction(GetSelfIntroductionName());
            selfIntroduction.Questions[questionIndex].SetAnswer((sender as TextBox).Text);
            (sender as Control).Parent.Controls["countLabel"].Text = "현재 글자수 : " + selfIntroduction.Questions[questionIndex].GetAnswer().Length;
            GetSelfIntroductionManager().SaveSelfIntroduction(GetSelfIntroductionName(), selfIntroduction);
        }

        private void menuBtn_renameSelfIntroduction_Click(object sender, EventArgs e)
        {
            InputBoxDialog inputBox = new InputBoxDialog();
            inputBox.SetDescription("새로운 이름을 입력하세요.");
            if (inputBox.ShowDialog() == DialogResult.OK)
            {
                if (GetSelfIntroductionManager().GetSelfIntroductionNames().Contains(inputBox.GetResult()))
                {
                    MessageBox.Show("이미 존재하는 이름입니다.");
                    return;
                }
                Data.SelfIntroduction selfIntroduction = GetSelfIntroductionManager().GetSelfIntroduction(GetSelfIntroductionName());
                GetSelfIntroductionManager().DeleteSelfIntroduction(GetSelfIntroductionName());
                SetSelfIntroductionName(inputBox.GetResult());
                GetSelfIntroductionManager().SaveSelfIntroduction(GetSelfIntroductionName(), selfIntroduction);
                OnFileRenamedOrDeleted(this, new EventArgs());
                this.Text = "자기소개서 - " + this.GetSelfIntroductionName();
            }
        }

        private void menuBtn_cloneSelfIntroduction_Click(object sender, EventArgs e)
        {

            InputBoxDialog inputBox = new InputBoxDialog();
            inputBox.SetDescription("새로운 이름을 입력하세요.");
            if (inputBox.ShowDialog() == DialogResult.OK)
            {
                if (GetSelfIntroductionManager().GetSelfIntroductionNames().Contains(inputBox.GetResult()))
                {
                    MessageBox.Show("이미 존재하는 이름입니다.");
                    return;
                }
                Data.SelfIntroduction selfIntroduction = GetSelfIntroductionManager().GetSelfIntroduction(GetSelfIntroductionName());
                GetSelfIntroductionManager().SaveSelfIntroduction(inputBox.GetResult(), selfIntroduction);
                OnFileRenamedOrDeleted(this, new EventArgs());

                SelfIntroductionDialog dialog = new SelfIntroductionDialog(inputBox.GetResult(), GetSelfIntroductionManager());
                dialog.OnFileRenamedOrDeleted += OnFileRenamedOrDeleted;
                dialog.MdiParent = this.MdiParent;
                dialog.Show();
            }
        }

        private void menuBtn_deleteSelfIntroduction_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정말로 이 자기소개서를 삭제하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                GetSelfIntroductionManager().DeleteSelfIntroduction(GetSelfIntroductionName());
                OnFileRenamedOrDeleted(this, new EventArgs());
                this.Close();
            }
        }

        private void menuBtn_deleteQuestion_Click(object sender, EventArgs e)
        {
            TabPage page = tabControl1.SelectedTab;
            int questionIndex = (int)page.Tag;
            int tabIndexToSelect = tabControl1.SelectedIndex - 1;
            if (tabIndexToSelect < 0) tabIndexToSelect = 0;
            if (MessageBox.Show("정말로 이 " + (questionIndex + 1) + "번 질문을 삭제하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Data.SelfIntroduction selfIntroduction = GetSelfIntroductionManager().GetSelfIntroduction(GetSelfIntroductionName());
                selfIntroduction.Questions.RemoveAt(questionIndex);
                if (selfIntroduction.Questions.Count == 0)
                    selfIntroduction.Questions.Add(new Data.SelfIntroductionQuestion());
                GetSelfIntroductionManager().SaveSelfIntroduction(GetSelfIntroductionName(), selfIntroduction);
                loadIntroductions();
                tabControl1.SelectTab(tabIndexToSelect);
            }
        }

        private void menuBtn_addQuestion_Click(object sender, EventArgs e)
        {
            Data.SelfIntroduction selfIntroduction = GetSelfIntroductionManager().GetSelfIntroduction(GetSelfIntroductionName());
            selfIntroduction.Questions.Add(new Data.SelfIntroductionQuestion());
            GetSelfIntroductionManager().SaveSelfIntroduction(GetSelfIntroductionName(), selfIntroduction);
            loadIntroductions();
            tabControl1.SelectTab(tabControl1.TabCount - 1);
        }

        private void menuBtn_cloneQuestion_Click(object sender, EventArgs e)
        {
            TabPage page = tabControl1.SelectedTab;
            int questionIndex = (int)page.Tag;
            Data.SelfIntroduction selfIntroduction = GetSelfIntroductionManager().GetSelfIntroduction(GetSelfIntroductionName());
            selfIntroduction.Questions.Add(new Data.SelfIntroductionQuestion(selfIntroduction.Questions[questionIndex]));
            GetSelfIntroductionManager().SaveSelfIntroduction(GetSelfIntroductionName(), selfIntroduction);
            loadIntroductions();
            tabControl1.SelectTab(tabControl1.TabCount - 1);
        }

        private void menuBtn_exportSelfIntroduction_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "텍스트 파일|*.txt";
            saveFileDialog.Title = "텍스트 파일로 내보내기";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = File.OpenWrite(saveFileDialog.FileName))
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    StringBuilder sb = new StringBuilder();

                    Data.SelfIntroduction selfIntroduction = GetSelfIntroductionManager().GetSelfIntroduction(GetSelfIntroductionName());
                    foreach (Data.SelfIntroductionQuestion i in selfIntroduction.Questions)
                    {
                        sb.AppendLine("질문 : " + i.GetQuestion());
                        sb.AppendLine();
                        sb.AppendLine("답변 (글자수 : " + i.GetAnswer().Length + ") : ");
                        sb.AppendLine();
                        sb.AppendLine(i.GetAnswer());
                        sb.AppendLine();
                        sb.AppendLine("============================");
                    }

                    sw.Write(sb.ToString());
                }
            }
        }
    }
}
