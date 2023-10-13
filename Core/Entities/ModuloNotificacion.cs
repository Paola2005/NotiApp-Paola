using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class ModuloNotificacion:BaseEntity
    {
        public string AsuntoNotificacion { get; set; }
        
        public int IdTipoNotificacion { get; set; }
        public TipoNotificacion TiposNotificaciones{get; set;}
        public int IdRadicado { get; set; }
        public Radicado Radicados{get; set;}
        public int IdEstadoNotificacion { get; set; }
        public EstadoNotificacion EstadosNotificaciones{get; set;}
        public int IdHiloRespuesta { get; set; }
        public RespuestaNotificacion RespuestasNotificaciones{get; set;}
        public int IdFromato { get; set; }
        public Formato Formatos{get; set;}
        public int IdRequerimiento { get; set; }
        public TipoRequerimiento TiposRequerimientos{get; set;}
        public string TextoNotificacion { get; set; }
    }
}