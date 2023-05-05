using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccountApplication
{
    public partial class frmAmount : Form
    {
        public double Amount
        {
            get
            {
                return double.Parse(txtAmount.Text);
            }
        }
        public frmAmount()
        {
            InitializeComponent();
        }
    }
}
