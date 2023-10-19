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
    public class TipoNotificacionRepository : GenericRepository<TipoNotificacion>, ITipoNotificacion
    {
        private readonly NotiContext _context;

        public TipoNotificacionRepository(NotiContext context) : base(context)
        {
            _context = context;
        }
        public override async Task<IEnumerable<TipoNotificacion>> GetAllAsync()
        {
            return await _context.TiposNotificaciones
            .Include(p => p.BlockChains)
            .Include(m => m.ModulosNotificaciones)
            .ToListAsync();
        }

        public async Task<List<BlockChain>> GetBlockChainsByNotificacionIdAsync(int notificacionId)
        {
            return await _context.BlockChains
                .Where(d => d.IdNotificacion == notificacionId)
                .ToListAsync();
        }
        public async Task<List<ModuloNotificacion>> GetModuloNotificaciones(int TiponotiId2){
            return await _context.ModulosNotificaciones.Where(p => p.IdTipoNotificacion == TiponotiId2).ToListAsync();
        }

        public async Task<TipoNotificacion> GetByIdAsync(int id)
        {
            return await _context.TiposNotificaciones
                .Include(p => p.BlockChains)
                .Include(m => m.ModulosNotificaciones)
                .FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}