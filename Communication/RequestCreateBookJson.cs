using BookStoreApi.Entities;

namespace BookStoreApi.Communication;

public class RequestCreateBookJson
{
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public Kind Kind { get; set; }
    public double Price { get; set; }
}
