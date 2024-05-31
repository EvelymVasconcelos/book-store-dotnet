using System.Reflection;

namespace BookStoreApi.Entities;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Author {  get; set; } = string.Empty;
    public Kind Kind { get; set; }
    public double Price { get; set; }
    public int Total { get; set; }
}
