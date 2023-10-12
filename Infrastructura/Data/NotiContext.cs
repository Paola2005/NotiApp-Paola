using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
        public DbSet<Auditoria> Auditorias { get; set; }
        public DbSet<BlockChain>BlockChains{get; set;}
        public DbSet<EstadoNotificacion>EstadosNotificaciones{get; set;}
        public DbSet<Formato>Formatos{get; set;}
        public DbSet<GenericosvsSubModulos> GenericossvSubsModulos{get; set;}
        public DbSet<MaestrosvSubModulos>MaestrosvSubsModulos{get; set;}
        public DbSet<ModuloNotificacion>ModulosNotificaciones{get; set;}
        public DbSet<ModulosMaestros> ModuloMaestros{get; set;}
        public DbSet<PermisosGenericos> PermisoGenerico{get; set;}
        public DbSet<Radicado> Radicados{get; set;}
        public DbSet<RespuestaNotificacion>RespuestasNotificaciones{get; set;}
        public DbSet<Rol> Roles{get; set;}
        public DbSet<RolvsMaestro>RolsvsMaestros{get;set;}
        public DbSet<SubModulos>SubsModulos{get; set;}
        public DbSet<TipoNotificacion>TiposNotificaciones{get; set;}
        public DbSet<TipoRequerimiento> TiposRequerimientos{get; set;}


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public async Task<int> SaveChangeAsync()
        {
            return await base.SaveChangesAsync();
        }
    }
}