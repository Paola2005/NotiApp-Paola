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
    public class MaestrosvSubModulosRepository : GenericRepository<MaestrosvSubModulos>, IMaestrosvSubModulos
    {
        private readonly NotiContext _context;

        public MaestrosvSubModulosRepository(NotiContext context) : base(context)
        {
            _context = context;
        }
        
    }
}