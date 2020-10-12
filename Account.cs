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
        double annualIntRate; double monthRate;  public double servCharge;
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
            monthRate = (annualIntRate / 12);
            monthRate = (currentBal * monthRate);
            currentBal += monthRate;
        }

        public String CloseAndReport()
        {
            currentBal -= servCharge;
            CalculateInterest();
            depositNum = 0;
            withdrawNum = 0;
            StringBuilder str = new StringBuilder("Starting Balance: " + startBal);
            str.AppendFormat("\nCurrent Balance: {0, 0:C2}", currentBal);
            str.Append("\nPercent Change: " + ((startBal * 100) / currentBal));
            str.Append("\nInterest: " + monthRate);
            return str.ToString();
        }
    }
}
