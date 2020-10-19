using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountLab3
{
    class SavingsAccount : Account // Created SavingsAccount class - Justin. M
    {
        public SavingsAccount(double sb, double annIntRate, double serviceChr) : base(sb, annIntRate, serviceChr)
        {
        }

        bool accStatus; 
        public void MakeWithdrawal(double amount)
        {
            if(base.currentBal - amount < 25 && base.currentBal - amount < 0)
            {
                Console.WriteLine("Withdrawal not made.");
                accStatus = false;
            }
            if (accStatus == false)
            {
                Console.WriteLine("Your account is not active.");
            }
            else
            {
                base.MakeWithdrawal(amount);
            }
        }

        public void MakeDeposit(double amount)
        {
                base.MakeDeposit(amount);
                if (base.currentBal + amount > 25)
                {
                    accStatus = true;
                }
        }

        public String CloseAndReport()
        {
            int charge = base.withdrawNum - 4;
            base.servCharge += charge;
            String str = base.CloseAndReport();
            if (accStatus == true)
            {
                str += "\nAccount Status: Active";
            }
            else if(accStatus == false)
            {
                str += "\nAccount Status: Inactive";
            }
            return str;
        }
    }
}
