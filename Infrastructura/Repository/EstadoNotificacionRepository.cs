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
    public class EstadoNotificacionRepository
        : GenericRepository<EstadoNotificacion>,
            IEstadoNotificacion
    {
        private readonly NotiContext _context;

        public EstadoNotificacionRepository(NotiContext context)
            : base(context)
        {
            _context = context;
        }

        public override async Task<IEnumerable<EstadoNotificacion>> GetAllAsync()
        {
            return await _context.EstadosNotificaciones.Include(p => p.ModulosNotificaciones).ToListAsync();
        }

        public async Task<List<ModuloNotificacion>> GetModulosNotificacionesByAuditoriaIdAsync(int estadoId)
        {
            return await _context.ModulosNotificaciones
                .Where(d => d.IdEstadoNotificacion == estadoId)
                .ToListAsync();
        }

        public async Task<EstadoNotificacion> GetByIdAsync(int id)
        {
            return await _context.EstadosNotificaciones
                .Include(p => p.ModulosNotificaciones)
                .FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}
