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
    public class ModulosMaestrosRepository : GenericRepository<ModulosMaestros>, IModulosMaestros
    {
        private readonly NotiContext _context;

        public ModulosMaestrosRepository(NotiContext context) : base(context)
        {
            _context = context;
        }
        public override async Task<IEnumerable<ModulosMaestros>> GetAllAsync(){
            return await _context.ModuloMaestros
            .Include( p => p.RolsvsMaestros)
            .Include(m => m.MaestrosvSubsModulos)
            .ToListAsync();
        }

        public async Task<List<RolvsMaestro>> GetRolvsMaestros(int Id){
            return await _context.RolsvsMaestros.Where(p => p.IdRol == Id).ToListAsync();
        }

        public async Task<List<MaestrosvSubModulos>> GetMaestrosvSubsModulos(int Id2){
            return await _context.MaestrosvSubsModulos.Where(p => p.IdMaestro == Id2).ToListAsync();
        }

        public async Task<ModulosMaestros> GetIdAsync(int id){
            return await _context.ModuloMaestros
            .Include(p => p.RolsvsMaestros)
            .Include(m => m.MaestrosvSubsModulos)
            .FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}