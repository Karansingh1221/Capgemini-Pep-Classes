using System;
using Bank;
namespace DebitAccount{
class Debit{
    public static int withdraw_amount=0;
    public void Withdraw_Limit(){
        Console.WriteLine("Enter the Amount: ");
        int amt=Convert.ToInt32(Console.ReadLine());
        withdraw_amount+=amt;
        if(withdraw_amount<=40000 && withdraw_amount<=Account.balance){
            Console.WriteLine("Withdrawl Permitted in daily limit");
            Account.balance-=amt;
        }else{
            Console.WriteLine("Daily ATM withdrawal limit exceeded.");
        }
    }

    public void Emi_Burden(){
        Console.WriteLine("Enter Your Monthly Income: ");
        int mi=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter EMI Amount:");
        int emi=Convert.ToInt32(Console.ReadLine());
        int man=40*mi/100;
        if(emi<=man){
            Console.WriteLine("EMI is financially manageable.");
        }else{
            Console.WriteLine("EMI exceeds safe income limit.");
        }
    }

    public void Transaction(){
        Console.WriteLine("Enter Number of transaction: ");
        int tran=Convert.ToInt32(Console.ReadLine());
        int amt=0;
        for(int i=0;i<tran;i++){
            int a=Convert.ToInt32(Console.ReadLine());
            if(a<0){
                Console.WriteLine("Invaid Transaction Amount Check Again");
                i--;
                continue;
            }
            amt+=a;
        }
        Console.WriteLine($"Total debit amount for the day: ₹{amt}");
    }

    public void Minimum_Balance(){
        Console.WriteLine("Enter Current Balance:");
        int bal=Convert.ToInt32(Console.ReadLine());
        if(bal<2000){
            Console.WriteLine("Minimum balance not maintained. Penalty applicable.");
        }else{
            Console.WriteLine("Minimum balance requirement satisfied.");
        }
    }
}
}