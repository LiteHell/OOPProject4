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
        private string companyName;
        private DateTime workedUntil;
        private string position;
        private string responsibilities;
        private DateTime workedSince;

        public Career()
        {
            SetWorkedSince(DateTime.Now);
            SetWorkedUntil(DateTime.Now);
        }

        public string GetCompanyName()
        {
            return companyName;
        }

        public void SetCompanyName(string value)
        {
            companyName = value;
        }


        public string GetPosition()
        {
            return position;
        }

        public void SetPosition(string value)
        {
            position = value;
        }


        public string GetResponsibilities()
        {
            return responsibilities;
        }

        public void SetResponsibilities(string value)
        {
            responsibilities = value;
        }


        public DateTime GetWorkedSince()
        {
            return workedSince;
        }

        public void SetWorkedSince(DateTime value)
        {
            workedSince = value;
        }


        public DateTime GetWorkedUntil()
        {
            return workedUntil;
        }

        public void SetWorkedUntil(DateTime value)
        {
            workedUntil = value;
        }
    }
}
