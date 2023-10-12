using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class RespuestaNotificacion:BaseEntity
    {
        public string NombreTipo { get; set; }
        public ICollection<ModuloNotificacion> ModulosNotificaciones{get; set;}
    }
}