using System;
using System.Collections.Generic;

#nullable disable

namespace scafflMDCG
{
    public partial class MdcgAdjuntoAcreditacione
    {
        public int Codigo { get; set; }
        public int CodigoAcreditacion { get; set; }
        public string TituloDocumento { get; set; }
        public string RutaDocumento { get; set; }
        public string Observaciones { get; set; }
        public int CodigoGestion { get; set; }

        public virtual MdcgAcreditacione CodigoAcreditacionNavigation { get; set; }
        public virtual MdcgTipoGestion CodigoGestionNavigation { get; set; }
    }
}
