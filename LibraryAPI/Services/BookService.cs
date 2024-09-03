using LibraryAPI.Models;

namespace LibraryAPI.Services
{
    public class BookService : IBookService
    {
        private readonly List<Book> books = new List<Book>();
        public Book CreateBook(Book book)
        {
            book.Id = Guid.NewGuid();
            books.Add(book);
            return book;
        }

        public bool DeleteBook(Guid id)
        {
            var book = GetById(id);
            if (book != null)
            {
                books.Remove(book);
                return true;
            }
            else
            {
                return false;
            }
        }

        public IEnumerable<Book> GetAll()
        {
            return books;
        }

        public Book GetById(Guid id)
        {
            return books.FirstOrDefault( b => b.Id == id);
        }

        public bool UpdateBook(Guid id, Book updatedBook)
        {
            var existingBook = GetById(id);
            if (existingBook == null)
            {
                return false;
            }
            existingBook.Author = updatedBook.Author;
            existingBook.Title = updatedBook.Title;
            existingBook.Genre = updatedBook.Genre;
            existingBook.Price = updatedBook.Price;
            existingBook.Quantity = updatedBook.Quantity;
            return true;

        }
    }
}
