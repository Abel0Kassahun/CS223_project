using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBlue.Model_Classes
{
    public class Offering
    {
        public string ID { get; set; }
        public Image Image { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Restaurant Restaurant { get; set; }
        public string ServiceOptions { get; set; }
        public int EWT { get; set; } // EWT - Estimated Waiting Time (dine-in & takeaway)
        public int ETA { get; set; } // ETA - Estimated Time of Arrival (delivery)
        public string MealOfTheDay { get; set; }
        public string CourseOfMeal { get; set; }
        public string Cuisine { get; set; }

    }
}
