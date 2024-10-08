using System.Reflection;

class Book
{
    //Properties
    string Title;
    string Author;
    string ISBN;
    int NoOfPages;


    // Constructor for Book Object
    // Add a new instance of the book class
    public Book(string bookTitle, string bookAuthor, string bookISBN, int bookNoOfPages)
    {
        Title = bookTitle;
        Author = bookAuthor;
        ISBN = bookISBN;
        NoOfPages = bookNoOfPages;
    }


    void DisplayInfo()
    {
        Console.WriteLine($"Book Information");
        Console.WriteLine("-------------------");
        Console.WriteLine($"Book.title: {Title}");
        Console.WriteLine($"Book.author: {Author}");
        Console.WriteLine($"Book.ISBN: {ISBN}");
        Console.WriteLine($"No. of Pages: {NoOfPages}");
        Console.WriteLine("-------------------");
    }    



    static void Main(string[] args)

    {

        //Create a new instance of the book class
        Book book = new Book("C# for Beginners", "Bill Gates", "12345", 200);

        // Another Instance?
        // title = "Visual Studio 2022"
        // Author = "Microsoft"
        // ISBN = "123"
        // No. of Pages

        Book book2 = new Book("Visual Studio 2022", "Microsoft", "123", 70);


      

        

        //Output book info to the console
        book.DisplayInfo();
        book2.DisplayInfo();
        


    }
}