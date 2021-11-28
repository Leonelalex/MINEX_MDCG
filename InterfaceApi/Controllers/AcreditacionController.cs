using Core.ServiceApp.Requests;
using Core.ServiceApp.Services.ServicesContracts;
using Core.ServiceApp.Utils;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace InterfaceApi.Controllers
{
    [Route("acreditacion")]
    [ApiController]
    public class AcreditacionController : ControllerBase
    {
        private readonly IAcreditaciones_Service _acreditacionesService;

        public AcreditacionController(IAcreditaciones_Service acreditacionesService)
        {
            _acreditacionesService = acreditacionesService;
        }

        #region Crear Acreditacion
        [HttpPost]
        [Route("{codFuncionario}")]
        public async Task<ActionResult> CrearAcreditacion([FromHeader] string SessionToken, [FromBody] Acreditacion_Req acreditacion, [FromRoute] int codFuncionario)
        {
            try
            {
                if (String.IsNullOrEmpty(SessionToken))
                {
                    var tokenError = new ErrorResponse { code = Constanst.BadRequestCode, message = Constanst.MISSING_TOKEN_ERROR_MSG };
                    return StatusCode(Constanst.BadRequestCode, tokenError);
                }

                 Response servRes = await _acreditacionesService.CrearAcreditacion(acreditacion, codFuncionario);

                if (servRes.codigo == Constanst.ServerOkCode)
                {
                    return Ok(servRes.data);
                }
                else
                {
                    return StatusCode(servRes.codigo, new ErrorResponse { code = servRes.codigo, message = servRes.message });
                }
            }
            catch (Exception ex)
            {
                return StatusCode(Constanst.ServerErrorCode, new ErrorResponse { code = Constanst.ServerErrorCode, message = "Error al crear acreditacion" });
            }
        }
        #endregion

        #region Get Acreditaciones By Funcionario Id
        [HttpGet]
        [Route("funcionario/{codFuncionario}")]
        public async Task<ActionResult> getAcreditacionesFuncionario([FromHeader] string SessionToken, [FromRoute] int codFuncionario)
        {
            try
            {
                if (String.IsNullOrEmpty(SessionToken))
                {
                    var tokenError = new ErrorResponse { code = Constanst.BadRequestCode, message = Constanst.MISSING_TOKEN_ERROR_MSG };
                    return StatusCode(Constanst.BadRequestCode, tokenError);
                }

                Response servRes = await _acreditacionesService.GetAcreditacionesFuncionario(codFuncionario);

                if (servRes.codigo == Constanst.ServerOkCode)
                {
                    return Ok(servRes.data);
                }
                else
                {
                    return StatusCode(servRes.codigo, new ErrorResponse { code = servRes.codigo, message = servRes.message });
                }
            }
            catch (Exception ex)
            {
                return StatusCode(Constanst.ServerErrorCode, new ErrorResponse { code = Constanst.ServerErrorCode, message = "Error al obtener acreditaciones" });
            }
        }
        #endregion

        #region Get Acreditacion
        [HttpGet]
        [Route("{codAcreditacion}")]
        public async Task<ActionResult> getAcreditacion([FromHeader] string SessionToken, [FromRoute] int codAcreditacion)
        {
            try
            {
                if (String.IsNullOrEmpty(SessionToken))
                {
                    var tokenError = new ErrorResponse { code = Constanst.BadRequestCode, message = Constanst.MISSING_TOKEN_ERROR_MSG };
                    return StatusCode(Constanst.BadRequestCode, tokenError);
                }

                Response servRes = await _acreditacionesService.GetAcreditacion(codAcreditacion);

                if (servRes.codigo == 200)
                {
                    return Ok(servRes.data);
                }
                else
                {
                    return StatusCode(servRes.codigo, new ErrorResponse { code = servRes.codigo, message = servRes.message });
                }

            }
            catch (Exception ex)
            {
                return StatusCode(Constanst.ServerErrorCode, new ErrorResponse { code = Constanst.ServerErrorCode, message = "Error al obtener la acreditación" });
            }
        }
        #endregion

        #region Editar Acreditacion
        [HttpPut]
        [Route("{codAcreditacion}")]
        public async Task<ActionResult> editarAcreditacion([FromHeader] string SessionToken, [FromRoute] int codAcreditacion, [FromBody] AcreditacionEdit_Req acreInfo)
        {
            try
            {
                if (String.IsNullOrEmpty(SessionToken))
                {
                    var tokenError = new ErrorResponse { code = Constanst.BadRequestCode, message = Constanst.MISSING_TOKEN_ERROR_MSG };
                    return StatusCode(Constanst.BadRequestCode, tokenError);
                }

                Response servRes = await _acreditacionesService.EditarAcreditacion(codAcreditacion, acreInfo);

                if (servRes.codigo == 200)
                {
                    return Ok(servRes.data);
                }
                else
                {
                    return StatusCode(servRes.codigo, new ErrorResponse { code = servRes.codigo, message = servRes.message });
                }

            }
            catch (Exception ex)
            {
                return StatusCode(Constanst.ServerErrorCode, new ErrorResponse { code = Constanst.ServerErrorCode, message = "Error al editar la acreditación" });
            }
        }
        #endregion
    }
}
