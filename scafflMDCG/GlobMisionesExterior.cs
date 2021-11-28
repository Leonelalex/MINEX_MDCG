using System;
using System.Collections.Generic;

#nullable disable

namespace scafflMDCG
{
    public partial class GlobMisionesExterior
    {
        public GlobMisionesExterior()
        {
            MdcgAcreditaciones = new HashSet<MdcgAcreditacione>();
        }

        public int IdMisionExterior { get; set; }
        public string NombreMision { get; set; }
        public string NombreMisionTransferencia { get; set; }
        public int CodigoTipoMision { get; set; }
        public int? CodigoPais { get; set; }
        public int? CodigoCiudad { get; set; }
        public int? CodigoDepartamento { get; set; }
        public string Direccion { get; set; }
        public string Zip { get; set; }
        public string Telefono { get; set; }
        public string Fax { get; set; }
        public string CorreoElectronico { get; set; }
        public string SitioWeb { get; set; }
        public string CircunscripcionSeccionConsular { get; set; }
        public DateTime? FechaAcreditacion { get; set; }
        public string Horario { get; set; }
        public string FiestaNacional { get; set; }
        public int? Moneda { get; set; }
        public string Notas { get; set; }
        public int? Prioridad { get; set; }

        public virtual ICollection<MdcgAcreditacione> MdcgAcreditaciones { get; set; }
    }
}
