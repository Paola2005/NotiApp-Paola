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
    public class MaestrosvSubModulosRepository : GenericRepository<MaestrosvSubModulos>, IMaestrosvSubModulos
    {
        private readonly NotiContext _context;

        public MaestrosvSubModulosRepository(NotiContext context) : base(context)
        {
            _context = context;
        }
        public override async Task<IEnumerable<MaestrosvSubModulos>> GetAllAsync()
        {
            return await _context.MaestrosvSubsModulos.Include(p => p.GenericosvSubsModulos).ToListAsync();
        }

        public async Task<List<GenericosvsSubModulos>> MaestorsId(int genericoId)
        {
            return await _context.GenericossvSubsModulos
                .Where(d => d.IdSubModulos == genericoId)
                .ToListAsync();
        }

        public async Task<MaestrosvSubModulos> GetByIdAsync(int id)
        {
            return await _context.MaestrosvSubsModulos
                .Include(p => p.GenericosvSubsModulos)
                .FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}