using BookLibrary.Models;
using BookLibrary.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace BookLibrary.API.Controllers
{
    [ApiController]
    [Route("book")]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpPost("search")]
        public async Task<IActionResult> Search(SearchFilter filter)
        {
            var books = await _bookService.Search(filter);
            return Ok(books);
        }


        [HttpPost("dataSeed")]
        public async Task<IActionResult> DataSeed()
        {
            await _bookService.DataSeed();
            return Ok();
        }

    }
}