using LibraryAPI.Models;

namespace LibraryAPI.Services
{
    public interface IBookService
    {
        Book CreateBook(Book book);
        Book GetById(Guid id);
        IEnumerable<Book> GetAll();
        bool UpdateBook(Guid id);
        bool DeleteBook(Guid id);

    }
}
