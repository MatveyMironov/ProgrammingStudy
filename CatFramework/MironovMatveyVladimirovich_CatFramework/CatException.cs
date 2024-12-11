using System.Security.Claims;

public class CatException : ArgumentException
{
    public CatException(string message) : base(message)
    {
        
    }
}
