using System;
namespace Area{
    class Circle{
        public int radious;
        public Circle(int a){
            this.radious=a;
        }
        public void display(){
            float area=(float)3.14*radious*radious;
            Console.WriteLine($"Area of the Circle is: {area}");
        }
    }
}