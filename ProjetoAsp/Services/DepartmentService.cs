using ProjetoAsp.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoAsp.Services
{
    public class DepartmentService
    {
        private readonly ProjetoAspContext _context;

        public DepartmentService(ProjetoAspContext context)
        {
            _context = context;
        }

       public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
