using System.Text.Json.Serialization;

namespace ControllingJson;

public class Book
{
    public Book(string title)
    {
        Title = title;
    }

    public string Title { get; set; }
    public string? Author { get; set; }
    [JsonInclude]
    public DateTime PublishDate;
    [JsonInclude]
    public DateTimeOffset Created;
    public ushort Pages;
}