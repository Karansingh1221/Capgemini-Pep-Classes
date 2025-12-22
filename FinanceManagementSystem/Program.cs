using System;
using DebitAccount;
using CreditAccount;
class Program{
    public static void Main(string[] args){
        int option=0;
        do{
            Console.WriteLine("1. Credit");
            Console.WriteLine("2. Debit");
            Console.WriteLine("3. Exit");
            option=Convert.ToInt32(Console.ReadLine());
            switch(option){
                case 1:
                    CreditClass();
                    break;
                case 2:
                    DebitClass();
                    break;
                case 3:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;

            }
        }while(option!=3);
    }

    public static void CreditClass(){
        int option=0;
        do{
            Console.WriteLine("1. Net Salary Credit Calculation");
            Console.WriteLine("2. Fixed Deposit Maturity Calculation");
            Console.WriteLine("3. Credit Card Reward Points Evaluation");
            Console.WriteLine("4. Employee Bonus Eligibility Check");
            Console.WriteLine("5. Exit");
            option=Convert .ToInt32(Console.ReadLine());
            Credit cre=new Credit();
            switch(option){
                case 1:
                    cre.NetSalary();
                    break;
                case 2:
                    cre.FixedDepositInterest();
                    break;
                case 3:
                    cre.RewardPoints();
                    break;
                case 4:
                    cre.BonusEligibility();
                    break;
                case 5:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;

            }
        }while(option!=5);

    }

    public static void DebitClass(){
        int option=0;
        do{
            Console.WriteLine("1. ATM Withdrawal Limit Validation");
            Console.WriteLine("2. EMI Burden Evaluation");
            Console.WriteLine("3. Transaction-Based Daily Spending Calculator");
            Console.WriteLine("4. Minimum Balance Compliance Check");
            Console.WriteLine("5. Exit");
            option=Convert.ToInt32(Console.ReadLine());
            Debit deb=new Debit();
            switch(option){
                case 1:
                    deb.Withdraw_Limit();
                    break;
                case 2:
                    deb.Emi_Burden();
                    break;
                case 3:
                    deb.Transaction();
                    break;
                case 4:
                    deb.Minimum_Balance();
                    break;
                case 5:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
        }while(option!=5);
    }
}