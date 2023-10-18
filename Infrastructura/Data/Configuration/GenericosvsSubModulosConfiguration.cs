using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructura.Data.Configuration
{
    public class GenericosvsSubModulosConfiguration : IEntityTypeConfiguration<GenericosvsSubModulos>
    {
        public void Configure(EntityTypeBuilder<GenericosvsSubModulos> builder)
        {
            builder.ToTable("GenericosVSSubModulos");
            builder.HasKey(i=>i.Id);
            builder.Property(w=>w.Id);

            builder.HasOne(o=>o.PermisoGenerico)
            .WithMany(o=>o.GenericossvSubsModulos)
            .HasForeignKey(o=>o.IdGenericos);

            builder.Property(w => w.FechaCreacion)
            .HasColumnType("DateTime");
            builder.Property(w => w.FechaModificacion)
            .HasColumnType("DateTime");

            builder.HasOne(p=>p.Roles)
            .WithMany(p=>p.GenericossvSubsModulos)
            .HasForeignKey(p=>p.IdRol);

            builder.HasOne(m=>m.MaestrosvSubsModulos)
            .WithMany(m=>m.GenericosvSubsModulos)
            .HasForeignKey(m=>m.IdSubModulos);

            
        }
    }
}