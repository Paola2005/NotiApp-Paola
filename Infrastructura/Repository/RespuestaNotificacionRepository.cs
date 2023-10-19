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
    public class RespuestaNotificacionRepository
        : GenericRepository<RespuestaNotificacion>,
            IRespuestaNotificacion
    {
        private readonly NotiContext _context;

        public RespuestaNotificacionRepository(NotiContext context)
            : base(context)
        {
            _context = context;
        }

        public override async Task<IEnumerable<RespuestaNotificacion>> GetAllAsync()
        {
            return await _context.RespuestasNotificaciones.Include(p => p.BlockChains).ToListAsync();
        }

        public async Task<List<BlockChain>> GetBlockChainsByHiloRespuestaIdAsync(int hilorespuestaId)
        {
            return await _context.BlockChains
                .Where(d => d.IdHiloRespuesta == hilorespuestaId)
                .ToListAsync();
        }

        public async Task<RespuestaNotificacion> GetByIdAsync(int id)
        {
            return await _context.RespuestasNotificaciones
                .Include(p => p.BlockChains)
                .FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}
