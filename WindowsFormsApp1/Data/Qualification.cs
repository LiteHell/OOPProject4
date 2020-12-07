using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Data
{
    [Serializable]
    public class Qualification
    {
        public Qualification()
        {
            AcquisitiedAt = DateTime.Now;
            ValidUntil = DateTime.Now;

        }
        public string Name { get; set; }
        public string AwardingInstitution { get; set; }
        public DateTime AcquisitiedAt { get; set; }
        public DateTime ValidUntil { get; set; }
        public bool ValidForever { get; set; }
    }
}
