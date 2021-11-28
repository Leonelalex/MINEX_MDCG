using Core.ServiceApp.Utils;
using System.Threading.Tasks;

namespace Core.ServiceApp.Services.ServicesContracts
{
    public interface IRecepcionPNC_Service
    {
        Task<Response> GetBanjejaRecepcion();
    }
}
