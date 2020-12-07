using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApp1
{
    public class ResumeManager
    {
        private static int CompareEducation(Data.Education a, Data.Education b)
        {
            if (a.GraduatedAt > b.GraduatedAt)
                return 1;
            else if (a.GraduatedAt < b.GraduatedAt)
                return -1;
            else if (a.EnrolledAt > b.EnrolledAt)
                return 1;
            else if (a.EnrolledAt < b.EnrolledAt)
                return -1;
            else
                return a.SchoolName.CompareTo(b.SchoolName);
        }
        public Data.Resume GetResume()
        {
            if (!File.Exists("resume.dat"))
                return new Data.Resume();

            using (FileStream fs = File.OpenRead("resume.dat"))
            {
                if (fs.Length == 0)
                    return new Data.Resume();
                BinaryFormatter formatter = new BinaryFormatter();
                return (Data.Resume)formatter.Deserialize(fs);
            }
        }
        public void SetResume(Data.Resume resume)
        {
            resume.Educations.Sort(CompareEducation);
            using (FileStream fs = File.OpenWrite("resume.dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, resume);
            }
        }
    }
}
