using System;
using System.Collections.Generic;

#nullable disable

namespace scafflMDCG
{
    public partial class MdcgCargo
    {
        public MdcgCargo()
        {
            MdcgAcreditaciones = new HashSet<MdcgAcreditacione>();
        }

        public int Codigo { get; set; }
        public string Cargo { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<MdcgAcreditacione> MdcgAcreditaciones { get; set; }
    }
}
