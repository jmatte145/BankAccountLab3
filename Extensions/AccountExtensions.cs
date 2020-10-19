using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountLab3.Extensions
{
    static class AccountExtensions // Created AccountExtensions class - Justin. A
    {
        public static double getPercentageChange(this Account a)
        {
            double percent = (a.startBal * 100) / a.currentBal;
            return percent;
        }

        public static string ToNAMoneyFormat(this double val, Boolean roundUP)
        {
            String money;
            if(roundUP == true)
            {
                val = Math.Round(val); // 12.4 $12.40
            }
            money = String.Format("{0:C2}", val);
            
            return money;
        }
    }
}
