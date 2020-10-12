using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountLab3
{
    class ChequingAccount : Account // Created ChequingAccount class - Justin. M
    {
        public ChequingAccount(double sb, double annIntRate, double serviceChr) : base(sb, annIntRate, serviceChr)
        {

        }

        public void MakeWithdrawal(double amount)
        {
            if(base.currentBal - amount < 0)
            {
                base.currentBal -= 15;
                Console.WriteLine("Withdrawal not made.");
            }
            else
            {
                base.MakeWithdrawal(amount);
            }
        }

        public void MakeDeposit(double amount)
        {
            base.MakeDeposit(amount);
        }

        public String CloseAndReport()
        {
            double withdrawFee = base.withdrawNum * 0.10;
            double serviceFee = 5;
            base.servCharge += serviceFee + withdrawFee;
            String str = base.CloseAndReport();
            return str;
        }
    }
}
