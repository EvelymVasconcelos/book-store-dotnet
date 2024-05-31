using BookStoreApi.Communication;
using BookStoreApi.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreApi.Controllers;

public class BookController : BookStoreApiBaseController
{
    [HttpPost]
    [ProducesResponseType(typeof (Book), StatusCodes.Status201Created)]
    public IActionResult CreateBook([FromBody] RequestCreateBookJson request)
    {
        var book = new Book()
        {
            Id = 1,
            Title = request.Title,
            Author = request.Author,
            Kind = request.Kind,
            Price = request.Price,
            Total = 2
        };
        
        return Created(string.Empty, book);
    }

    [HttpGet]
    [ProducesResponseType(typeof(List<Book>), StatusCodes.Status200OK)]
    public IActionResult GetAllBooks()
    {
        var response = GetBooks();
        return Ok(response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]

    public IActionResult UpdateBook([FromRoute] int id, [FromBody] RequestCreateBookJson request)
    {
        var books = GetBooks();
        var bookFound = books.Find(item => item.Id == id);

        if (bookFound is not null)
        {
            var newBook = new Book()
            {
                Id = bookFound.Id,
                Title = request.Title,
                Author = request.Author,
                Kind = request.Kind,
                Price = request.Price,
                Total = bookFound.Total,
            };
            return Ok("Book updated successfully");
        }
        else
        { 
            return NotFound("Book not found");
        }
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]

    public IActionResult DeleteBook([FromRoute] int id)
    {
        var books = GetBooks();
        var bookFound = books.Find(item => item.Id == id);

        if (bookFound is not null)
        {
            return Ok("Book deleted successfully");
        }
        else
        {
            return NotFound("Book not found");
        }
    }
}
 