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
    public class FormatoRepository : GenericRepository<Formato>, IFormato
    {
        private readonly NotiContext _context;

        public FormatoRepository(NotiContext context) : base(context)
        {
            _context = context;
        }
        public override async Task<IEnumerable<Formato>> GetAllAsync(){
            return await _context.Formatos
            .Include(m => m.ModulosNotificaciones)
            .ToListAsync();
        }

        public async Task<List<ModuloNotificacion>> GetModuloNotificaciones(int formatoId){
            return await _context.ModulosNotificaciones.Where(p => p.IdFromato == formatoId).ToListAsync();
        }

        public async Task<Formato> GetIdAsync(int id){
            return await _context.Formatos
            .Include(m => m.ModulosNotificaciones)
            .FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}