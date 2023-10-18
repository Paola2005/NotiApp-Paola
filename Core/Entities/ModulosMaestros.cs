using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class ModulosMaestros:BaseEntity
    {
        [Required]
        public string NombreModulo { get; set; }
        public ICollection<RolvsMaestro> RolsvsMaestros{get;set;}
        public string MaestrosvSubModulos { get; set; }
        public ICollection<MaestrosvSubModulos>MaestrosvSubsModulos{get; set;}
    }
}