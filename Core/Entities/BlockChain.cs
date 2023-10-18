using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class BlockChain:BaseEntity
    {
        public TipoNotificacion TiposNotificaciones{get;set;}
        public int IdNotificacion { get; set; }
        

        public RespuestaNotificacion RespuestasNotificaciones{get; set;}
        public int IdHiloRespuesta { get; set; }
        

        public Auditoria Auditorias{get; set;}
        public int IdAuditoria { get; set; }
        

        [Required]
        public string HashGenerado { get; set; }
    }
}