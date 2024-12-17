using HotelManagmentLogic.ApplicationContext;
using HotelManagmentLogic.Interfaces.Queries;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagmentLogic.Repositories.Queries
{
    public class RepositoryQueries<T> : IRepositoryQueries<T> where T : class
    {
        private readonly HotelDBContext _context;
        private readonly DbSet<T> _dbSet;

        public RepositoryQueries(HotelDBContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }
    }
}
