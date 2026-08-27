using System;


abstract class Book
{
  
    private string title;
    private double price;

  
    public Book(string title, double price)
    {
        this.title = title;
        this.price = price;
    }

    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public double Price
    {
        get { return price; }
        set
        {
            if (value > 0)
                price = value;
        }
    }

   
    public void DisplayBasicDetails()
    {
        Console.WriteLine("Book Name : " + Title);
        Console.WriteLine("Price     : " + Price);
    }

  
    public abstract void DisplayCategory();
}



class Novel : Book
{
    public Novel(string title, double price)
        : base(title, price)
    {
    }

    // POLYMORPHISM
    public override void DisplayCategory()
    {
        Console.WriteLine("Category  : Novel");
    }
}



class TextBook : Book
{
    public TextBook(string title, double price)
        : base(title, price)
    {
    }


    public override void DisplayCategory()
    {
        Console.WriteLine("Category  : Text Book");
    }
}



class Program
{
    static void Main()
    {
       
        Book book1 = new Novel("The Alchemist", 450);

        Book book2 = new TextBook("C# Programming", 600);

        Console.WriteLine("===== BOOK SHOP =====");

        Console.WriteLine("\n--- Book 1 ---");

        book1.DisplayBasicDetails();
        book1.DisplayCategory();

        Console.WriteLine("\n--- Book 2 ---");

        book2.DisplayBasicDetails();
        book2.DisplayCategory();

        Console.WriteLine("\n--- Updating Price ---");

        book1.Price = 500;

        Console.WriteLine("Updated Price: ₹" + book1.Price);
    }
}