using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructura.Data;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infrastructura.Repository
{
    public class RolRepository : GenericRepository<Rol>, IRol
    {
        private readonly NotiContext _context;

        public RolRepository(NotiContext context) : base(context)
        {
            _context = context;
        }
        public override async Task<IEnumerable<Rol>> GetAllAsync()
        {
            return await _context.Roles.Include(p => p.RolsvsMaestros).ToListAsync();
        }

        public async Task<List<RolvsMaestro>> RolId(int rolId)
        {
            return await _context.RolsvsMaestros
                .Where(d => d.IdRol == rolId)
                .ToListAsync();
        }

        public async Task<Rol> GetByIdAsync(int id)
        {
            return await _context.Roles
                .Include(p => p.RolsvsMaestros)
                .FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}