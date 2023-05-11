using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Drawing;

namespace AnimalInheritance
{
    class Cow : Animal
    {
        public override string GetName()
        {
            return "Cow";
        }
        public override void Play()
        {
            SoundPlayer p1 = new SoundPlayer(@"C:\Users\mcamock\source\repos\AnimalInheritance\AnimalInheritance\Sounds\cow3.wav");
            p1.PlayLooping();
        }
        public override Image GetImage()
        {
            return Image.FromFile(@"C:\Users\mcamock\source\repos\AnimalInheritance\AnimalInheritance\Images\cow.jpg");
        }
    }
}
