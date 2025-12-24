using System;
namespace LibraryItemClass{
    namespace Item{
    interface IReservable{
        void reserve();
    }
    interface INotifiable{
        void accept(string message);
    }
    abstract class LibraryItem{
        public string title;
        public string author;
        public int item_id;
        public LibraryItem(string t,string a,int id){
            title=t;
            author=a;
            item_id=id;
        }
        public abstract void display();
        public abstract double Calculate_latefee(int day); 
    }
    class Book:LibraryItem,INotifiable,IReservable{
        public Book(string t,string a,int id):base(t,a,id){}
        public override void display(){
            Console.WriteLine($"Item Id:{item_id},Title: {title}, Author: {author}");
        }
        public override double Calculate_latefee(int day){
            return 1*day;
        }
        void IReservable.reserve(){
            Console.WriteLine("message reserved");
        }
        void INotifiable.accept(string msg){
            Console.WriteLine($"Message Accepted: {msg}");
        }

    }
    class Magazine:LibraryItem{
        public Magazine(string t,string a,int id):base(t,a,id){}
        public override void display(){
            Console.WriteLine($"Item Id:{item_id},Title: {title}, Author: {author}");
        }
        public override double Calculate_latefee(int day){
            return 0.5*day;       
        }
    }
    }
    namespace Users{
        class Member{
            public Member(string name){
                Console.WriteLine($"Username={name}");
            }
        }
    }
}