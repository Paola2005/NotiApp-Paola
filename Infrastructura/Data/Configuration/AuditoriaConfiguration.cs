using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructura.Data.Configuration;

public class AuditoriaConfiguration : IEntityTypeConfiguration<Auditoria>
{
    public void Configure(EntityTypeBuilder<Auditoria> builder)
    {
        builder.ToTable("Auditoria");
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id);

        builder.Property(p => p.NombreUsuario)
        .HasMaxLength(100);

        builder.Property(w => w.FechaCreacion)
            .HasColumnType("DateTime");
        builder.Property(w => w.FechaModificacion)
        .HasColumnType("DateTime");

        builder.Property(j => j.DescAccion)
        .HasColumnType("int");

    }
}
