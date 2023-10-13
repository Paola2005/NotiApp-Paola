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
    public class FormatoRepository : GenericRepository<Formato>, IFormato
    {
        private readonly NotiContext _context;

        public FormatoRepository(NotiContext context) : base(context)
        {
            _context = context;
        }
    }
}