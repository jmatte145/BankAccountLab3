using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountLab3
{
    interface IAccount // Created IAccount interface - Justin.M
    {
        void MakeWithdrawal(double amount);
        void MakeDeposit(double amount);
        void CalculateInterest();
        String CloseAndReport();
    }
}
