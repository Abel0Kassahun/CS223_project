using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBlue.Model_Classes
{
    public class Restaurant
    {
        public string ID { get; set; }
        public Image Image { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string ServiceOptions { get; set; }
        public string WorkingHours { get; set; }
        public Offering[] Offerings { get; set; }
    }
}
