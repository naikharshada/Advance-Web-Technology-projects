using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ZomatoApp
{
    class Domino_s : Restaurant
    {
        public string GetName()
        {
            return "Domino's";
        }
        public double GetRating()
        {
            return 4.0;
        }
        public string GetCategory()
        {
            return "Take Away";
        }
        public string GetAddress()
        {
            return "Andheri West";
        }
        public Image GetImage()
        {
            return Image.FromFile(@"C:\Harshada\AWT labs\ZomatoApp\ZomatoApp\images\img2.jpg");
        }
    }
}
