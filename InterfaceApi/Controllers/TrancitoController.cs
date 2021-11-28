using Core.ServiceApp.Services.ServicesContracts;
using Core.ServiceApp.Utils;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace InterfaceApi.Controllers
{
    [Route("transito")]
    [ApiController]
    public class TrancitoController : ControllerBase
    {
        private readonly ITransito_Service _transitoService;
        public TrancitoController(ITransito_Service transitoService)
        {
            _transitoService = transitoService;
        }

        [HttpGet]
        public async Task<ActionResult> GetBandejaTransito([FromHeader] string SessionToken)
        {
            try
            {
                if (String.IsNullOrEmpty(SessionToken))
                {
                    var tokenError = new ErrorResponse { code = Constanst.BadRequestCode, message = Constanst.MISSING_TOKEN_ERROR_MSG };
                    return StatusCode(Constanst.BadRequestCode, tokenError);
                }

                return Ok();

            }
            catch (Exception ex)
            {
                return StatusCode(Constanst.ServerErrorCode, new ErrorResponse { code = Constanst.ServerErrorCode, message = "Error al obtener dependientes" });
            }
        }
    }
}
