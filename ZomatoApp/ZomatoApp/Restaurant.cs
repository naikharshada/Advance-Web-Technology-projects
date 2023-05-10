using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ZomatoApp
{
    interface Restaurant
    {
        string GetName();
        string GetCategory();
        double GetRating();
        string GetAddress();
        Image GetImage();

    }
}
