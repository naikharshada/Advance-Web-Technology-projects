using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArithmeticCalculator
{
    public partial class Form1 : Form
    {
        //Declare Instance Variable
        double varNum1, varNum2, varRes;

        private void btnAdd_Click(object sender, EventArgs e)
        {
           /* varNum1 = double.Parse(txtNum1.Text);
            varNum2 = double.Parse(txtNum2.Text);
            varRes = varNum1 + varNum2;
            txtResult.Text = varRes.ToString();*/

            if(!double.TryParse(txtNum1.Text,out varNum1))
            {
                MessageBox.Show("Enter a valid Number !");
                txtNum1.Clear();
                txtNum1.Focus();
                return;
            }
            if(!double.TryParse(txtNum2.Text,out varNum2))
            {
                MessageBox.Show("Enter a valid Number !");
                txtNum2.Clear();
                txtNum2.Focus();
                return;
            }
            
            Button temp = (Button)sender;
            String operation = temp.Text; //Add, sub, mul, div
            
            switch(operation)
            {
                case "Add":
                    varRes = varNum1 + varNum2;
                    break;
                case "Sub":
                    varRes = varNum1 - varNum2;
                    break;
                case "Mul":
                    varRes = varNum1 * varNum2;
                    break;
                case "Div":
                    varRes = varNum1 / varNum2;
                    break;
            }

           
            txtResult.Text = varRes.ToString();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void LblNum1_Click(object sender, EventArgs e)
        {

        }
    }
}
