using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class TipoRequerimiento:BaseEntity
    {
        public string NombreRequerimiento { get; set; }
        public ICollection<ModuloNotificacion> ModulosNotificaciones{get; set;}
    }
}