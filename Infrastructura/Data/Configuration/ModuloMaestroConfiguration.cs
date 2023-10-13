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

            builder.Property(d=>d.NombreModulo)
            .HasMaxLength(100);

        }  
    }
}