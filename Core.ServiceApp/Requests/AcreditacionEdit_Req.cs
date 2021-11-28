using System;

namespace Core.ServiceApp.Requests
{
    public class AcreditacionEdit_Req
    {
        public int CodigoMision { get; set; }
        public bool EsJefeMision { get; set; }
        public DateTime? FechaBeneplacito { get; set; }
        public DateTime? FechaSolicitudBeneplacito { get; set; }
        public DateTime? FechaPresentacionCredenciales { get; set; }
        public DateTime? FechaArribo { get; set; }
        public DateTime? FechaTomaPosesion { get; set; }
        public DateTime? FechaAcreditacion { get; set; }
        public DateTime? FechaSalida { get; set; }
        public string ViaSalida { get; set; }
        public string LugarAvisoRetiro { get; set; }
        public DateTime? FechaAvisoRetiro { get; set; }
        public string ServiciosPrestados { get; set; }
        public DateTime? FechaVigencia { get; set; }
        public DateTime? FechaDevolucion { get; set; }
        public string NotaDevolucion { get; set; }
        public string Observaciones { get; set; }
        public string Asistente { get; set; }
        public bool SolicitaLicencia { get; set; }
        public int? CodigoTratamiento { get; set; }
        public int? CodigoTipoAcreditacion { get; set; }
        public int? CodigoCargo { get; set; }
        public int? Orden { get; set; }
        public string Guia { get; set; }
    }
}
