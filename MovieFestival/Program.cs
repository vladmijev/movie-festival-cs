namespace MovieFestival;

// FIXME: Rename file and class to App
class Program
{
    static void Main(string[] args)
    {

        string genre = new Genre("Drama").GetData();

        Console.WriteLine("Hi!" + genre);
    }
}

