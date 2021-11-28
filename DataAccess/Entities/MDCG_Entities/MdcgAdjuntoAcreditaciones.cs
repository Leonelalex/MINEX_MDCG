namespace DataAccess.Entities.MDCG_Entities
{
    public partial class MdcgAdjuntoAcreditaciones
    {
        public int Codigo { get; set; }
        public int CodigoAcreditacion { get; set; }
        public string TituloDocumento { get; set; }
        public string RutaDocumento { get; set; }
        public string Observaciones { get; set; }
        public int CodigoGestion { get; set; }

        public virtual MdcgAcreditaciones CodigoAcreditacionNavigation { get; set; }
        public virtual MdcgTipoGestion CodigoGestionNavigation { get; set; }
    }
}
