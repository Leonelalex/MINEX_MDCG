using Core.ServiceApp.Requests;
using Core.ServiceApp.Services.ServicesContracts;
using Core.ServiceApp.Utils;
using DataAccess.Helpers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace InterfaceApi.Controllers
{
    [Route("funcionario")]
    [ApiController]
    public class FuncionariosController : ControllerBase
    {
        private readonly IFuncionario_Service _funcionarioService;

        public FuncionariosController(IFuncionario_Service funcionarioService)
        {
            _funcionarioService = funcionarioService;
        }

        #region CREAR Funcionario
        [HttpPost]
        public async Task<ActionResult> CrearFuncionario(Funcionario_Req funcionario, [FromHeader] string SessionToken)
        {
            try
            {
                if (String.IsNullOrEmpty(SessionToken))
                {
                    var tokenError = new ErrorResponse { code = Constanst.BadRequestCode, message = Constanst.MISSING_TOKEN_ERROR_MSG };
                    return StatusCode(Constanst.BadRequestCode, tokenError);
                }

                Response servRes = await _funcionarioService.CrearFuncionario(funcionario);

                if (servRes.codigo == 200)
                {
                    return Ok(servRes.data);
                }
                else
                {
                    return StatusCode(servRes.codigo, new ErrorResponse { code = servRes.codigo, message = servRes.message });
                }

            } catch (Exception ex)
            {
                return StatusCode(Constanst.ServerErrorCode, new ErrorResponse { code = Constanst.ServerErrorCode, message = "Error al intentar crear al Funcionario" });
            }
        }
        #endregion

        #region GET Funcionarios
        [HttpGet]
        public async Task<ActionResult> GetFuncionarios([FromQuery] PaginationFilter filter, [FromHeader] string SessionToken)
        {
            try
            {
                if (String.IsNullOrEmpty(SessionToken))
                {
                    var tokenError = new ErrorResponse { code = Constanst.BadRequestCode, message = Constanst.MISSING_TOKEN_ERROR_MSG };
                    return StatusCode(Constanst.BadRequestCode, tokenError);
                }

                Response servRes = await _funcionarioService.GetFuncionarios(filter);

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
                return StatusCode(Constanst.ServerErrorCode, new ErrorResponse { code = Constanst.ServerErrorCode, message = "Error al intentar obtener los Funcionarios" });
            }
        }
        #endregion

        #region GET Funcionario by Id
        [HttpGet]
        [Route("{codFuncionario}")]
        public async Task<ActionResult> GetFuncionarioById([FromHeader] string SessionToken, [FromRoute] int codFuncionario)
        {
            try
            {
                if (String.IsNullOrEmpty(SessionToken))
                {
                    var tokenError = new ErrorResponse { code = Constanst.BadRequestCode, message = Constanst.MISSING_TOKEN_ERROR_MSG };
                    return StatusCode(Constanst.BadRequestCode, tokenError);
                }

                Response servRes = await _funcionarioService.GetFuncionarioById(codFuncionario);

                if(servRes.codigo == 200)
                {
                    return Ok(servRes.data);
                }
                else
                {
                    return StatusCode(servRes.codigo, new ErrorResponse { code = servRes.codigo, message = servRes.message });
                }

            }
            catch(Exception ex)
            {
                return StatusCode(Constanst.ServerErrorCode, new ErrorResponse { code = Constanst.ServerErrorCode, message = "Error al buscar el funcionario" });
            }
        }
        #endregion

        #region Editar Funcionario
        [HttpPut]
        [Route("{codFuncionario}")]
        public async Task<ActionResult> EditarFuncionario([FromHeader] string SessionToken, [FromRoute] int codFuncionario, [FromBody] FuncionarioEdit_Req funcInfo)
        {
            try
            {
                if (String.IsNullOrEmpty(SessionToken))
                {
                    var tokenError = new ErrorResponse { code = Constanst.BadRequestCode, message = Constanst.MISSING_TOKEN_ERROR_MSG };
                    return StatusCode(Constanst.BadRequestCode, tokenError);
                }
                if(!ModelState.IsValid)
                {
                    var tokenError = new ErrorResponse { code = Constanst.BadRequestCode, message = ModelState.ToString() };
                    return StatusCode(Constanst.BadRequestCode, tokenError);
                }
                    

                Response servRes = await _funcionarioService.EditarFuncionario(codFuncionario, funcInfo);

                if(servRes.codigo == 200)
                {
                    return Ok(servRes.data);
                }
                else
                {
                    return StatusCode(Constanst.ServerErrorCode, new ErrorResponse { code = Constanst.ServerErrorCode, message = servRes.message });
                }

            }
            catch(Exception ex)
            {
                return StatusCode(Constanst.ServerErrorCode, new ErrorResponse { code = Constanst.ServerErrorCode, message = "Error al editar el funcionario" });
            }
        }
        #endregion

        #region Guardar Biometricos 
        [HttpPost]
        [Route("biometricos/{codFuncionario}")]
        public async Task<ActionResult> GuardarBiometricos([FromHeader] string SessionToken, [FromRoute] int codFuncionario, [FromBody] Biometricos_Req biometricos)
        {
            try
            {
                if (String.IsNullOrEmpty(SessionToken))
                {
                    var tokenError = new ErrorResponse { code = Constanst.BadRequestCode, message = Constanst.MISSING_TOKEN_ERROR_MSG };
                    return StatusCode(Constanst.BadRequestCode, tokenError);
                }


                Response servRes = await _funcionarioService.GuardarBiometricos(codFuncionario, biometricos);

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
        [Route("biometricos/{codFuncionario}")]
        public async Task<ActionResult> EdiatrBiometricos([FromHeader] string SessionToken, [FromRoute] int codFuncionario, [FromBody] Biometricos_Req biometricos)
        {
            try
            {
                if (String.IsNullOrEmpty(SessionToken))
                {
                    var tokenError = new ErrorResponse { code = Constanst.BadRequestCode, message = Constanst.MISSING_TOKEN_ERROR_MSG };
                    return StatusCode(Constanst.BadRequestCode, tokenError);
                }



                Response servRes = await _funcionarioService.editarBiometricos(codFuncionario, biometricos);

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
        [Route("biometricos/{codFuncionario}")]
        public async Task<ActionResult> getBiometricos([FromHeader] string SessionToken, [FromRoute] int codFuncionario)
        {
            try
            {
                if (String.IsNullOrEmpty(SessionToken))
                {
                    var tokenError = new ErrorResponse { code = Constanst.BadRequestCode, message = Constanst.MISSING_TOKEN_ERROR_MSG };
                    return StatusCode(Constanst.BadRequestCode, tokenError);
                }


                Response servRes = await _funcionarioService.getBiometricos(codFuncionario);

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
