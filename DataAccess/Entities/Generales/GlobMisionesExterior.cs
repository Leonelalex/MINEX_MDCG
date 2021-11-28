using DataAccess.Entities.MDCG_Entities;
using System;
using System.Collections.Generic;

namespace DataAccess.Entities.Generales
{
    public partial class GlobMisionesExterior
    {
        public GlobMisionesExterior()
        {
            MdcgAcreditaciones = new HashSet<MdcgAcreditaciones>();
        }

        public int code { get; set; }
        public string name { get; set; }
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

        public virtual ICollection<MdcgAcreditaciones> MdcgAcreditaciones { get; set; }
    }
}
