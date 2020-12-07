using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    struct SelfIntroductionHandle
    {
        public string Name;
        public string Filename;
    }
    public class SelfIntroductionManager
    {
        private DirectoryInfo directoryInfo;
        public SelfIntroductionManager()
        {
            const string directoryName = "SelfIntroductions";
            if(!Directory.Exists(directoryName))
            {
                directoryInfo = Directory.CreateDirectory(directoryName);
            } else
            {
                directoryInfo = new DirectoryInfo(directoryName);
            }
        }
        public string[] GetSelfIntroductionNames()
        {
            List<string> result = new List<string>();
            foreach(FileInfo fileInfo in directoryInfo.EnumerateFiles())
            {
                result.Add(Path.GetFileNameWithoutExtension(fileInfo.Name));
            }
            return result.ToArray();
        }
        public Data.SelfIntroduction GetSelfIntroduction(string name)
        {
            string filename = Path.Combine(directoryInfo.FullName, name + ".dat");
            if (!File.Exists(filename))
                return null;
            using (FileStream fs = File.OpenRead(filename))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                return (Data.SelfIntroduction)formatter.Deserialize(fs);
            }
        }
        public void SaveSelfIntroduction(string name, Data.SelfIntroduction data)
        {
            string filename = Path.Combine(directoryInfo.FullName, name + ".dat");
            if (data == null)
            {
                data = new Data.SelfIntroduction();
                data.Questions.Add(new Data.SelfIntroductionQuestion());
            }

            using (FileStream fs = File.OpenWrite(filename))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, data);
            }
        }

        public void DeleteSelfIntroduction(string name)
        {
            string filename = Path.Combine(directoryInfo.FullName, name + ".dat");
            if (File.Exists(filename))
                File.Delete(filename);
        }
    }
}
