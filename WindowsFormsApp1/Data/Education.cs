using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Data
{
    public enum SchoolType
    {
        HighSchool,
        University,
        GraduateSchool
    }
    public enum SchoolRegistrationType
    {
        Enrolled,
        LeaveOfAbsence,
        Graduated,
        Completed,
        Expelled
    }
    [Serializable]
    public class Education
    {
        public Education()
        {
            EnrolledAt = DateTime.Now;
            GraduatedAt = DateTime.Now;
            SchoolYear = 1;
        }
        private int schoolYear;
        public SchoolType SchoolType { get; set; }
        public SchoolRegistrationType Status { get; set; }
        public string SchoolName { get; set; }
        public DateTime EnrolledAt { get; set; }
        public DateTime GraduatedAt { get; set; }
        public int SchoolYear
        {
            get => schoolYear;
            set
            {
                if (value > 0)
                    schoolYear = value;
                else
                    throw new ArgumentOutOfRangeException();
            } 
        }
    }
}
