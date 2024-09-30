namespace Generics_Boxing_Unboxing;

public class Book <T>
{
    private string? Name;
    private int PagesCount;
    private string? Author;
    private T? ID;

    public Book(string name, int pagesCount, string author, T iD)
    {
        Name = name;
        PagesCount = pagesCount;
        Author = author;
        ID = iD;
    }

    public override string ToString()
    {
        return $"{ID} {Name}, {Author}, {PagesCount}";
    }
}
