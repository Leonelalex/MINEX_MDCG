using AutoMapper;
using Core.ServiceApp.Requests;
using Core.ServiceApp.Services.ServicesContracts;
using Core.ServiceApp.Utils;
using DataAccess.Entities.MDCG_Entities;
using DataAccess.MDCG_Repositories.MDCG_RepositoriesContracts.MDCG;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Core.ServiceApp.Services
{
    public class Dependientes_Service : IDependientes_Service
    {
        private readonly IMDCG_DEPENDIENTES_REPO _dependientesRepo;
        private readonly IMCDG_FUNCIONARIO_REPO _funcionarioRepo;
        private readonly IMDCG_ACREDITACIONES_REPO _acreditacionesRepo;
        private readonly IMapper _mapper;

        public Dependientes_Service(IMapper mapper, IMDCG_DEPENDIENTES_REPO dependientesRepo, IMCDG_FUNCIONARIO_REPO funcionarioRepo, IMDCG_ACREDITACIONES_REPO acreditacionesRepo)
        {
            _mapper = mapper;
            _dependientesRepo = dependientesRepo;
            _funcionarioRepo = funcionarioRepo;
            _acreditacionesRepo = acreditacionesRepo;
        }

        #region Crear Dependiente
        public async Task<Response> crearDependiente(Dependientes_Req dependiente, int codFuncionario)
        {
            Response res = new Response();
            try
            {
                MdcgDependiente newDependiente = _mapper.Map<MdcgDependiente>(dependiente);

                newDependiente.CodigoFuncionario = codFuncionario;
                newDependiente.Acreditado = false;
                newDependiente.Estado = true;
                newDependiente.EstadoAcreditacion = 16;

                await _dependientesRepo.Add(newDependiente);

                res.codigo = Constanst.ServerOkCode;
                res.data = new { codigoDependiente = newDependiente.Codigo, message = "Dependiente creado con éxito" };

            }catch(Exception ex)
            {
                res.codigo = Constanst.ServerErrorCode;
                res.innerError = ex.InnerException.Message;
                res.message = "Error al intentar crear el dependiente";
            }
            return res;
        }
        #endregion

        #region Get Dependientes Funcionario
        public async Task<Response> getDependientes(int codFuncionario) {
            Response res = new Response();
            try
            {
                IEnumerable<Dependientes_VM> dependientes = _dependientesRepo.getDependienteByCodFuncionario(codFuncionario);

                res.codigo = Constanst.ServerOkCode;
                res.data = dependientes;
            }
            catch (Exception ex)
            {
                res.codigo = Constanst.ServerErrorCode;
                res.innerError = ex.InnerException.Message;
                res.message = "Error al intentar obtener dependientes";
            }
            return res;
        }
        #endregion

        #region Get Dependiente
        public async Task<Response> getDependienteById(int codDependiente)
        {
            Response res = new Response();
            try
            {
               
                DependientesEdit_VM dependiente = _dependientesRepo.getDependienteById(codDependiente);

                res.codigo = Constanst.ServerOkCode;
                res.data = dependiente;

            }catch(Exception ex)
            {
                res.codigo = Constanst.ServerErrorCode;
                res.innerError = ex.InnerException.Message;
                res.message = "Error al intentar obtener el dependiente";
            }
            return res;
        }
        #endregion

        #region Edit Dependiente
        public async Task<Response> editDependiente(int codDependiente, DependienteEdit_Req depInfo)
        {
            Response res = new Response();
            try
            {
                MdcgDependiente dependiente = await _dependientesRepo.GetByID(codDependiente);
                _mapper.Map(depInfo, dependiente);

                await _dependientesRepo.Update(dependiente);

                res.codigo = Constanst.ServerOkCode;
                res.data = new { code = Constanst.ServerOkCode, message = "Dependiente editado con éxito" };

            }
            catch (Exception ex)
            {
                res.codigo = Constanst.ServerErrorCode;
                res.innerError = ex.InnerException.Message;
                res.message = "Error al intentar editar el dependiente";
            }
            return res;
        }
        #endregion

        #region Guardar Biometricos
        public async Task<Response> GuardarBiometricos(int codDependiente, Biometricos_Req biometricos)
        {
            Response res = new Response();
            try
            {
                MdcgDependiente dependiente = await _dependientesRepo.GetByID(codDependiente);

                if (!string.IsNullOrEmpty(biometricos.Foto))
                    dependiente.Fotografia = biometricos.Foto;

                if (!string.IsNullOrEmpty(biometricos.Firma))
                {
                    SaveFiles.save(biometricos.Firma, Constanst.BIO_DEP_PATH + dependiente.Codigo + "Firma.png");
                    dependiente.Firma = dependiente.Codigo + "Firma.png";
                }

                if (!string.IsNullOrEmpty(biometricos.Huellas))
                {
                    SaveFiles.save(biometricos.Huellas, Constanst.BIO_DEP_PATH + dependiente.Codigo + "Huella.png");
                    dependiente.HuellaImg = dependiente.Codigo + "Huella.png";
                }

                await _dependientesRepo.Update(dependiente);

                res.codigo = Constanst.ServerOkCode;
                res.data = new { message = "Biometricos guardados con éxito" };
            }
            catch(Exception ex)
            {
                res.codigo = Constanst.ServerErrorCode;
                res.innerError = ex.InnerException.Message;
                res.message = "Error al guardar biometricos";
            }
            return res;
        }
        #endregion

        #region Get Biometricos
        public async Task<Response> getBiometricos(int codDependiente)
        {
            Response res = new Response();
            try
            {
                string foto = "", huella = "", firma = "";

                MdcgDependiente dependiente = await _dependientesRepo.GetByID(codDependiente);

                if (!String.IsNullOrEmpty(dependiente.Fotografia))
                {
                    foto = dependiente.Fotografia;
                }

                if (!String.IsNullOrEmpty(dependiente.Firma))
                {
                    Byte[] bytes = File.ReadAllBytes(Constanst.BIO_DEP_PATH + dependiente.Firma);
                    firma = Convert.ToBase64String(bytes);
                }

                if (!String.IsNullOrEmpty(dependiente.HuellaImg))
                {
                    Byte[] bytes = File.ReadAllBytes(Constanst.BIO_DEP_PATH + dependiente.HuellaImg);
                    huella = Convert.ToBase64String(bytes);
                }

                res.codigo = Constanst.ServerOkCode;
                res.data = new { foto = foto, firma = firma, huellas = huella };


            }
            catch (Exception ex)
            {
                res.codigo = Constanst.ServerErrorCode;
                res.innerError = ex.InnerException.Message;
                res.message = "Error al obtener biometricos del dependiente";
            }
            return res;
        }
        #endregion

        #region Editar Biometricos
        public async Task<Response> editarBiometricos(int codDependiente, Biometricos_Req biometricos)
        {
            Response res = new Response();
            try
            {
                string foto = "", huellas = "", firma = "";
                MdcgDependiente dependiente = await _dependientesRepo.GetByID(codDependiente);

                if (!string.IsNullOrEmpty(biometricos.Foto))
                    dependiente.Fotografia = biometricos.Foto;

                if (!string.IsNullOrEmpty(biometricos.Firma))
                {
                    if (!string.IsNullOrEmpty(dependiente.Firma))
                    {
                        SaveFiles.save(biometricos.Firma, Constanst.BIO_DEP_PATH + dependiente.Firma);
                    }
                    else
                    {
                        SaveFiles.save(biometricos.Firma, Constanst.BIO_DEP_PATH + dependiente.Codigo + "Firma.png");
                        dependiente.Firma = dependiente.Codigo + "Firma.png";
                    }
                }

                if (!string.IsNullOrEmpty(biometricos.Huellas))
                {
                    if (!string.IsNullOrEmpty(dependiente.HuellaImg))
                    {
                        SaveFiles.save(biometricos.Huellas, Constanst.BIO_DEP_PATH + dependiente.HuellaImg);
                    }
                    else
                    {
                        SaveFiles.save(biometricos.Huellas, Constanst.BIO_DEP_PATH + dependiente.Codigo + "Huella.png");
                        dependiente.HuellaImg = dependiente.Codigo + "Huella.png";
                    }
                }

                await _dependientesRepo.Update(dependiente);

                res.codigo = Constanst.ServerOkCode;
                res.data = new { message = "Biometricos editados con éxito" };

            }
            catch (Exception ex)
            {
                res.codigo = Constanst.ServerErrorCode;
                res.innerError = ex.InnerException.Message;
                res.message = "Error al editar biometricos del dependiente";
            }
            return res;
        }
        #endregion
    }
}
