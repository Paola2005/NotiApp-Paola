using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class RespuestaNotificacionDto
    {
        public int Id { get; set; }
        public string NombreTipo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public List<BlockChainDto> BlockChains {get; set;}
        public List<ModuloNotificacionDto> ModuloNoficaciones {get; set;}
    }
}