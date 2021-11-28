using AutoMapper;
using Core.ServiceApp.Requests;
using Core.ServiceApp.Services.ServicesContracts;
using Core.ServiceApp.Utils;
using DataAccess.Entities.Generales;
using DataAccess.Entities.MDCG_Entities;
using DataAccess.MDCG_Repositories.MDCG_RepositoriesContracts.GLOB;
using DataAccess.MDCG_Repositories.MDCG_RepositoriesContracts.MDCG;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.ServiceApp.Services
{
    public class Acreditaciones_Service : IAcreditaciones_Service
    {
        private readonly IMapper _mapper;
        private readonly IMDCG_ACREDITACIONES_REPO _acreditacionesRepo;
        private readonly IGLOB_MISIONES_ESTERIOR_REPO _misionesRepo;

        public Acreditaciones_Service(IMapper mapper, IMDCG_ACREDITACIONES_REPO acreditacionesRepo, IGLOB_MISIONES_ESTERIOR_REPO misionesRepo)
        {
            _mapper = mapper;
            _acreditacionesRepo = acreditacionesRepo;
            _misionesRepo = misionesRepo;
        }

        #region Crear Acreditacion
        public async Task<Response> CrearAcreditacion(Acreditacion_Req acreditacion, int codFucnionario)
        {
            Response res = new Response();
            try
            {

                if (!_acreditacionesRepo.AcreditacionActiva(codFucnionario))
                {

                    MdcgAcreditaciones newacreditacion = _mapper.Map<MdcgAcreditaciones>(acreditacion);
                    newacreditacion.CodigoFuncionario = codFucnionario;
                    newacreditacion.Estado = 13;
                    newacreditacion.NoAcreditacion = "XXXX-2021";

                    await _acreditacionesRepo.Add(newacreditacion);

                    res.codigo = Constanst.ServerOkCode;
                    res.data = new { codeAcreditacion = newacreditacion.Codigo, message = "Acreditacion creada con exito" };
                }
                else
                {
                    res.codigo = Constanst.ServerErrorCode;
                    res.message = "El funcionario tiene una acreditación activa o en aprobación";
                }
            }
            catch(Exception ex)
            {
                res.codigo = Constanst.ServerErrorCode;
                res.innerError = ex.InnerException.Message;
                res.message = "Error al intentar crear la acreditación";
            }
            return res;
        }
        #endregion

        #region Get Acreditaciondes Funcionario
        public async Task<Response> GetAcreditacionesFuncionario(int codFuncionario)
        {
            Response res = new Response();
            try
            {
                IEnumerable<Acreditaciones_VM> acreditaciones = _acreditacionesRepo.GetAcreditacionesByCodeFuncionario(codFuncionario);

                res.codigo = Constanst.ServerOkCode;
                res.data = acreditaciones;
            }
            catch (Exception ex)
            {
                res.codigo = Constanst.ServerErrorCode;
                res.innerError = ex.InnerException.Message;
                res.message = "Error al intentar obtener acreditaciones";
            }
            return res;
        }
        #endregion

        #region Get Acreditacion
        public async Task<Response> GetAcreditacion(int codAcreditacion)
        {
            Response res = new Response();
            try
            {
                AcreditacionesEdit_VM acreditacion = _acreditacionesRepo.GetAcreditacionById(codAcreditacion);
                GlobMisionesExterior mision = await _misionesRepo.GetByID(acreditacion.Mision.code ?? default(int));

                acreditacion.codigoPais = mision.CodigoPais;

                res.codigo = Constanst.ServerOkCode;
                res.data = acreditacion;
            }
            catch (Exception ex)
            {
                res.codigo = Constanst.ServerErrorCode;
                res.innerError = ex.InnerException.Message;
                res.message = "Error al intentar obtener la acreditacion";
            }
            return res;
        }
        #endregion

        #region Editar Acreditacion
        public async Task<Response> EditarAcreditacion(int codAcreditacion, AcreditacionEdit_Req acreInfo)
        {
            Response res = new Response();
            try
            {
                MdcgAcreditaciones acreditacion = await _acreditacionesRepo.GetByID(codAcreditacion);
                _mapper.Map(acreInfo, acreditacion);

                await _acreditacionesRepo.Update(acreditacion);

                res.codigo = Constanst.ServerOkCode;
                res.data = new { message = "Acreditación editada con éxito" };
            }
            catch (Exception ex)
            {
                res.codigo = Constanst.ServerErrorCode;
                res.innerError = ex.InnerException.Message;
                res.message = "Error al intentar obtener la acreditacion";
            }
            return res;
        }
        #endregion
    }
}
