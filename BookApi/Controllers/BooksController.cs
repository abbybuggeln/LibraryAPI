using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using BookApi.Data;
using BookApi.Models;

namespace BookApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly BookStore _bookStore;

        public BooksController()
        {
            _bookStore = new BookStore();
        }

        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetBooks()
        {
            return _bookStore.GetBooks();
        }

        [HttpGet("{id}")]
        public ActionResult<Book> GetBook(int id)
        {
            var book = _bookStore.GetBookById(id);
            if (book == null)
            {
                return NotFound();
            }
            return book;
        }

        [HttpPost]
        public ActionResult<Book> AddBook(Book book)
        {
            _bookStore.AddBook(book);
            return CreatedAtAction(nameof(GetBook), new { id = book.Id }, book);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateBook(int id, Book book)
        {
            if (id != book.Id)
            {
                return BadRequest();
            }

            var existingBook = _bookStore.GetBookById(id);
            if (existingBook == null)
            {
                return NotFound();
            }

            _bookStore.UpdateBook(book);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            var book = _bookStore.GetBookById(id);
            if (book == null)
            {
                return NotFound();
            }

            _bookStore.DeleteBook(id);
            return NoContent();
        }
    }
}
