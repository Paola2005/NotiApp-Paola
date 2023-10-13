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

            builder.HasOne(p=>p.Roles)
            .WithMany(p=>p.GenericossvSubsModulos)
            .HasForeignKey(p=>p.IdRol);

            builder.HasOne(m=>m.MaestrosvSubsModulos)
            .WithMany(m=>m.GenericossvSubsModulos)
            .HasForeignKey(m=>m.IdSubModulos);

            
        }
    }
}