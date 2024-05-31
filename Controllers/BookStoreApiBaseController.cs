using BookStoreApi.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public abstract class BookStoreApiBaseController : ControllerBase
{
    protected List<Book> GetBooks()
    {
        var response = new List<Book>()
        {
            new Book()
            {
                Id = 1,
                Title = "Vidas Secas",
                Author = "Graciano Ramos",
                Kind = Kind.Romance,
                Price = 42.66,
                Total = 2
            },
            new Book {
                Id = 2,
                Title = "Vidas Secas",
                Author = "Graciano Ramos",
                Kind = Kind.Romance,
                Price = 42.66,
                Total = 2
            },
            new Book {
                Id = 1,
                Title = "O Pequeno Príncipe",
                Author = "Antoine de Saint-Exupéry",
                Kind = Kind.Ficcao,
                Price = 20.00,
                Total = 1
            }
        };
        return response;
    }
}
