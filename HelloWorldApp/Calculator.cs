using System;
namespace Calculator{
    class Operations{
        int a;
        int b;

        
        public void Add(){
            Console.WriteLine("Addition: ");
            Console.WriteLine("Enter Number 1:");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2: ");
            b=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Add: {a+b}");
        }
        public void Sub(){
            Console.WriteLine("Subtraction: ");
            Console.WriteLine("Enter Number 1:");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2: ");
            b=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Subtraction: {a-b}");
        }
        public void Mult(){
            Console.WriteLine("Multiplication: ");
            Console.WriteLine("Enter Number 1:");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2: ");
            b=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Multiplication: {a*b}");
        }
        public void Div(){
            Console.WriteLine("Division: ");
            Console.WriteLine("Enter Number 1:");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2: ");
            b=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Division: {a/b}");
        }

    }
}