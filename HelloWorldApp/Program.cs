using System;
using EmployeeSpace;
using Calculator;
using Area;
class HelloWorld{
    public static int trans=1;
    public static int curr_bal=0;
    static void Main(string[] args){
        // Console.WriteLine("Hello World");
        // Console.ReadLine();
        // Employee emp=new Employee();
        // emp.AcceptDetails();
        // emp.DisplayDetails();
        // Operations m=new Operations();
        // m.Add();
        // m.Sub();
        // m.Mult();
        // m.Div();
        // Console.WriteLine("Hello, World");
        // Console.WriteLine("Enter the number: ");
        // int a=Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine($"Number: {a}");
        // Console.WriteLine("Enter the float: ");
        // float b=Convert.ToSingle(Console.ReadLine());
        // Console.WriteLine($"Float NUmber: {b}");
        // Console.WriteLine("Enter the String: ");
        // string c=Console.ReadLine();
        // Console.WriteLine("String "+c);
        // Circle cir=new Circle(7);
        // cir.display();


//Even Odd
        // Console.WriteLine("Enter the Number: ");
        // int x=Convert.ToInt32(Console.ReadLine());
        // if(x%2==0){
        //     Console.WriteLine($"{x} is Even");
        // }else{
        //     Console.WriteLine($"{x} is Odd");
        // }

        //Greatest;
        // Console.WriteLine("Enter number 1:");
        // int a=Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Enter number 2:");
        // int b=Convert.ToInt32(Console.ReadLine());
        // if(a>b){
        //     Console.WriteLine($"{a} is greater than {b}");
        // }else{
        //     Console.WriteLine($"{b} is greater than {b}");
        // }


        //Positive,negative, zero
        // Console.WriteLine("Enter the number: ");
        // int x=Convert.ToInt32(Console.ReadLine());
        // if(x>0){
        //     Console.WriteLine($"{x} is positive");
        // }else if(x<0){
        //     Console.WriteLine($"{x} is negative");
        // }else{
        //     Console.WriteLine($"{x} is zero");
        // }


        //greatest of the three numbers

        // Console.WriteLine("Enter the number 1: ");
        // int a=Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Enter the number 2: ");
        // int b=Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("Enter the number 3: ");
        // int c=Convert.ToInt32(Console.ReadLine());
        // if(a>b && a>c){
        //     Console.WriteLine($"{a} is the greatest");
        // }else if(b>c){
        //     Console.WriteLine($"{b} is the greatest");
        // }else{
        //     Console.WriteLine($"{c} is the greatest");
        // }
        // if(a>b){
        //     if(a>c){
        //         Console.WriteLine($"{a} is the greatest");
        //     }else{
        //         Console.WriteLine($"{c} is the greatest");
        //     }
        // }else{
        //     Console.WriteLine($"{b} is the greatest");
        // }



        // Console.WriteLine("Enter the Character: ");
        // char c=Convert.ToChar(Console.ReadLine());
        // switch(c){
        //     case 'a':
        //         Console.WriteLine($"The Character '{c}' is a vowel");
        //         break;
        //     case 'e':
        //         Console.WriteLine($"The Character '{c}' is a vowel");
        //         break;
        //     case 'i':
        //         Console.WriteLine($"The Character '{c}' is a vowel");
        //         break;
        //     case 'o':
        //         Console.WriteLine($"The Character '{c}' is a vowel");
        //         break;
        //     case 'u':
        //         Console.WriteLine($"The Character '{c}' is a vowel");
        //         break;
        //     case 'A':
        //         Console.WriteLine($"The Character '{c}' is a vowel");
        //         break;
        //     case 'E':
        //         Console.WriteLine($"The Character '{c}' is a vowel");
        //         break;
        //     case 'I':
        //         Console.WriteLine($"The Character '{c}' is a vowel");
        //         break;
        //     case 'O':
        //         Console.WriteLine($"The Character '{c}' is a vowel");
        //         break;
        //     case 'U':
        //         Console.WriteLine($"The Character '{c}' is a vowel");
        //         break;
        //     default:
        //         Console.WriteLine($"The Character '{c}' is not a vowel");
        //         break;
        // }



        // Console.WriteLine("Enter the String:");
        // string s=Console.ReadLine();
        // string us=s.ToUpper();
        // Console.WriteLine($"Original string length: {s.WriteLinength}");
        // Console.WriteLine("Uppercase string: "+us);


        // int a=Convert.ToInt32(Console.ReadLine());
        // int b=Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine($"Before Swap: a = {a},b = {b}");
        // Console.WriteLine($"After Swap: a = {a+b-a},b = {a+b-b}");


        // int count=1;
        // while(count<6){
        //     Console.WriteLine(count);
        //     count++;
        // }
        // count--;
        // Console.WriteLine();
        // while(count>0){
        //     Console.WriteLine(count);
        //     count--;
        // }

        // int count=0;
        // do{
        //     Console.WriteLine(count);
        //     count++;
        // }
        // while(count<=6);

        // int n=Convert.ToInt32(Console.ReadLine());
        // for(int n=20;n<=30;n++){
        //     Console.WriteLine($"Table of {n}");
        //     for(int i=1;i<=10;i++){
        //         Console.WriteLine($"{n} X {i} = {n*i}");
        //     }
        // }

        // Console.WriteLine("Game Begins");
        // for(int i=1;i<=10;i++){
        //     if(i==4){
        //         Console.WriteLine($"Enemy {i} is invisible skipping enemy {i}");
        //         continue;
        //     }
        //     Console.WriteLine($"Player killed enemy {i}");
        // }
        // Console.WriteLine("Game Ends");

        int option=0;
        // int trans=1;
        do{
            Console.WriteLine("1. Check Loan Eligibility");
            Console.WriteLine("2. Calculate Tax");
            Console.WriteLine("3. Enter Transaction");
            Console.WriteLine("4. Deposit Money");
            Console.WriteLine("5. Withdraw Money");
            Console.WriteLine("6. Current Balance");
            Console.WriteLine("7. Exit");
            Console.WriteLine("Enter the option: ");
            option=Convert.ToInt32(Console.ReadLine());
            switch(option){
                case 1:
                    LoanEligibility();
                    break;
                case 2:
                    TaxCalculation();
                    break;
                case 3:
                    Transaction();
                    break;
                case 4:
                    Deposit();
                    break;
                case 5:
                    Withdraw();
                    break;
                case 6:
                    Console.WriteLine($"Current Balance: {curr_bal}");
                    break;
                case 7:
                    Console.WriteLine("Exiting Program");
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
        }
        while(option!=7);
    }
    public static void  LoanEligibility(){
        Console.WriteLine("Enter your age:");
        int age=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter your monthly income:");
        int income=Convert.ToInt32(Console.ReadLine());
        if(age>=21 && income>=30000){
            Console.WriteLine("You are Eligible for Loan");
        }else{
            Console.WriteLine("You are not Eligible for loan");
        }
    }
    public static void TaxCalculation(){
        Console.WriteLine("Enter your annual income:");
        int income=Convert.ToInt32(Console.ReadLine());
        int tax=0;
        if(income<=250000){
        }else if(income>=250001 && income <=500000){
            tax=5*income/100;
        }else if(income>=500001 && income <=1000000){
            tax=20*income/100;
        }else{
            tax=30*income/100;
        }
        Console.WriteLine($"tax on {income} is {tax}");
    }

    public static void Transaction(){
        if(trans>5){
            Console.WriteLine("You have reached your daily transacrtion limit of 5");
            return;
        }
        Console.WriteLine("Enter amount:");
        int amount=Convert.ToInt32(Console.ReadLine());
        if(amount<0){
            Console.WriteLine("Invalid Amount Entered");
        }else if(amount>0){
            Console.WriteLine("Valid Transaction");
            trans++;
        }
    }

    public static void Deposit(){
        Console.WriteLine("Enter the amount: ");
        int dep=Convert.ToInt32(Console.ReadLine());
        curr_bal+=dep;
    }
    public static void Withdraw(){
        Console.WriteLine("Enter the amount: ");
        int amt=Convert.ToInt32(Console.ReadLine());
        if(amt>curr_bal){
            Console.WriteLine("Insufficient Bank Balance");
        }else{
            Console.WriteLine("Money Credited Successful");
            curr_bal-=amt;
        }
    }
}
