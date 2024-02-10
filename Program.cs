namespace Projeto1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What book are you looking for?");
        string usersSearching = Console.ReadLine();
        Console.WriteLine("here is your book! :" + booksClassification);

    }

    public class booksClassification {
        string name = "name of the book";
        int publicationData = 0001;
        string author = "name of the author";
        int pages = 1000;
    };




}
