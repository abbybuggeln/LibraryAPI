using System.Collections.Generic;
using System.Linq;
using BookApi.Models;

namespace BookApi.Data
{
    public class BookStore
    {
        private static List<Book> Books = new List<Book>
        {
            new Book { Id = 1, Title = "1984", Author = "George Orwell", Year = 1949 },
            new Book { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", Year = 1960 }
        };

        public List<Book> GetBooks() => Books;

        public Book GetBookById(int id) => Books.FirstOrDefault(b => b.Id == id);

        public void AddBook(Book book)
        {
            book.Id = Books.Max(b => b.Id) + 1;
            Books.Add(book);
        }

        public void UpdateBook(Book book)
        {
            var index = Books.FindIndex(b => b.Id == book.Id);
            if (index != -1)
            {
                Books[index] = book;
            }
        }

        public void DeleteBook(int id)
        {
            var book = Books.FirstOrDefault(b => b.Id == id);
            if (book != null)
            {
                Books.Remove(book);
            }
        }
    }
}
