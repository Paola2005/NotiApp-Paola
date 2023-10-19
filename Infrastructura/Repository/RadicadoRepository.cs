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
    public class RadicadoRepository : GenericRepository<Radicado>, IRadicado
    {
        private readonly NotiContext _context;

        public RadicadoRepository(NotiContext context) : base(context)
        {
            _context = context;
        }
        public override async Task<IEnumerable<Radicado>> GetAllAsync(){
            return await _context.Radicados
            .Include(m => m.ModulosNotificaciones)
            .ToListAsync();
        }

        public async Task<List<ModuloNotificacion>> GetModuloNotificaciones(int Id){
            return await _context.ModulosNotificaciones.Where(p => p.IdRadicado == Id).ToListAsync();
        }

        public async Task<Radicado> GetIdAsync(int id){
            return await _context.Radicados
            .Include(m => m.ModulosNotificaciones)
            .FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}