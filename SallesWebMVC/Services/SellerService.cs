using SallesWebMVC.Data;
using SallesWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SallesWebMVC.Services
{
    public class SellerService
    {

        private readonly SallesWebMVCContext _context;

        public SellerService(SallesWebMVCContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            obj.Department = _context.Department.First();
            _context.Add(obj);
            _context.SaveChanges();
        }

    }
}
