using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructura.Data;
using Infrastructure.Repositories;

namespace Infrastructura.Repository
{
    public class RadicadoRepository : GenericRepository<Radicado>, IRadicado
    {
        private readonly NotiContext _context;

        public RadicadoRepository(NotiContext context) : base(context)
        {
            _context = context;
        }
    }
}