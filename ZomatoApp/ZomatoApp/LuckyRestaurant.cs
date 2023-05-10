using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ZomatoApp
{
    //implements the Restaurant interface
    class LuckyRestaurant : Restaurant
    {
        public string GetName()
        {
            return "Lucky Restaurant";
        }
        public double GetRating()
        {
            return 3.8;
        }
        public string GetCategory()
        {
            return "Fine Dining | Multicuisine";
        }
        public string GetAddress()
        {
            return "Bandra West";
        }
        public Image GetImage()
        {
            return Image.FromFile(@"C:\Harshada\AWT labs\ZomatoApp\ZomatoApp\images\img1.jpg");
        }
    }
}
