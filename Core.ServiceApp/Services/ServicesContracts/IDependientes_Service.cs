

using Core.ServiceApp.Requests;
using Core.ServiceApp.Utils;
using System.Threading.Tasks;

namespace Core.ServiceApp.Services.ServicesContracts
{
    public interface IDependientes_Service
    {
        Task<Response> crearDependiente(Dependientes_Req dependiente, int codFuncionario);
        Task<Response> getDependientes(int codFuncionario);
        Task<Response> getDependienteById(int codDependiente);
        Task<Response> editDependiente(int codDependiente, DependienteEdit_Req depInfo);
        Task<Response> GuardarBiometricos(int codDependiente, Biometricos_Req biometricos);
        Task<Response> getBiometricos(int codDependiente);
        Task<Response> editarBiometricos(int codFuncionario, Biometricos_Req biometricos);
    }
}
