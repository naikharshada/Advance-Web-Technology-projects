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
    public partial class FrmMain : Form
    {
        //Declaration  of account object
        Account a1;
        frmAmount temp;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void lblAcName_Click(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            //diable open
            btnOpen.Enabled = false;
            //enable others
            btnDeposit.Enabled = true;
            btnWithdraw.Enabled = true;
            btnCheck.Enabled = true;
            //open the account - create account object
            a1 = new Account();
            a1.AcNo = int.Parse(txtAcNo.Text);
            a1.AcName = txtAcName.Text;
            a1.AcBalance = double.Parse(txtAcBalance.Text);
            txtMsg.Text = "Welcome to APNA BANK";
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            txtMsg.Text = txtMsg.Text + Environment.NewLine + "Ac No: " + a1.AcNo;
            txtMsg.Text = txtMsg.Text + Environment.NewLine + "Ac Name: " + a1.AcName;
            txtMsg.Text = txtMsg.Text + Environment.NewLine + "Ac Balance: " + a1.AcBalance;
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            temp = new frmAmount();
            temp.Text = "Deposit Amount";
            if(temp.ShowDialog() == DialogResult.OK)
            {
                //deposit money
                a1.Deposit(temp.Amount);
                txtMsg.Text += Environment.NewLine + "Deposited!";
            }
            else
            {
                txtMsg.Text += Environment.NewLine + "user has cancelled the transaction!";
            }

        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            temp = new frmAmount();
            temp.Text = "Withdraw Amount";
            if (temp.ShowDialog() == DialogResult.OK)
            {
                if (a1.Withdraw(temp.Amount))
                {
                    txtMsg.Text += Environment.NewLine + "Withdrawal Successful!";
                }
                else
                {
                    txtMsg.Text += Environment.NewLine + "Insufficient balance!";
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
