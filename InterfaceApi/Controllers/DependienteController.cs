using Core.ServiceApp.Requests;
using Core.ServiceApp.Services.ServicesContracts;
using Core.ServiceApp.Utils;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace InterfaceApi.Controllers
{
    [Route("dependiente")]
    [ApiController]
    public class DependienteController : ControllerBase
    {
        private readonly IDependientes_Service _dependientesService;

        public DependienteController(IDependientes_Service dependientesService)
        {
            _dependientesService = dependientesService;
        }

        #region Crear Dependiente
        [HttpPost]
        [Route("{codFuncionario}")]
        public async Task<ActionResult> CrearDependiente([FromHeader] string SessionToken, [FromBody] Dependientes_Req dependiente, [FromRoute] int codFuncionario)
        {
            try
            {
                if (String.IsNullOrEmpty(SessionToken))
                {
                    var tokenError = new ErrorResponse { code = Constanst.BadRequestCode, message = Constanst.MISSING_TOKEN_ERROR_MSG };
                    return StatusCode(Constanst.BadRequestCode, tokenError);
                }

                Response servRes = await _dependientesService.crearDependiente(dependiente, codFuncionario);

                return Ok(servRes.data);
            }
            catch(Exception ex)
            {
                return StatusCode(Constanst.ServerErrorCode, new ErrorResponse { code = Constanst.ServerErrorCode, message = "Error al crear al dependiente" });
            }
        }
        #endregion

        #region Get Dependientes By Funcionario Id
        [HttpGet]
        [Route("funcionario/{codFuncionario}")]
        public async Task<ActionResult> getDependientesFuncionario([FromHeader] string SessionToken, [FromRoute] int codFuncionario)
        {
            try
            {
                if (String.IsNullOrEmpty(SessionToken))
                {
                    var tokenError = new ErrorResponse { code = Constanst.BadRequestCode, message = Constanst.MISSING_TOKEN_ERROR_MSG };
                    return StatusCode(Constanst.BadRequestCode, tokenError);
                }

                Response servRes = await _dependientesService.getDependientes(codFuncionario);

                if(servRes.codigo == 200)
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
        #endregion

        #region Get Dependiente By Id
        [HttpGet]
        [Route("{codDependiente}")]
        public async Task<ActionResult> getDependiente([FromHeader] string SessionToken, [FromRoute] int codDependiente)
        {
            try
            {
                if (String.IsNullOrEmpty(SessionToken))
                {
                    var tokenError = new ErrorResponse { code = Constanst.BadRequestCode, message = Constanst.MISSING_TOKEN_ERROR_MSG };
                    return StatusCode(Constanst.BadRequestCode, tokenError);
                }

                Response servRes = await _dependientesService.getDependienteById(codDependiente);

                if (servRes.codigo == Constanst.ServerOkCode)
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
                return StatusCode(Constanst.ServerErrorCode, new ErrorResponse { code = Constanst.ServerErrorCode, message = "Error al obtener el dependiente" });
            }
        }
        #endregion

        #region Editar Dependiente
        [HttpPut]
        [Route("{codDependiente}")]
        public async Task<ActionResult> editDependiente ([FromHeader] string SessionToken, [FromRoute] int codDependiente, [FromBody] DependienteEdit_Req dependiente)
        {
            try
            {
                if (String.IsNullOrEmpty(SessionToken))
                {
                    var tokenError = new ErrorResponse { code = Constanst.BadRequestCode, message = Constanst.MISSING_TOKEN_ERROR_MSG };
                    return StatusCode(Constanst.BadRequestCode, tokenError);
                }

                Response servRes = await _dependientesService.editDependiente(codDependiente, dependiente);

                if (servRes.codigo == Constanst.ServerOkCode)
                {
                    return Ok(servRes.data);
                }
                else
                {
                    return Ok(servRes);
                }

            }
            catch (Exception ex)
            {
                return StatusCode(Constanst.ServerErrorCode, new ErrorResponse { code = Constanst.ServerErrorCode, message = "Error al editar el dependiente" });
            }
        }
        #endregion

        #region Acreditar Dependiente
        [HttpPut]
        [Route("acreditar/{codDependiente}")]
        public async Task<ActionResult> AcreditarDependiente([FromHeader] string SessionToken, [FromRoute] int codDependiente)
        {
            try
            {
                if (String.IsNullOrEmpty(SessionToken))
                {
                    var tokenError = new ErrorResponse { code = Constanst.BadRequestCode, message = Constanst.MISSING_TOKEN_ERROR_MSG };
                    return StatusCode(Constanst.BadRequestCode, tokenError);
                }

                Response servRes = new Response { codigo = 200, data=null};

                if (servRes.codigo == Constanst.ServerOkCode)
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
                return StatusCode(Constanst.ServerErrorCode, new ErrorResponse { code = Constanst.ServerErrorCode, message = "Error al intentar acreditar al dependiente" });
            }
        }
        #endregion

        #region Desacreditar Dependiente
        [HttpPut]
        [Route("desacreditar/{codDependiente}")]
        public async Task<ActionResult> DesacreditarDependiente([FromHeader] string SessionToken, [FromRoute] int codDependiente)
        {
            try
            {
                if (String.IsNullOrEmpty(SessionToken))
                {
                    var tokenError = new ErrorResponse { code = Constanst.BadRequestCode, message = Constanst.MISSING_TOKEN_ERROR_MSG };
                    return StatusCode(Constanst.BadRequestCode, tokenError);
                }

                Response servRes = new Response { codigo = 200, data = null };

                if (servRes.codigo == Constanst.ServerOkCode)
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
                return StatusCode(Constanst.ServerErrorCode, new ErrorResponse { code = Constanst.ServerErrorCode, message = "Error al intentar desacreditar al dependiente" });
            }
        }
        #endregion

        #region Guardar Biometricos 
        [HttpPost]
        [Route("biometricos/{codDependiente}")]
        public async Task<ActionResult> GuardarBiometricos([FromHeader] string SessionToken, [FromRoute] int codDependiente, [FromBody] Biometricos_Req biometricos)
        {
            try
            {
                if (String.IsNullOrEmpty(SessionToken))
                {
                    var tokenError = new ErrorResponse { code = Constanst.BadRequestCode, message = Constanst.MISSING_TOKEN_ERROR_MSG };
                    return StatusCode(Constanst.BadRequestCode, tokenError);
                }
                if (!ModelState.IsValid)
                {
                    var tokenError = new ErrorResponse { code = Constanst.BadRequestCode, message = ModelState.ToString() };
                    return StatusCode(Constanst.BadRequestCode, tokenError);
                }


                Response servRes = await _dependientesService.GuardarBiometricos(codDependiente, biometricos);

                if (servRes.codigo == 200)
                {
                    return Ok(servRes.data);
                }
                else
                {
                    return StatusCode(Constanst.ServerErrorCode, new ErrorResponse { code = Constanst.ServerErrorCode, message = servRes.message });
                }

            }
            catch (Exception ex)
            {
                return StatusCode(Constanst.ServerErrorCode, new ErrorResponse { code = Constanst.ServerErrorCode, message = "Error al guardar datos biometricos" });
            }
        }
        #endregion

        #region Editar Biometricos 
        [HttpPut]
        [Route("biometricos/{codDependiente}")]
        public async Task<ActionResult> EdiatrBiometricos([FromHeader] string SessionToken, [FromRoute] int codDependiente, [FromBody] Biometricos_Req biometricos)
        {
            try
            {
                if (String.IsNullOrEmpty(SessionToken))
                {
                    var tokenError = new ErrorResponse { code = Constanst.BadRequestCode, message = Constanst.MISSING_TOKEN_ERROR_MSG };
                    return StatusCode(Constanst.BadRequestCode, tokenError);
                }
                if (!ModelState.IsValid)
                {
                    var tokenError = new ErrorResponse { code = Constanst.BadRequestCode, message = ModelState.ToString() };
                    return StatusCode(Constanst.BadRequestCode, tokenError);
                }


                Response servRes = await _dependientesService.editarBiometricos(codDependiente, biometricos);

                if (servRes.codigo == 200)
                {
                    return Ok(servRes.data);
                }
                else
                {
                    return StatusCode(Constanst.ServerErrorCode, new ErrorResponse { code = Constanst.ServerErrorCode, message = servRes.message });
                }

            }
            catch (Exception ex)
            {
                return StatusCode(Constanst.ServerErrorCode, new ErrorResponse { code = Constanst.ServerErrorCode, message = "Error al editar datos biometricos" });
            }
        }
        #endregion

        #region Get Biometricos 
        [HttpGet]
        [Route("biometricos/{codDependiente}")]
        public async Task<ActionResult> getBiometricos([FromHeader] string SessionToken, [FromRoute] int codDependiente)
        {
            try
            {
                if (String.IsNullOrEmpty(SessionToken))
                {
                    var tokenError = new ErrorResponse { code = Constanst.BadRequestCode, message = Constanst.MISSING_TOKEN_ERROR_MSG };
                    return StatusCode(Constanst.BadRequestCode, tokenError);
                }
                if (!ModelState.IsValid)
                {
                    var tokenError = new ErrorResponse { code = Constanst.BadRequestCode, message = ModelState.ToString() };
                    return StatusCode(Constanst.BadRequestCode, tokenError);
                }


                Response servRes = await _dependientesService.getBiometricos(codDependiente);

                if (servRes.codigo == 200)
                {
                    return Ok(servRes.data);
                }
                else
                {
                    return StatusCode(Constanst.ServerErrorCode, new ErrorResponse { code = Constanst.ServerErrorCode, message = servRes.message });
                }

            }
            catch (Exception ex)
            {
                return StatusCode(Constanst.ServerErrorCode, new ErrorResponse { code = Constanst.ServerErrorCode, message = "Error al intentar obtener datos biometricos" });
            }
        }
        #endregion
    }
}
