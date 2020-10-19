using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountLab3
{
    class GlobalSavingsAccount : SavingsAccount // Created GlobalSavingsAccount - Justin. A
    {
        public GlobalSavingsAccount(double sb, double annIntRate, double serviceChr) : base(sb, annIntRate, serviceChr)
        {

        }

        public void MakeWithdrawal(double amount)
        {
            base.MakeWithdrawal(amount);
        }

        public void MakeDeposit(double amount)
        {
            base.MakeDeposit(amount);
        }

        public double USValue()
        {
            double usValue = (1 / 1.33) * base.currentBal;
            return usValue;
        }

        public string CloseAndReport()
        {
            String str = base.CloseAndReport();
            return str;
        }
    }
}
