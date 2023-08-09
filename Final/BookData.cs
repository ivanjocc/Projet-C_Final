public class BookData
{
    public string Name { get; set; }
    public string Author { get; set; }

    public BookData(string name, string author)
    {
        Name = name;
        Author = author;
    }
}
