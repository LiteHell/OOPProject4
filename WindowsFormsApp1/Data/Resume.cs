using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

namespace WindowsFormsApp1.Data
{
    [Serializable]
    public class Resume
    {
        private byte[] image;
        private DateTime birthday;
        private List<Education> educations;
        private List<Career> careers;
        private List<Qualification> certificates;
        private string name;
        private string email;
        private string address;
        private string telephone;
        private string phoneNumber;
        public Resume()
        {
            SetEducations(new List<Education>());
            SetCareers(new List<Career>());
            SetCertificates(new List<Qualification>());
            image = new byte[] { };
            SetBirthday(DateTime.Now);
        }


        public string GetName()
        {
            return name;
        }

        public void SetName(string value)
        {
            name = value;
        }


        public string GetEmail()
        {
            return email;
        }

        public void SetEmail(string value)
        {
            email = value;
        }


        public string GetAddress()
        {
            return address;
        }

        public void SetAddress(string value)
        {
            address = value;
        }


        public string GetTelephone()
        {
            return telephone;
        }

        public void SetTelephone(string value)
        {
            telephone = value;
        }


        public string GetPhoneNumber()
        {
            return phoneNumber;
        }

        public void SetPhoneNumber(string value)
        {
            phoneNumber = value;
        }

        public Image GetPicture()
        {
            if (image == null || image.Length == 0)
                return null;
            else
                using (MemoryStream ms = new MemoryStream(image))
                    return Image.FromStream(ms);
        }

        public void SetPicture(Image value)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                value.Save(ms, ImageFormat.Png);
                image = ms.ToArray();
            }
        }


        public DateTime GetBirthday()
        {
            return birthday;
        }

        public void SetBirthday(DateTime value)
        {
            birthday = value;
        }


        public List<Education> GetEducations()
        {
            return educations;
        }

        public void SetEducations(List<Education> value)
        {
            educations = value;
        }


        public List<Career> GetCareers()
        {
            return careers;
        }

        public void SetCareers(List<Career> value)
        {
            careers = value;
        }


        public List<Qualification> GetCertificates()
        {
            return certificates;
        }

        public void SetCertificates(List<Qualification> value)
        {
            certificates = value;
        }
    }
}
