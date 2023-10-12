using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructura.Data
{
    public class NotiContext : DbContext
    {
        public NotiContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Auditoria>Auditorias{get; set;}
        
    }
}