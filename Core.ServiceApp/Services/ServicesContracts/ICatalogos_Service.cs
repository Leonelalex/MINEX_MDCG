using Core.ServiceApp.Utils;
using System.Threading.Tasks;

namespace Core.ServiceApp.Services.ServicesContracts
{
    public interface ICatalogos_Service
    {
        Task<Response> getFuncionariosCatalogos();
        Task<Response> getDependientesCatalogos();
        Task<Response> getAcreditacionesCatalogos();
    }
}
