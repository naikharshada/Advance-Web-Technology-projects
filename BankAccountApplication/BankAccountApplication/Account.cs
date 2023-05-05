using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountApplication
{
    class Account
    {
        //instance variable
        int acNo;
        string acName;
        double acBalance;

        //define read write properties to expose all attributes
        public int AcNo
        {
            get
            {
                return acNo;
            }
            set
            {
                acNo = value;
            }
        }
        public string AcName
        {
            get
            {
                return acName;
            }
            set
            {
                acName = value;
            }
        }
        public double AcBalance
        {
            get
            {
                return acBalance;
            }
            set
            {
                acBalance = value;
            }
        }
        //Add utility methods
        public void Deposit(double amt)
        {
            acBalance = acBalance + amt;
        }
        public bool Withdraw(double amt)
        {
            if(acBalance - amt >= 0)
            {
                acBalance -= amt;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
