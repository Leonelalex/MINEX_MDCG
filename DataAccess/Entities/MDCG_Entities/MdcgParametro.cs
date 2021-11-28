using System;

#nullable disable

namespace DataAccess.Entities.MDCG_Entities
{
    public partial class MdcgParametro
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public int? CodigoModulo { get; set; }
        public string Valor { get; set; }
        public byte[] Imagen { get; set; }
        public string UsuarioRegistra { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public string UsuarioModifica { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioElimina { get; set; }
        public DateTime? FechaEliminacion { get; set; }
    }
}
