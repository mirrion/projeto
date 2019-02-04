using ProjetoAsp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjetoAsp.Services
{
    public class DepartmentService
    {
        private readonly ProjetoAspContext _context;

        public DepartmentService(ProjetoAspContext context)
        {
            _context = context;
        }

       public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
