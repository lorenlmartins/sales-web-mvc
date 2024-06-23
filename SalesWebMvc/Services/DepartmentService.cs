using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Models;

namespace SalesWebMvc.Services;

public class DepartmentService(SalesWebMvcContext context)
{
    private readonly SalesWebMvcContext _context = context;

    public async Task<List<Department>> FindAllAsync()
    {
        return await _context.Department.OrderBy(x => x.Name).ToListAsync();
    }
}