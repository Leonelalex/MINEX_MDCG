using AutoMapper;
using Core.ServiceApp.Requests;
using Core.ServiceApp.Services.ServicesContracts;
using Core.ServiceApp.Utils;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace InterfaceApi.Controllers
{
    [Route("recepcionPNC")]
    [ApiController]
    public class RecepcionPNCController : ControllerBase
    {
        private readonly IRecepcionPNC_Service _recepcionService;
        private readonly IMapper _mapper;
        public RecepcionPNCController(IMapper mapper, IRecepcionPNC_Service recepcionService)
        {
            _mapper = mapper;
            _recepcionService = recepcionService;
        }

        [HttpGet]
        public async Task<ActionResult> GetBandejaRecepcion([FromHeader] string SessionToken)
        {
            try
            {
                if (String.IsNullOrEmpty(SessionToken))
                {
                    var tokenError = new ErrorResponse { code = Constanst.BadRequestCode, message = Constanst.MISSING_TOKEN_ERROR_MSG };
                    return StatusCode(Constanst.BadRequestCode, tokenError);
                }

                Response servRes = await _recepcionService.GetBanjejaRecepcion();

                if (servRes.codigo == 200)
                {
                    return Ok(servRes.data);
                }
                else
                {
                    return StatusCode(servRes.codigo, servRes.message);
                }

            }
            catch (Exception ex)
            {
                return StatusCode(Constanst.ServerErrorCode, new ErrorResponse { code = Constanst.ServerErrorCode, message = "Error al obtener dependientes" });
            }
        }

        [HttpPut]
        [Route("aprobar/{codAcreditacion}")]
        public async Task<ActionResult> AprobarPapeleria([FromHeader] string SessionToken, [FromRoute] int codAcreditacion, [FromBody] AprobarPNC_Req aprobacion)
        {
            try
            {
                if (String.IsNullOrEmpty(SessionToken))
                {
                    var tokenError = new ErrorResponse { code = Constanst.BadRequestCode, message = Constanst.MISSING_TOKEN_ERROR_MSG };
                    return StatusCode(Constanst.BadRequestCode, tokenError);
                }

                Response servRes = await _recepcionService.GetBanjejaRecepcion();

                if (servRes.codigo == 200)
                {
                    return Ok(servRes.data);
                }
                else
                {
                    return StatusCode(servRes.codigo, servRes.message);
                }

            }
            catch (Exception ex)
            {
                return StatusCode(Constanst.ServerErrorCode, new ErrorResponse { code = Constanst.ServerErrorCode, message = "Error al obtener dependientes" });
            }
        }

        [HttpPut]
        [Route("rechazar/{codAcreditacion}")]
        public async Task<ActionResult> RechazarPapeleria([FromHeader] string SessionToken, [FromRoute] int codAcreditacion, [FromBody] RechazarPNC_Req aprobacion)
        {
            try
            {
                if (String.IsNullOrEmpty(SessionToken))
                {
                    var tokenError = new ErrorResponse { code = Constanst.BadRequestCode, message = Constanst.MISSING_TOKEN_ERROR_MSG };
                    return StatusCode(Constanst.BadRequestCode, tokenError);
                }

                Response servRes = await _recepcionService.GetBanjejaRecepcion();

                if (servRes.codigo == 200)
                {
                    return Ok(servRes.data);
                }
                else
                {
                    return StatusCode(servRes.codigo, servRes.message);
                }

            }
            catch (Exception ex)
            {
                return StatusCode(Constanst.ServerErrorCode, new ErrorResponse { code = Constanst.ServerErrorCode, message = "Error al obtener dependientes" });
            }
        }
    }
}
