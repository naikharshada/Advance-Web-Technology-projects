using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace AnimalInheritance
{
    class Animal
    {
        public virtual string GetName()
        {
            return "Animal";
        }

        public virtual void Play()
        {
            
        }
        public virtual Image GetImage()
        {
            return null;
        }
    }
}
