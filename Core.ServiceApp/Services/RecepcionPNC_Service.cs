using Core.ServiceApp.Services.ServicesContracts;
using Core.ServiceApp.Utils;
using DataAccess.MDCG_Repositories.MDCG_RepositoriesContracts.MDCG;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.ServiceApp.Services
{
    public class RecepcionPNC_Service : IRecepcionPNC_Service
    {
        IMDCG_ACREDITACIONES_REPO _acreditacionesRepo;
        public RecepcionPNC_Service(IMDCG_ACREDITACIONES_REPO acreditacionesRepo)
        {
            _acreditacionesRepo = acreditacionesRepo;
        }

        public async Task<Response> GetBanjejaRecepcion()
        {
            Response res = new Response();
            try
            {
                IEnumerable<Acreditaciones_VM> acreditaciones = _acreditacionesRepo.GetBandejaRecepcion();

                res.codigo = Constanst.ServerOkCode;
                res.data = acreditaciones;

            }
            catch (Exception ex)
            {
                res.codigo = Constanst.ServerErrorCode;
                res.innerError = ex.InnerException.Message;
                res.message = "Error al intentar obtener las acreditaciones";
            }
            return res;
        }
    }
}
