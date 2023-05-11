using System;
using System.Windows.Forms;

namespace AnimalInheritance
{
    public partial class Form1 : Form
    {
        Animal[] animals = new Animal[3];
        public Form1()
        {
            animals[0] = new Cat();
            animals[1] = new Dog();
            animals[2] = new Cow();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ind = cmbAnimal.SelectedIndex;
            animals[ind].Play();
            picAnimal.Image = animals[ind].GetImage();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Animal a in animals)
            {
                cmbAnimal.Items.Add(a.GetName());
            }
        }
    }
}
