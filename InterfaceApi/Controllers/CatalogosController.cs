using Core.ServiceApp.Services.ServicesContracts;
using Core.ServiceApp.Utils;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace InterfaceApi.Controllers
{
    [Route("catalogos")]
    [ApiController]
    public class CatalogosController : ControllerBase
    {
        private readonly ICatalogos_Service _catalogosService;

        public CatalogosController(ICatalogos_Service catalogoService)
        {
            _catalogosService = catalogoService;
        }

        #region Catalogos de Funcionario
        [HttpGet]
        [Route("funcionario")]
        public async Task<ActionResult> CatalogoFuncionario([FromHeader] string SessionToken)
        {
            try
            {
                if (String.IsNullOrEmpty(SessionToken))
                {
                    var tokenError = new ErrorResponse { code = Constanst.BadRequestCode, message = Constanst.MISSING_TOKEN_ERROR_MSG };
                    return StatusCode(Constanst.BadRequestCode, tokenError);
                }

                Response servRes = await _catalogosService.getFuncionariosCatalogos();

                return Ok(servRes.data);

            }
            catch (Exception ex)
            {
                var Error = new ErrorResponse { code = Constanst.ServerErrorCode, message = ex.Message };
                return StatusCode(Constanst.ServerErrorCode, Error);
            }
        }

        #endregion

        #region Catalogos de Dependientes
        [HttpGet]
        [Route("dependiente")]
        public async Task<ActionResult> CatalogosDependientes([FromHeader] string SessionToken)
        {
            try
            {
                if (String.IsNullOrEmpty(SessionToken))
                {
                    var tokenError = new ErrorResponse { code = Constanst.BadRequestCode, message = Constanst.MISSING_TOKEN_ERROR_MSG };
                    return StatusCode(Constanst.BadRequestCode, tokenError);
                }

                Response servRes = await _catalogosService.getDependientesCatalogos();

                return Ok(servRes.data);
            }
            catch (Exception ex) {
                var Error = new ErrorResponse { code = Constanst.ServerErrorCode, message = ex.Message };
                return StatusCode(Constanst.ServerErrorCode, Error);
            }

        }
        #endregion

        #region Catalogos de Acreditaciones
        [HttpGet]
        [Route("acreditacion")]
        public async Task<ActionResult> CatalogosAcreditaciones([FromHeader] string SessionToken)
        {
            try
            {
                if (String.IsNullOrEmpty(SessionToken))
                {
                    var tokenError = new ErrorResponse { code = Constanst.BadRequestCode, message = Constanst.MISSING_TOKEN_ERROR_MSG };
                    return StatusCode(Constanst.BadRequestCode, tokenError);
                }

                Response servRes = await _catalogosService.getAcreditacionesCatalogos();

                return Ok(servRes.data);
            }
            catch (Exception ex)
            {
                var Error = new ErrorResponse { code = Constanst.ServerErrorCode, message = ex.Message };
                return StatusCode(Constanst.ServerErrorCode, Error);
            }
        }
        #endregion
    }
}
