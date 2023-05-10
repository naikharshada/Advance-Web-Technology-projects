using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ZomatoApp
{
    class BarbaqueNation : Restaurant
    {
        public string GetName()
        {
            return "Barbaque Nation";
        }
        public double GetRating()
        {
            return 4.5;
        }
        public string GetCategory()
        {
            return "Fine Dining | Multicuisine";
        }
        public string GetAddress()
        {
            return "Borivali West";
        }
        public Image GetImage()
        {
            return Image.FromFile(@"C:\Harshada\AWT labs\ZomatoApp\ZomatoApp\images\img3.jpg");
        }
    }
}
