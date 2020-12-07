using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Data
{
    [Serializable]
    public class Career
    {
        public Career()
        {
            WorkedSince = DateTime.Now;
            WorkedUntil = DateTime.Now;
        }
        public string CompanyName { get; set; }
        public string Position { get; set; }
        public string Responsibilities { get; set; }
        public DateTime WorkedSince { get; set; }
        public DateTime WorkedUntil { get; set; }
    }
}
