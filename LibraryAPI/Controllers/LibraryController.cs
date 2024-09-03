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
        public ActionResult GetBooks() => Ok("Books");

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult CreateBook([FromBody] Book book)
        {
            var createdBook = _bookService.CreateBook(book);
            return Created();
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public ActionResult UpdateBook() => NoContent();

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public ActionResult DeleteBook() => NoContent();
    }
}
