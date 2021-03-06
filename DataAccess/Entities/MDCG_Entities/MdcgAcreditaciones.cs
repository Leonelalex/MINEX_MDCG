using DataAccess.Entities.Generales;
using System;
using System.Collections.Generic;

namespace DataAccess.Entities.MDCG_Entities
{
    public partial class MdcgAcreditaciones
    {
        public MdcgAcreditaciones()
        {
            MdcgAdjuntoAcreditaciones = new HashSet<MdcgAdjuntoAcreditaciones>();
            MdcgBitacoras = new HashSet<MdcgBitacora>();
        }

        public int Codigo { get; set; }
        public int CodigoFuncionario { get; set; }
        public int CodigoMision { get; set; }
        public bool EsJefeMision { get; set; }
        public DateTime? FechaBeneplacito { get; set; }
        public DateTime? FechaSolicitudBeneplacito { get; set; }
        public DateTime? FechaPresentacionCredenciales { get; set; }
        public DateTime? FechaArribo { get; set; }
        public DateTime? FechaTomaPosesion { get; set; }
        public string NoAcreditacion { get; set; }
        public DateTime? FechaAcreditacion { get; set; }
        public DateTime? FechaSalida { get; set; }
        public string ViaSalida { get; set; }
        public string LugarAvisoRetiro { get; set; }
        public DateTime? FechaAvisoRetiro { get; set; }
        public string NumeroCarne { get; set; }
        public DateTime? FechaVigencia { get; set; }
        public DateTime? FechaDevolucion { get; set; }
        public string NotaDevolucion { get; set; }
        public string Observaciones { get; set; }
        public DateTime? FechaImpresion { get; set; }
        public string Guia { get; set; }
        public int Estado { get; set; }
        public bool? Eliminado { get; set; }
        public string UsuarioElimina { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioModifica { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public string UsuarioRegistra { get; set; }
        public DateTime? FechaEliminacion { get; set; }
        public bool SolicitaLicencia { get; set; }
        public int? NumeroTransito { get; set; }
        public int? NumeroPnc { get; set; }
        public int? CodigoTratamiento { get; set; }
        public int? CodigoTipoAcreditacion { get; set; }
        public int? CodigoCargo { get; set; }
        public int CorrelativoProtocolo { get; set; }

        public virtual MdcgCargo CodigoCargoNavigation { get; set; }
        public virtual MdcgFuncionario CodigoFuncionarioNavigation { get; set; }
        public virtual GlobMisionesExterior CodigoMisionNavigation { get; set; }
        public virtual MdcgTipoAcreditacion CodigoTipoAcreditacionNavigation { get; set; }
        public virtual GlobTratamiento CodigoTratamientoNavigation { get; set; }
        public virtual MdcgEstadosAcreditacion EstadoNavigation { get; set; }
        public virtual ICollection<MdcgAdjuntoAcreditaciones> MdcgAdjuntoAcreditaciones { get; set; }
        public virtual ICollection<MdcgBitacora> MdcgBitacoras { get; set; }
    }
}
