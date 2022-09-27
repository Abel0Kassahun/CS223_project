using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectBlue.Model_Classes;

namespace ProjectBlue
{
    public partial class OfferingDetailsCardSmall : UserControl
    {
        private string _mealOfTheDay;

        public string MealOfTheDay
        {
            get { return _mealOfTheDay; }
            set { _mealOfTheDay = value; lblMealOfTheDay.Text = value; }
        }

        private string _courseOfMeal;

        public string CourseOfMeal
        {
            get { return _courseOfMeal; }
            set { _courseOfMeal = value; lblCourseOfMeal.Text = value; }
        }

        private string _cuisine;

        public string Cuisine
        {
            get { return _cuisine; }
            set { _cuisine = value; lblCuisine.Text = value; }
        }

        public OfferingDetailsCardSmall()
        {
            InitializeComponent();
        }

        public OfferingDetailsCardSmall(Offering offering1)
        {
            InitializeComponent();

            MealOfTheDay = offering1.MealOfTheDay;
            CourseOfMeal = offering1.CourseOfMeal;
            Cuisine = offering1.Cuisine;
        }
    }
}
