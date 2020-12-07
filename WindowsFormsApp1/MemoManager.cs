using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp1
{
    class MemoManager
    {
        private const string filename = "memo.txt";
        public string GetMemo()
        {
            if (!File.Exists(filename))
                return "";
            using (FileStream fstr = File.OpenRead(filename))
            using (StreamReader sre = new StreamReader(fstr, Encoding.UTF8))
            {
                return sre.ReadToEnd();
            }
        }
        public void SetMemo(string memo)
        {
            using (FileStream fstr = File.OpenWrite(filename))
            using (StreamWriter sw = new StreamWriter(fstr, Encoding.UTF8))
            {
                sw.Write(memo);
                sw.Flush();
            }
        }
    }
}
