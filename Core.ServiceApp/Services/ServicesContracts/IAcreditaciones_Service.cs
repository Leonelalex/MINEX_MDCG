
using Core.ServiceApp.Requests;
using Core.ServiceApp.Utils;
using System.Threading.Tasks;

namespace Core.ServiceApp.Services.ServicesContracts
{
    public interface IAcreditaciones_Service
    {
        Task<Response> CrearAcreditacion(Acreditacion_Req acreditacion, int codFucnionario);
        Task<Response> GetAcreditacionesFuncionario(int codFuncionario);
        Task<Response> GetAcreditacion(int codAcreditacion);
        Task<Response> EditarAcreditacion(int codAcreditacion, AcreditacionEdit_Req acreInfo);
    }
}
