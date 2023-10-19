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
    public class SubModulosRepository : GenericRepository<SubModulos>, ISubModulo
    {
        private readonly NotiContext _context;

        public SubModulosRepository(NotiContext context) : base(context)
        {
            _context = context;
        }
        public override async Task<IEnumerable<SubModulos>> GetAllAsync(){
            return await _context.SubsModulos
            .Include(m => m.MaestrosvSubsModulos)
            .ToListAsync();
        }

        public async Task<List<MaestrosvSubModulos>> GetMaestrosvSubsModulos(int Id){
            return await _context.MaestrosvSubsModulos.Where(p => p.IdSubModulo == Id).ToListAsync();
        }

        public async Task<SubModulos> GetIdAsync(int id){
            return await _context.SubsModulos
            .Include(m => m.MaestrosvSubsModulos)
            .FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}