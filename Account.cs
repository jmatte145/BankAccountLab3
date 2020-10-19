using BankAccountLab3.Extensions;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountLab3
{
    abstract class Account : IAccount // Created Account Class - Justin. M
    {
        public double startBal { get; set; }
        public double currentBal { get; set; }
        double depositTotal; public int depositNum { get; set; } 
        double withdrawTotal; public int withdrawNum { get; set; } 
        double annualIntRate; public double monthRate;  public double interest; public double servCharge;
        public Account(double sb, double annIntRate, double serviceChr)
        {
            startBal = sb;
            currentBal = startBal;
            annualIntRate = annIntRate;
            servCharge = serviceChr;
        }
        public void MakeWithdrawal(double amount)
        {
            currentBal -= amount;
            withdrawNum++;
        }

        public void MakeDeposit(double amount)
        {
            currentBal += amount;
            depositNum++;
        }

        public void CalculateInterest()
        {
            interest = (annualIntRate / 12);
            monthRate = (currentBal * interest);
            currentBal += monthRate;
        }

        public String CloseAndReport()
        {
            currentBal -= servCharge;
            CalculateInterest();
            StringBuilder str = new StringBuilder("Starting Balance: " + startBal.ToNAMoneyFormat(true));
            str.Append("\nNumber of deposits: " + depositNum);
            str.Append("\nNumber of withdrawals: " + withdrawNum);
            str.Append("\nPercent Change: " + this.getPercentageChange());
            str.Append("\nInterest: " + monthRate);
            str.Append("\nService Charge: " + servCharge);
            str.Append("\nCurrent Balance: " + currentBal.ToNAMoneyFormat(true));
            // str.AppendFormat("\nCurrent Balance: {0, 0:C2}", currentBal);
            // str.AppendFormat("\nCurrent Balance (Rounded): {0, 0:C2}", currentBal.ToNAMoneyFormat(true));
            depositNum = 0;
            withdrawNum = 0;
            return str.ToString();
        }
    }
}
