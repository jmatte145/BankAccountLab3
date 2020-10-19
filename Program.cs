using BankAccountLab3.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountLab3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Created Menus for each account - Justin. A
            GlobalSavingsAccount GSAcc = new GlobalSavingsAccount(5.00,0.12,3.99);
            SavingsAccount SAcc = new SavingsAccount(5.00, 0.12, 3.99);
            ChequingAccount ChAcc = new ChequingAccount(5.00, 0.12, 3.99);

            Console.WriteLine(Menus.BANKMENU);
            string input = Console.ReadLine();

            while (!(input.ToUpper()).Equals("Q"))
            {
                switch (input.ToUpper())
                {
                    case "A":
                        Console.WriteLine(Menus.SAVINGSMENU);
                        string input2 = Console.ReadLine();
                        while (input2.ToUpper() != "A" && input2.ToUpper() != "B" && input2.ToUpper() != "C" && input2.ToUpper() != "R")
                        {
                            Console.WriteLine("\nPlease enter a valid option." + "\n" + Menus.SAVINGSMENU);
                            input2 = Console.ReadLine();
                        }
                        while (!(input2.ToUpper()).Equals("R"))
                        {
                            if(input2.ToUpper() == "A")
                            {
                                Console.WriteLine("Please enter how much you'd like to deposit:");
                                double amount;
                                try // Added Custom Exceptions in place of input validation - Justin. A
                                {
                                    if (double.TryParse(Console.ReadLine(), out amount) == false || amount < 0)
                                    {
                                        throw new InvalidInputException();
                                    }
                                    else
                                    {
                                        SAcc.MakeDeposit(amount);
                                    }
                                }
                                catch(Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                }
                                amount = 0;
                                
                                
                           /**     while(double.TryParse(Console.ReadLine(), out amount) == false || amount < 0)
                                {
                                    Console.WriteLine("Please enter a valid amount");
                                    double.TryParse(Console.ReadLine(), out amount);
                                }
                                SAcc.MakeDeposit(amount); **/

                                Console.WriteLine(Menus.SAVINGSMENU);
                                input2 = Console.ReadLine();
                                while (input2.ToUpper() != "A" && input2.ToUpper() != "B" && input2.ToUpper() != "C" && input2.ToUpper() != "R")
                                {
                                    Console.WriteLine("\nPlease enter a valid option." + "\n" + Menus.SAVINGSMENU);
                                    input2 = Console.ReadLine();
                                }

                            }
                            if(input2.ToUpper() == "B")
                            {
                                Console.WriteLine("Please enter how much you'd like to withdraw:");
                                double amount;
                                try
                                {
                                    if (double.TryParse(Console.ReadLine(), out amount) == false || amount < 0)
                                    {
                                        throw new InvalidInputException();
                                    }
                                    else
                                    {
                                        SAcc.MakeWithdrawal(amount);
                                    }
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                }
                                amount = 0;

                                Console.WriteLine(Menus.SAVINGSMENU);
                                input2 = Console.ReadLine();
                                while (input2.ToUpper() != "A" && input2.ToUpper() != "B" && input2.ToUpper() != "C" && input2.ToUpper() != "R")
                                {
                                    Console.WriteLine("\nPlease enter a valid option." + "\n" + Menus.SAVINGSMENU);
                                    input2 = Console.ReadLine();
                                }
                            }
                            if (input2.ToUpper() == "C")
                            {

                                Console.WriteLine(SAcc.CloseAndReport());
                                SAcc.startBal = SAcc.currentBal;
                                SAcc.currentBal = 0;
                                SAcc.depositNum = 0;
                                SAcc.withdrawNum = 0;
                                SAcc.monthRate = 0;


                                Console.WriteLine(Menus.SAVINGSMENU);
                                input2 = Console.ReadLine();
                                while (input2.ToUpper() != "A" && input2.ToUpper() != "B" && input2.ToUpper() != "C" && input2.ToUpper() != "R")
                                {
                                    Console.WriteLine("\nPlease enter a valid option." + "\n" + Menus.SAVINGSMENU);
                                    input2 = Console.ReadLine();
                                }
                            }
                        }
                        break;
                    
                    case "B":
                        Console.WriteLine(Menus.CHECKINGMENU);
                        input2 = Console.ReadLine();
                        while (input2.ToUpper() != "A" && input2.ToUpper() != "B" && input2.ToUpper() != "C" && input2.ToUpper() != "R")
                        {
                            Console.WriteLine("\nPlease enter a valid option." + "\n" + Menus.CHECKINGMENU);
                            input2 = Console.ReadLine();
                        }
                        while (!(input2.ToUpper()).Equals("R"))
                        {
                            if (input2.ToUpper() == "A")
                            {
                                Console.WriteLine("Please enter how much you'd like to deposit:");
                                double amount;
                                try
                                {
                                    if (double.TryParse(Console.ReadLine(), out amount) == false || amount < 0)
                                    {
                                        throw new InvalidInputException();
                                    }
                                    else
                                    {
                                        ChAcc.MakeDeposit(amount);
                                    }
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                }
                                amount = 0;

                                Console.WriteLine(Menus.CHECKINGMENU);
                                input2 = Console.ReadLine();
                                while (input2.ToUpper() != "A" && input2.ToUpper() != "B" && input2.ToUpper() != "C" && input2.ToUpper() != "R")
                                {
                                    Console.WriteLine("\nPlease enter a valid option." + "\n" + Menus.CHECKINGMENU);
                                    input2 = Console.ReadLine();
                                }

                            }
                            if (input2.ToUpper() == "B")
                            {
                                Console.WriteLine("Please enter how much you'd like to withdraw:");
                                double amount;
                                try
                                {
                                    if (double.TryParse(Console.ReadLine(), out amount) == false || amount < 0)
                                    {
                                        throw new InvalidInputException();
                                    }
                                    else
                                    {
                                        ChAcc.MakeWithdrawal(amount);
                                    }
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                }
                                amount = 0;

                                Console.WriteLine(Menus.CHECKINGMENU);
                                input2 = Console.ReadLine();
                                while (input2.ToUpper() != "A" && input2.ToUpper() != "B" && input2.ToUpper() != "C" && input2.ToUpper() != "R")
                                {
                                    Console.WriteLine("\nPlease enter a valid option." + "\n" + Menus.CHECKINGMENU);
                                    input2 = Console.ReadLine();
                                }
                            }
                            if (input2.ToUpper() == "C")
                            {

                                Console.WriteLine(ChAcc.CloseAndReport());
                                ChAcc.startBal = ChAcc.currentBal;
                                ChAcc.currentBal = 0;
                                ChAcc.depositNum = 0;
                                ChAcc.withdrawNum = 0;
                                ChAcc.monthRate = 0;


                                Console.WriteLine(Menus.CHECKINGMENU);
                                input2 = Console.ReadLine();
                                while (input2.ToUpper() != "A" && input2.ToUpper() != "B" && input2.ToUpper() != "C" && input2.ToUpper() != "R")
                                {
                                    Console.WriteLine("\nPlease enter a valid option." + "\n" + Menus.CHECKINGMENU);
                                    input2 = Console.ReadLine();
                                }
                                
                            }
                        }
                        break;
                    case "C":
                        Console.WriteLine(Menus.GSAVINGSMENU);
                        input2 = Console.ReadLine();
                        while (input2.ToUpper() != "A" && input2.ToUpper() != "B" && input2.ToUpper() != "C" && input2.ToUpper() != "D" && input2.ToUpper() != "R")
                        {
                            Console.WriteLine("\nPlease enter a valid option." + "\n" + Menus.GSAVINGSMENU);
                            input2 = Console.ReadLine();
                        }
                        while (!(input2.ToUpper()).Equals("R"))
                        {
                            if (input2.ToUpper() == "A")
                            {
                                Console.WriteLine("Please enter how much you'd like to deposit:");
                                double amount;
                                try
                                {
                                    if (double.TryParse(Console.ReadLine(), out amount) == false || amount < 0)
                                    {
                                        throw new InvalidInputException();
                                    }
                                    else
                                    {
                                        GSAcc.MakeDeposit(amount);
                                    }
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                }
                                amount = 0;

                                Console.WriteLine(Menus.GSAVINGSMENU);
                                input2 = Console.ReadLine();
                                while (input2.ToUpper() != "A" && input2.ToUpper() != "B" && input2.ToUpper() != "C" && input2.ToUpper() != "D" && input2.ToUpper() != "R")
                                {
                                    Console.WriteLine("\nPlease enter a valid option." + "\n" + Menus.GSAVINGSMENU);
                                    input2 = Console.ReadLine();
                                }

                            }
                            if (input2.ToUpper() == "B")
                            {
                                Console.WriteLine("Please enter how much you'd like to withdraw:");
                                double amount;
                                try
                                {
                                    if (double.TryParse(Console.ReadLine(), out amount) == false || amount < 0)
                                    {
                                        throw new InvalidInputException();
                                    }
                                    else
                                    {
                                        GSAcc.MakeWithdrawal(amount);
                                    }
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                }
                                amount = 0;

                                Console.WriteLine(Menus.GSAVINGSMENU);
                                input2 = Console.ReadLine();
                                while (input2.ToUpper() != "A" && input2.ToUpper() != "B" && input2.ToUpper() != "C" && input2.ToUpper() != "D" && input2.ToUpper() != "R")
                                {
                                    Console.WriteLine("\nPlease enter a valid option." + "\n" + Menus.GSAVINGSMENU);
                                    input2 = Console.ReadLine();
                                }
                            }
                            if (input2.ToUpper() == "C")
                            {

                                Console.WriteLine(GSAcc.CloseAndReport());
                                GSAcc.startBal = GSAcc.currentBal;
                                GSAcc.currentBal = 0;
                                GSAcc.depositNum = 0;
                                GSAcc.withdrawNum = 0;
                                GSAcc.monthRate = 0;


                                Console.WriteLine(Menus.GSAVINGSMENU);
                                input2 = Console.ReadLine();
                                while (input2.ToUpper() != "A" && input2.ToUpper() != "B" && input2.ToUpper() != "C" && input2.ToUpper() != "D" && input2.ToUpper() != "R")
                                {
                                    Console.WriteLine("\nPlease enter a valid option." + "\n" + Menus.GSAVINGSMENU);
                                    input2 = Console.ReadLine();
                                }
                            }
                            if(input2.ToUpper() == "D")
                            {
                                String str = "\nBalance in US Dollars: " + GSAcc.USValue();
                                Console.WriteLine(str);

                                Console.WriteLine(Menus.GSAVINGSMENU);
                                input2 = Console.ReadLine();
                                while (input2.ToUpper() != "A" && input2.ToUpper() != "B" && input2.ToUpper() != "C" && input2.ToUpper() != "D" && input2.ToUpper() != "R")
                                {
                                    Console.WriteLine("\nPlease enter a valid option." + "\n" + Menus.GSAVINGSMENU);
                                    input2 = Console.ReadLine();
                                }
                            }
                        }
                        break;
                    default:
                        break;
                }

                Console.WriteLine(Menus.BANKMENU);
                input = Console.ReadLine();
            }
            
        }
    }
}
