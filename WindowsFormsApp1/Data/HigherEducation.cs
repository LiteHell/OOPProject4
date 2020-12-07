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
        public string Major { get; set; }
        public string DegreeName { get; set; }
        public float GPA { get; set; }
        public float MajorGPA { get; set; }
        public float MaximumGPA { get; set; }
    }
}
