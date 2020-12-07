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
        private int schoolYear;
        private SchoolType schoolType;
        private SchoolRegistrationType status;
        private string schoolName;
        private DateTime graduatedAt;
        private DateTime enrolledAt;
        
        public Education()
        {
            SetEnrolledAt(DateTime.Now);
            SetGraduatedAt(DateTime.Now);
            SetSchoolYear(1);
        }

        public SchoolType GetSchoolType()
        {
            return schoolType;
        }

        public void SetSchoolType(SchoolType value)
        {
            schoolType = value;
        }


        public SchoolRegistrationType GetStatus()
        {
            return status;
        }

        public void SetStatus(SchoolRegistrationType value)
        {
            status = value;
        }


        public string GetSchoolName()
        {
            return schoolName;
        }

        public void SetSchoolName(string value)
        {
            schoolName = value;
        }


        public DateTime GetEnrolledAt()
        {
            return enrolledAt;
        }

        public void SetEnrolledAt(DateTime value)
        {
            enrolledAt = value;
        }


        public DateTime GetGraduatedAt()
        {
            return graduatedAt;
        }

        public void SetGraduatedAt(DateTime value)
        {
            graduatedAt = value;
        }

        public int GetSchoolYear()
        {
            return schoolYear;
        }

        public void SetSchoolYear(int value)
        {
            if (value > 0)
                schoolYear = value;
            else
                throw new ArgumentOutOfRangeException();
        }
    }
}
