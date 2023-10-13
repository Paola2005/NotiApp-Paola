using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class ModuloNotificacionDto
    {
        public int Id { get; set; }
        public int IdTipoNotificacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string AsuntoNotificacion { get; set; }
        public string TextoNotificacion { get; set; }

    }
}