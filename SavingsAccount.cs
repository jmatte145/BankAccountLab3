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
            if(accStatus == false)
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
                if (base.currentBal > 25)
                {
                    accStatus = true;
                }
        }

        public String CloseAndReport()
        {
            int charge = base.withdrawNum - 4;
            base.servCharge += charge;
            String str = base.CloseAndReport();
            return str;
        }
    }
}
