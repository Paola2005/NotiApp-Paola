using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class ModuloNotificacion:BaseEntity
    {
        public string AsutoNotificacion { get; set; }
        public int IdTipoNotificacion { get; set; }
        public int IdRadicado { get; set; }
        public int IdEstadoNotificacion { get; set; }
        public int IdHiloRespuesta { get; set; }
        public int IdFromato { get; set; }
        public int IdRequerimiento { get; set; }
        public string TextoNotificacion { get; set; }
    }
}