using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructura.Data.Configuration
{
    public class ModuloMaestroConfiguration : IEntityTypeConfiguration<ModulosMaestros>
    {
        public void Configure(EntityTypeBuilder<ModulosMaestros> builder)
        {
            builder.ToTable("ModulosMaestros");
            builder.HasKey(h=>h.Id);
            builder.Property(h=>h.Id);

            builder.Property(w => w.FechaCreacion)
            .HasColumnType("DateTime");
            builder.Property(w => w.FechaModificacion)
            .HasColumnType("DateTime");

            builder.Property(d=>d.NombreModulo)
            .IsRequired()
            .HasMaxLength(100);

        }  
    }
}