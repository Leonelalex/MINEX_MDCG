using AutoMapper;
using Core.ServiceApp.Requests;
using Core.ServiceApp.Services.ServicesContracts;
using Core.ServiceApp.Utils;
using DataAccess.Entities.MDCG_Entities;
using DataAccess.Helpers;
using DataAccess.MDCG_Repositories.MDCG_RepositoriesContracts.MDCG;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Core.ServiceApp.Services
{
    public class Funcionario_Service : IFuncionario_Service
    {
        private readonly IMCDG_FUNCIONARIO_REPO _funcionarioRepo;
        private readonly IMapper _mapper;
        public Funcionario_Service(IMapper mapper, IMCDG_FUNCIONARIO_REPO funcionarioRepo)
        {
            _mapper = mapper;
            _funcionarioRepo = funcionarioRepo;
        }

        #region Crear Funcionario
        public async Task<Response> CrearFuncionario(Funcionario_Req funcionario)
        {
            Response res = new Response();
            try
            {
           
                MdcgFuncionario newFuncionario = new MdcgFuncionario
                {
                    Nombres = funcionario.Nombres,
                    Apellidos = funcionario.Apellidos,
                    Genero = funcionario.Genero,
                    FechaNacimiento = funcionario.FechaNacimiento,
                    PaisOrigen = funcionario.PaisOrigen,
                    CorreoElectronico = funcionario.CorreoElectronico,
                    OtrosMediosComunicacion = funcionario.OtrosMediosComunicacion,
                    ApellidoCasada = funcionario.ApellidoCasada,
                    LugarNacimiento = funcionario.LugarNacimiento,
                    CodigoTipoPasaporte = funcionario.TipoPasaporte,
                    NumeroPasaporte = funcionario.NumeroPasaporte,
                    CodigoGradoAcademico = funcionario.GradoAcademico,
                    DireccionParticular = funcionario.DireccionParticular,
                    TelefonoParticular = funcionario.TelefonoParticular,
                    CodigoEstadoCivil = funcionario.EstadoCivil,
                    NacionalidadAdquirida = funcionario.NacionalidadAdquirida,
                    CodigoTipoFuncionario = funcionario.TipoFuncionario,
                    TipoLicencia = funcionario.tipoLicencia,
                    Eliminado = false,
                    Estado = true,
                    FechaVencimientoPasaporte = funcionario.FechaVencimientoPasaporte,
                    FechaVencimientoLicencia = funcionario.FechaVencimientoLicencia
                };

                newFuncionario = await _funcionarioRepo.Add(newFuncionario);

                res.codigo = Constanst.ServerOkCode;
                res.data = new { codigoFuncionario = newFuncionario.Codigo, mensaje = "Funcionario creado" };
            }
            catch (Exception ex)
            {
                res.codigo = Constanst.ServerErrorCode;
                res.innerError = ex.InnerException.Message;
                res.message = "Error al intentar crear el funcionario";
            }
            return res;
        }
        #endregion

        #region Get Funcionarios
        public async Task<Response> GetFuncionarios(PaginationFilter filter)
        {
            Response res = new Response();
            try
            {

                if (filter.PageNumber == -1)
                {
                    res.codigo = 200;
                    int total = _funcionarioRepo.countFuncionarios();
                    res.data = new { funcionarios = _funcionarioRepo.getAllFuncionarios(), total = total };
                }
                else
                {
                    res.codigo = 200;
                    res.data = new { funcionarios = _funcionarioRepo.getFuncionarios(filter), total = _funcionarioRepo.countFuncionarios() };
                }

            }
            catch (Exception ex)
            {
                res.codigo = Constanst.ServerErrorCode;
                res.innerError = ex.InnerException.Message;
                res.message = "Error al obtener funcionarios";
            }
            return res;
        }
        #endregion

        #region Get Funcionario By code
        public async Task<Response> GetFuncionarioById(int code)
        {
            Response res = new Response();
            try
            {
                res.codigo = 200;
                res.data = _funcionarioRepo.getFuncionarioById(code);

            }
            catch (Exception ex)
            {
                res.codigo = Constanst.ServerErrorCode;
                res.innerError = ex.InnerException.Message;
                res.message = "Error al buscar el funcionario";
            }
            return res;
        }
        #endregion

        #region Editar Funcionario
        public async Task<Response> EditarFuncionario(int code, FuncionarioEdit_Req funcInfo)
        {
            Response res = new Response();
            try
            {
                MdcgFuncionario funcionario = await _funcionarioRepo.GetByID(code);
                _mapper.Map(funcInfo, funcionario);
               
                await _funcionarioRepo.Update(funcionario);

                res.codigo = Constanst.ServerOkCode;
                res.data = new { funcionarioId = funcionario.Codigo, message = "Funcionario editado con éxito" };

            }
            catch (DbUpdateException ex)
            {
                if (ex.InnerException is SqlException sqlEx && sqlEx.Number == 515)
                {
                    res.codigo = Constanst.ServerErrorCode;
                    res.innerError = ex.Message;
                    res.message = "Ocurrio un error en base de datos por llave foránea ";
                }
                else {
                    res.codigo = Constanst.ServerErrorCode;
                    res.innerError = ex.Message;
                    res.message = "Ocurrio un error en base de datos";
                }
            }
            catch (Exception ex)
            {
                res.codigo = Constanst.ServerErrorCode;
                res.innerError = ex.InnerException.Message;
                res.message = "Error al editar el funcionario";
            }
            return res;
        }

        #endregion

        #region Guardar Biometricos
        public async Task<Response> GuardarBiometricos(int codFuncionario, Biometricos_Req biometricos)
        {
            Response res = new Response();
            try
            {
                MdcgFuncionario funcionario = await _funcionarioRepo.GetByID(codFuncionario);

                if (!String.IsNullOrEmpty(biometricos.Foto))
                    funcionario.Fotografia = biometricos.Foto;

                if (!String.IsNullOrEmpty(biometricos.Firma))
                {
                    string fileName = funcionario.Codigo + "Firma.png";
                    SaveFiles.save(biometricos.Firma, Constanst.BIO_FUNC_PATH + fileName);
                    funcionario.Firma = fileName;
                }

                if (!String.IsNullOrEmpty(biometricos.Huellas))
                {
                    string fileName = funcionario.Codigo + "Huella.png";
                    SaveFiles.save(biometricos.Huellas, Constanst.BIO_FUNC_PATH + fileName);
                    funcionario.HuellaImg = fileName;
                }

                await _funcionarioRepo.Update(funcionario);

                res.codigo = Constanst.ServerOkCode;
                res.data = new { message = "Biometricos guardados con éxito" };

            }catch(Exception ex)
            {
                res.codigo = Constanst.ServerErrorCode;
                res.innerError = ex.InnerException.Message;
                res.message = "Error al guardar biometricos";
            }
            return res;
        }
        #endregion

        #region Editar Biometricos
        public async Task<Response> editarBiometricos(int codFuncionario, Biometricos_Req biometricos)
        {
            Response res = new Response();
            try
            {
                string foto = "", huellas = "", firma = "";
                MdcgFuncionario funcionario = await _funcionarioRepo.GetByID(codFuncionario);

                if (!string.IsNullOrEmpty(biometricos.Foto))
                    funcionario.Fotografia = biometricos.Foto;

                if (!string.IsNullOrEmpty(biometricos.Firma))
                {
                    if (!string.IsNullOrEmpty(funcionario.Firma))
                    {
                        SaveFiles.save(biometricos.Firma, Constanst.BIO_FUNC_PATH + funcionario.Firma);
                    }
                    else
                    {
                        SaveFiles.save(biometricos.Firma, Constanst.BIO_FUNC_PATH + funcionario.Codigo + "Firma.png");
                        funcionario.Firma = funcionario.Codigo + "Firma.png";
                    }
                }

                if (!string.IsNullOrEmpty(biometricos.Huellas))
                {
                    if (!string.IsNullOrEmpty(funcionario.HuellaImg))
                    {
                        SaveFiles.save(biometricos.Huellas, Constanst.BIO_FUNC_PATH + funcionario.HuellaImg);
                    }
                    else
                    {
                        SaveFiles.save(biometricos.Huellas, Constanst.BIO_FUNC_PATH + funcionario.Codigo + "Huella.png");
                        funcionario.HuellaImg = funcionario.Codigo + "Huella.png";
                    }
                }

                await _funcionarioRepo.Update(funcionario);

                res.codigo = Constanst.ServerOkCode;
                res.data = new { message = "Biometricos editados con éxito" };

            }catch(Exception ex)
            {
                res.codigo = Constanst.ServerErrorCode;
                res.innerError = ex.InnerException.Message;
                res.message = "Error al editar biometricos del funcionario";
            }
            return res;
        }
        #endregion

        #region Get Biometricos
        public async Task<Response> getBiometricos(int codFuncionario)
        {
            Response res = new Response();
            try
            {
                string foto = "", huella = "", firma = "";

                MdcgFuncionario funcionario = await _funcionarioRepo.GetByID(codFuncionario);

                if (!String.IsNullOrEmpty(funcionario.Fotografia))
                {
                    foto = funcionario.Fotografia;
                }

                if (!String.IsNullOrEmpty(funcionario.Firma))
                {
                    Byte[] bytes = File.ReadAllBytes(Constanst.BIO_FUNC_PATH + funcionario.Firma);
                    firma = Convert.ToBase64String(bytes);
                }

                if (!String.IsNullOrEmpty(funcionario.HuellaImg))
                {
                    Byte[] bytes = File.ReadAllBytes(Constanst.BIO_FUNC_PATH + funcionario.HuellaImg);
                    huella = Convert.ToBase64String(bytes);
                }

                res.codigo = Constanst.ServerOkCode;
                res.data = new { foto = foto, firma = firma, huellas = huella };

                
            }catch(Exception ex)
            {
                res.codigo = Constanst.ServerErrorCode;
                res.innerError = ex.InnerException.Message;
                res.message = "Error al obtener biometricos del funcionario";
            }
            return res;
        }
        #endregion

    }
}
