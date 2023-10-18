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
    public class ModuloNotificacionConfiguration : IEntityTypeConfiguration<ModuloNotificacion>
    {
        public void Configure(EntityTypeBuilder<ModuloNotificacion> builder)
        {
            builder.ToTable("ModuloNotificacion");
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Id);

            builder.HasOne(t => t.TiposNotificaciones)
            .WithMany(t => t.ModulosNotificaciones)
            .HasForeignKey(t => t.IdTipoNotificacion);

            builder.HasOne(h => h.Radicados)
            .WithMany(h => h.ModulosNotificaciones)
            .HasForeignKey(h => h.IdRadicado);

            builder.HasOne(d => d.EstadosNotificaciones)
            .WithMany(d => d.ModulosNotificaciones)
            .HasForeignKey(d => d.IdEstadoNotificacion);

            builder.HasOne(k => k.RespuestasNotificaciones)
            .WithMany(k => k.ModulosNotificaciones)
            .HasForeignKey(k => k.IdHiloRespuesta);

            builder.HasOne(a => a.Formatos)
            .WithMany(a => a.ModulosNotificaciones)
            .HasForeignKey(a => a.IdFromato);

            builder.HasOne(c => c.TiposRequerimientos)
            .WithMany(c => c.ModulosNotificaciones)
            .HasForeignKey(c => c.IdRequerimiento);

            builder.Property(s=>s.TextoNotificacion)
            .HasMaxLength(2000);

            builder.Property(y=>y.AsuntoNotificacion)
            .HasMaxLength(80);

            builder.Property(w => w.FechaCreacion)
            .HasColumnType("DateTime");
            builder.Property(w => w.FechaModificacion)
            .HasColumnType("DateTime");


        }
    }
}