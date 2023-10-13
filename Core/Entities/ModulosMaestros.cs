using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class ModulosMaestros:BaseEntity
    {
        public string NombreModulo { get; set; }
        public ICollection<RolvsMaestro> RolsvsMaestros{get;set;}
        public object MaestrosvSubModulos { get; set; }
        public ICollection<MaestrosvSubModulos>MaestrosvSubsModulos{get; set;}
    }
}