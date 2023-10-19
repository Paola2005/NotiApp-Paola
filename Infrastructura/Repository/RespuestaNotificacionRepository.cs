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

        public override async Task<IEnumerable<RespuestaNotificacion>> GetAllAsync(){
            return await _context.RespuestasNotificaciones
            .Include( p => p.BlockChains)
            .Include(m => m.ModulosNotificaciones)
            .ToListAsync();
        }

        public async Task<List<BlockChain>> GetBlockChainsAsync(int HiloResId){
            return await _context.BlockChains.Where(p => p.IdHiloRespuesta == HiloResId).ToListAsync();
        }

        public async Task<List<ModuloNotificacion>> GetModuloNotificaciones(int HiloResId2){
            return await _context.ModulosNotificaciones.Where(p => p.IdHiloRespuesta == HiloResId2).ToListAsync();
        }

        public async Task<RespuestaNotificacion> GetIdAsync(int id){
            return await _context.RespuestasNotificaciones
            .Include(p => p.BlockChains)
            .Include(m => m.ModulosNotificaciones)
            .FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}
