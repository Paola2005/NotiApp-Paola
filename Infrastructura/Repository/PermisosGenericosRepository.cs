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
    public class PermisosGenericosRepository : GenericRepository<PermisosGenericos>, IPermisosGenericos
    {
        private readonly NotiContext _context;

        public PermisosGenericosRepository(NotiContext context) : base(context)
        {
            _context = context;
        }
        public override async Task<IEnumerable<PermisosGenericos>> GetAllAsync()
        {
            return await _context.PermisoGenerico.Include(p => p.GenericossvSubsModulos).ToListAsync();
        }

        public async Task<List<GenericosvsSubModulos>> PermisosId(int genericopermisoId)
        {
            return await _context.GenericossvSubsModulos
                .Where(d => d.IdGenericos == genericopermisoId)
                .ToListAsync();
        }

        public async Task<PermisosGenericos> GetByIdAsync(int id)
        {
            return await _context.PermisoGenerico
                .Include(p => p.GenericossvSubsModulos)
                .FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}