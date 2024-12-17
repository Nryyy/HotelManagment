using HotelManagmentLogic.ApplicationContext;
using HotelManagmentLogic.Interfaces.Commands;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagmentLogic.Repositories.Commands
{
    public class RepositoryCommands<T> : IRepositoryCommands<T> where T : class
    {
        private readonly HotelDBContext _context;
        private readonly DbSet<T> _dbSet;

        public RepositoryCommands(HotelDBContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public async Task AddAsync(T entity) => await _dbSet.AddAsync(entity);
        public async Task UpdateAsync(T entity) =>  _dbSet.Update(entity);
        public async Task DeleteAsync(int id)
        {
            var entity = await _dbSet.FindAsync(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
            }
        }
    }
}
