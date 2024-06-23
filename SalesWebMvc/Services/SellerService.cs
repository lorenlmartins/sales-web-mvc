using SalesWebMvc.Models;

namespace SalesWebMvc.Services;

public class SellerService(SalesWebMvcContext context)
{
    private readonly SalesWebMvcContext _context = context;

    public List<Seller> FindAll()
    {
        return _context.Seller.ToList();
    }
}