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
    public class TipoRequerimientoRepository : GenericRepository<TipoRequerimiento>, ITipoRequerimiento
    {
        private readonly NotiContext _context;

        public TipoRequerimientoRepository(NotiContext context) : base(context)
        {
            _context = context;
        }
        public override async Task<IEnumerable<TipoRequerimiento>> GetAllAsync(){
            return await _context.TiposRequerimientos
            .Include(m => m.ModulosNotificaciones)
            .ToListAsync();
        }

        public async Task<List<ModuloNotificacion>> GetModuloNotificaciones(int Id){
            return await _context.ModulosNotificaciones.Where(p => p.IdRequerimiento == Id).ToListAsync();
        }

        public async Task<TipoRequerimiento> GetIdAsync(int id){
            return await _context.TiposRequerimientos
            .Include(m => m.ModulosNotificaciones)
            .FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}