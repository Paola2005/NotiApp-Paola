using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class BlockChain:BaseEntity
    {
        public int IdNotificacion { get; set; }
        public int IdHiloRespuesta { get; set; }
        public int IdAuditoria { get; set; }
        public string HashGenerado { get; set; }
    }
}