using System;
using Items=LibraryItemClass.Item;
using users=LibraryItemClass.Users;
class MainClass{
    public static void Main(string[] args){
        users.Member m=new users.Member("Karan");
        Items.Book b=new Items.Book("once upon","karan",1);
        b.display();
        Console.WriteLine(b.Calculate_latefee(5));
        Items.IReservable r=b;
        Items.INotifiable n=b;
        r.reserve();
        n.accept("Jagriti Fool");
        List<Items.LibraryItem> arr=new List<Items.LibraryItem>();
        Items.LibraryItem i1=new Items.Book("once upon","karan",1);
        Items.LibraryItem i2=new Items.Magazine("kjh","qwertg",2);
        arr.Add(i1);
        arr.Add(i2);
        for(int i=0;i<arr.Count;i++){
            DisplayDetails(arr,i);
        }
    }
    public static void DisplayDetails(List<Items.LibraryItem> arr,int i){
        if(i%2==0){
            Console.WriteLine($"Book Version: {arr[i].item_id}");
        }else{
            Console.WriteLine($"Magazine Version: {arr[i].item_id}");
        }
    }
}


for(int i=0;i<5;i++){
    Rectangle r=new Rectangle(1,2);
    lr.Add(r);
}