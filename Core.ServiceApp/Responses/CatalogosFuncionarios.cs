using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ServiceApp.Responses
{
    class CatalogosFuncionarios
    {
        public IEnumerable<GenericCatalog> genero { get; set; }
        public IEnumerable<GenericCatalog> estadoCivil { get; set; }
        public IEnumerable<GenericCatalog> pais { get; set; }
        public IEnumerable<GenericCatalog> tipoPasaporte { get; set; }
        public IEnumerable<GenericCatalog> tipoFuncionario { get; set; }
        public IEnumerable<GenericCatalog> gradoAcademico { get; set; }
        public IEnumerable<GenericCatalog> tipoLicencia { get; set; }
    }

    class CatalogoDependientes
    {
        public IEnumerable<GenericCatalog> pais { get; set; }
        public IEnumerable<GenericCatalog> parentescos { get; set; }
        public IEnumerable<GenericCatalog> tipoPasaporte { get; set;  }
        public IEnumerable<GenericCatalog> tipoLicencia { get; set; }
        public IEnumerable<GenericCatalog> genero { get; set; }
    }

    class CatalogoAcreditaciones
    {
        public IEnumerable<GenericCatalog> pais { get; set; }
        public IEnumerable<MisionCatalog> mision { get; set; }
        public IEnumerable<GenericCatalog> tipoAcreditacion { get; set; }
        public IEnumerable<GenericCatalog> tratamiento { get; set; }
        public IEnumerable<GenericCatalog> cargo { get; set; }
    }

    public class GenericCatalog
    {

        public int code { get; set; }
        public string name { get; set; }
    }

    public class MisionCatalog
    {
        public int code { get; set; }
        public string name { get; set; }
        public int CodigoPais { get; set; }
    }
}
