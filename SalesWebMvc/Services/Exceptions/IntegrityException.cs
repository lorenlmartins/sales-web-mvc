namespace SalesWebMvc.Services.Exceptions;

public class IntegrityException(string message) : ApplicationException(message)
{
}