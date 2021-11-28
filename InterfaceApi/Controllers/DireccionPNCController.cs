using Core.ServiceApp.Services.ServicesContracts;
using Core.ServiceApp.Utils;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace InterfaceApi.Controllers
{
    [Route("direccionPNC")]
    [ApiController]
    public class DireccionPNCController : ControllerBase
    {
        private readonly IDireccionPNC_Service _direccionService;
        public DireccionPNCController(IDireccionPNC_Service direccionService)
        {
            _direccionService = direccionService;
        }

        [HttpGet]
        public async Task<ActionResult> GetBandejaDireccion([FromHeader] string SessionToken)
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
