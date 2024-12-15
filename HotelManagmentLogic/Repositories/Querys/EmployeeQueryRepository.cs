using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enteties;
using HotelManagmentLogic.ApplicationContext;
using HotelManagmentLogic.Interfaces.IRepoository.Querys;
using Microsoft.EntityFrameworkCore;

namespace HotelManagmentLogic.Repositories.Querys
{
    public class EmployeeQueryRepository : IEmployeeQueryRepository
    {
        private readonly HotelDBContext _context;

        public EmployeeQueryRepository(HotelDBContext context)
        {
            _context = context;
        }

        public async Task<Employee> GetEmployeeByIdAsync(int id)
        {
            return await _context.Employees.FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<IEnumerable<Employee>> GetAllEmployeesAsync()
        {
            return await _context.Employees.ToListAsync();
        }
    }
}
