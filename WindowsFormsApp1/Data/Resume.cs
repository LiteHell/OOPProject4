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
        public Resume()
        {
            Educations = new List<Education>();
            Careers = new List<Career>();
            Certificates = new List<Qualification>();
            image = new byte[] { };
            Birthday = DateTime.Now;
        }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string PhoneNumber { get; set; }
        
        public Image Picture
        {
            get
            {
                if (image == null || image.Length == 0)
                    return null;
                else
                    using (MemoryStream ms = new MemoryStream(image))
                        return Image.FromStream(ms);
            }
            set
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    value.Save(ms, ImageFormat.Png);
                    image = ms.ToArray();
                }
            }
        }
        public DateTime Birthday { get; set; }
        public List<Education> Educations { get; set; }
        public List<Career> Careers { get; set; }
        public List<Qualification> Certificates { get; set; }
    }
}
