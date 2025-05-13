namespace Lesson_12
{
    class Program
    {
        public static void Main()
        {
            Book<string, int>[] booksStringInt =
                { new Book<string, int>("F-1234","Some Title",1980,"John Dow"),
            new Book<string, int>("F-2222","Some Title",1981,"Jane Dow")};
            Book<int, string>[] booksIntString =
                { new Book<int, string>(42,"The Hitchhiker's Guide To The Galaxy","Some Period","Douglas Adams"),
            new Book<int, string>(13,"Some Title","1981","Jane Dow")};
            Console.WriteLine(Book<string, int>.FindBook(booksStringInt, "F-1234")?.ToString() ?? "Book not found");
            Console.WriteLine(Book<int, string>.FindBook(booksIntString, 42)?.ToString() ?? "Book not found");
            Console.WriteLine(Book<int, string>.FindBook(booksIntString, 100)?.ToString() ?? "Book not found");

        }
    }
}