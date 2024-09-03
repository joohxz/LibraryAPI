using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI.Controllers
{
    public class LibraryController : LibraryBaseController
    {

        [HttpGet("test-api")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Get() => Ok("Testando");


        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetBooks() => Ok("Books");

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public IActionResult CreateBook() => Created();

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult UpdateBook() => NoContent();

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult DeleteBook() => NoContent();
    }
}
