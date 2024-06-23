namespace SalesWebMvc.Models.ViewModels;

public class SellerFormViewModel
{
    public Seller Seller { get; set; } = default!;
    public ICollection<Department> Departments { get; set; } = default!;
}
