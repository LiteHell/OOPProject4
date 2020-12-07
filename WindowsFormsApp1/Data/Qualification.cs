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
        private string name;
        private string awardingInstitution;
        private DateTime acquisitiedAt;
        private DateTime validUntil;
        private bool validForever;
        public Qualification()
        {
            SetAcquisitiedAt(DateTime.Now);
            SetValidUntil(DateTime.Now);

        }


        public string GetName()
        {
            return name;
        }

        public void SetName(string value)
        {
            name = value;
        }


        public string GetAwardingInstitution()
        {
            return awardingInstitution;
        }

        public void SetAwardingInstitution(string value)
        {
            awardingInstitution = value;
        }


        public DateTime GetAcquisitiedAt()
        {
            return acquisitiedAt;
        }

        public void SetAcquisitiedAt(DateTime value)
        {
            acquisitiedAt = value;
        }


        public DateTime GetValidUntil()
        {
            return validUntil;
        }

        public void SetValidUntil(DateTime value)
        {
            validUntil = value;
        }

        public bool GetValidForever()
        {
            return validForever;
        }

        public void SetValidForever(bool value)
        {
            validForever = value;
        }
    }
}
