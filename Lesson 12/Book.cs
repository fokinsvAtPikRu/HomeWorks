using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_12
{
    internal class Book<T,U> where T : IEquatable<T>
    {
        T Code { get; }
        string Title {  get; }  
    U PublicationYear { get; }
    string  Author { get; }
        public Book(T code, string title,U year,string author)
        {
            this.Code = code;
            this.Title = title;
            this.PublicationYear = year;
            this.Author = author;
        }
        public override string ToString() =>        
        $"Код: {Code} ({typeof(T)}), Название: {Title}, Автор: {Author}, Год: {PublicationYear} ({typeof(U)})";
        public static Book<T,U>? FindBook<T,U>(Book<T,U>[] books, T code) where T : IEquatable<T>
        {
            foreach (var book in books)
            {
                if(book.Code.Equals(code))
                    return book;
            }
            return null;
        }
    }
}
