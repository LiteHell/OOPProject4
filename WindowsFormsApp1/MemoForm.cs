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
    public partial class MemoForm : Form
    {
        MemoManager manager;
        public MemoForm()
        {
            InitializeComponent();
            manager = new MemoManager();
            txt_memo.Text = manager.GetMemo();
            txt_memo.TextChanged += SaveMemoWhenTextChanged;
        }

        private void SaveMemoWhenTextChanged(object sender, EventArgs e)
        {
            manager.SetMemo(txt_memo.Text);
        }
    }
}
