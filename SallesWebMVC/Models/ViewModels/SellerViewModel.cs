using System.Collections.Generic;

namespace SallesWebMVC.Models.ViewModels
{
    public class SellerViewModel
    {

        public Seller Seller { get; set; }
        public ICollection<Department> Departments { get; set; }

    }
}
