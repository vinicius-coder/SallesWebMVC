using Microsoft.EntityFrameworkCore;
using SallesWebMVC.Data;
using SallesWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SallesWebMVC.Services
{
    public class DepartmentService
    {

        private readonly SallesWebMVCContext _context;

        public DepartmentService(SallesWebMVCContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }

        public void Insert(Department obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
