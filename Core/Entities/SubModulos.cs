using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class SubModulos:BaseEntity
    {
        public string NombreSubModulo { get; set; }
        public ICollection<MaestrosvSubModulos>MaestrosvSubsModulos{get;set;}
    }
}