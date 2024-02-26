public LibraryBook(string title, string author, bool available)
{
    Title = title;
    Author = author;
    Available = available;
}

public void BorrowBook()
{
    if (Available)
    {
        Available = false;
        Console.WriteLine("You have borrowed " + Title + " by " + Author);
    }
    else
    {
        Console.WriteLine("Sorry, " + Title + " by " + Author + " is not available at the moment.");
    }
}

public void DisplayLibraryStatus()
{
    Console.WriteLine(Title + " by " + Author + ": " + (Available ? "Available" : "Not Available"));
}
}

class Program
{
    static void Main(string[] args)
    {
        LibraryBook book1 = new LibraryBook("To Kill a Mockingbird", "Harper Lee", true);
        LibraryBook book2 = new LibraryBook("1984", "George Orwell", false);
        LibraryBook book3 = new LibraryBook("The Great Gatsby", "F. Scott Fitzgerald", true);

        Console.WriteLine("Library Book Status:");
        Console.WriteLine("------------------");
        book1.DisplayLibraryStatus();
        book2.DisplayLibraryStatus();
        book3.DisplayLibraryStatus();

        Console.WriteLine("\nPerform Borrowing:");
        Console.WriteLine("----------------");
        book1.BorrowBook();
        book2.BorrowBook();
        book3.BorrowBook();

        Console.ReadKey();
    }
}