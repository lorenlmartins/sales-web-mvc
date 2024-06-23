using SalesWebMvc.Models;

namespace SalesWebMvc.Services;

public class DepartmentService(SalesWebMvcContext context)
{
    private readonly SalesWebMvcContext _context = context;

    public List<Department> FindAll()
    {
        return _context.Department.OrderBy(x => x.Name).ToList();
    }
}
