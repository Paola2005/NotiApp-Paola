using System.Collections.Immutable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructura.Data.Configuration
{
    public class RespuestaNotificacionConfiguration : IEntityTypeConfiguration<RespuestaNotificacion>
    {
        public void Configure(EntityTypeBuilder<RespuestaNotificacion> builder)
        {
            builder.ToTable("RespuestaNotificacion");
            builder.HasKey(m=>m.Id);
            builder.Property(m=>m.Id);

            builder.Property(i=>i.NombreTipo)
            .HasMaxLength(80);

        }
    }
}