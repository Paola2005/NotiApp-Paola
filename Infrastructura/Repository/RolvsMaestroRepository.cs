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
    public class RolvsMaestroRepository : GenericRepository<RolvsMaestro>, IRolvsMaestro
    {
        private readonly NotiContext _context;

        public RolvsMaestroRepository(NotiContext context) : base(context)
        {
            _context = context;
        }
    }
}