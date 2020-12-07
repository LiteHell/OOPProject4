using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Data
{
    [Serializable]
    public class HigherEducation : Education
    {
        private string major;
        private string degreeName;
        private float gpa;
        private float majorGPA;
        private float maximumGPA;

        public string GetMajor()
        {
            return major;
        }

        public void SetMajor(string value)
        {
            major = value;
        }


        public string GetDegreeName()
        {
            return degreeName;
        }

        public void SetDegreeName(string value)
        {
            degreeName = value;
        }


        public float GetGPA()
        {
            return gpa;
        }

        public void SetGPA(float value)
        {
            gpa = value;
        }


        public float GetMajorGPA()
        {
            return majorGPA;
        }

        public void SetMajorGPA(float value)
        {
            majorGPA = value;
        }


        public float GetMaximumGPA()
        {
            return maximumGPA;
        }

        public void SetMaximumGPA(float value)
        {
            maximumGPA = value;
        }
    }
}
