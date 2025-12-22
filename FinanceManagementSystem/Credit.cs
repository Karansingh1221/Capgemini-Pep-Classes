using System;
using Bank;
namespace CreditAccount{
class Credit{
    
    public void NetSalary(){
        Console.WriteLine("Enter Your Gross Salary: ");
        int sal=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Net salary credited: ₹{sal-(10*sal/100)}");
    }
    public void FixedDepositInterest(){
        Console.WriteLine("Enter Principal Amount:");
        int p=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Rate of Interest:");
        int r=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Time Period ");
        int t=Convert.ToInt32(Console.ReadLine());
        int si=p*r*(t/12)/100;
        Console.WriteLine($"Fixed Deposit maturity amount: ₹{p+si}");
    }

    public void RewardPoints(){
        Console.WriteLine("Enter Total Spending:");
        int spen=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Reward points earned: {spen/100}");
    }

    public void BonusEligibility(){
        Console.WriteLine("Enter Annual Salary:");
        int sal=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Years of Service:");
        int y=Convert.ToInt32(Console.ReadLine());
        if(sal>=500000 && y>=3){
            Console.WriteLine("Employee is eligible for bonus.");
        }else{
            Console.WriteLine("Employee is not eligible for bonus.");
        }
    }
}
}