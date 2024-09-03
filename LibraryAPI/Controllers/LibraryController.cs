using LibraryAPI.Models;
using LibraryAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI.Controllers
{
    public class LibraryController : LibraryBaseController
    {
        private readonly IBookService _bookService;

        public LibraryController(IBookService bookservice)
        {
            _bookService = bookservice;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<Book>> GetAllBooks()
        {
            var books = _bookService.GetAll();
            return Ok(books);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult GetBook(Guid id)
        {
            var book = _bookService.GetById(id);
            if (book == null)
            {
                return NotFound();
            }
            return Ok();
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult CreateBook([FromBody] Book book)
        {
            var createdBook = _bookService.CreateBook(book);
            return Created();
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public ActionResult UpdateBook(Guid id, [FromBody] Book updatedBook)
        {
            var book = _bookService.UpdateBook(id, updatedBook);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public ActionResult DeleteBook(Guid id)
        {
            var result = _bookService.DeleteBook(id);
            if (!result)
            {
                return NotFound();
            }
            return NoContent();
        }
    }
}
