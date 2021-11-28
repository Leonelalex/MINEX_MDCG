using AutoMapper;
using Core.ServiceApp.Responses;
using Core.ServiceApp.Services.ServicesContracts;
using Core.ServiceApp.Utils;
using DataAccess.Entities.Generales;
using DataAccess.MDCG_Repositories.MDCG_RepositoriesContracts.GLOB;
using DataAccess.MDCG_Repositories.MDCG_RepositoriesContracts.MDCG;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.ServiceApp.Services
{
    public class Catalogos_Service : ICatalogos_Service
    {
        private readonly IMapper _mapper;
        private readonly IGLOB_GENERO_REPO _generoRepo;
        private readonly IGLOB_ESTADO_CIVIL_REPO _estadoCivilRepo;
        private readonly IGLOB_PAIS_REPO _paisRepo;
        private readonly IGLOB_TIPO_PASAPORTE_REPO _tipoPasaporte;
        private readonly IGLOB_TIPO_FUNCIONARIO_REPO _tipoFuncionarioRepo;
        private readonly IGLOB_GRADO_ACADEMICO _gradoAcademicoRepo;
        private readonly IGLOB_TIPO_LICENCIA_REPO _tipoLicenciaRepo;
        private readonly IGLOB_PARENTESCO_REPO _parentescoRepo;
        private readonly IGLOB_MISIONES_ESTERIOR_REPO _misionesRepo;
        private readonly IMDCG_TIPO_ACREDITACION_REPO _tipoAcreditacionesRepo;
        private readonly IGLOB_TRATAMIENTO_REPO _tratamientoRepo;
        private readonly IMDCG_CARGO_REPO _cargoRepo;

        public Catalogos_Service(IMapper mapper, IGLOB_GENERO_REPO generoRepo, IGLOB_ESTADO_CIVIL_REPO estadoCivilRepo, IGLOB_PAIS_REPO paisRepo,
            IGLOB_TIPO_PASAPORTE_REPO tipoPasaporte, IGLOB_TIPO_FUNCIONARIO_REPO tipoFuncionarioRepo, IGLOB_GRADO_ACADEMICO gradoAcademicoRepo,
            IGLOB_TIPO_LICENCIA_REPO tipoLicenciaRepo, IGLOB_PARENTESCO_REPO parentescoRepo, IGLOB_MISIONES_ESTERIOR_REPO misionesRepo,
            IMDCG_TIPO_ACREDITACION_REPO tipoAcreditacionesRepo, IGLOB_TRATAMIENTO_REPO tratamientoRepo, IMDCG_CARGO_REPO cargoRepo)
        {
            _mapper = mapper;
            _generoRepo = generoRepo;
            _estadoCivilRepo = estadoCivilRepo;
            _paisRepo = paisRepo;
            _tipoPasaporte = tipoPasaporte;
            _tipoFuncionarioRepo = tipoFuncionarioRepo;
            _gradoAcademicoRepo = gradoAcademicoRepo;
            _tipoLicenciaRepo = tipoLicenciaRepo;
            _parentescoRepo = parentescoRepo;
            _misionesRepo = misionesRepo;
            _tipoAcreditacionesRepo = tipoAcreditacionesRepo;
            _tratamientoRepo = tratamientoRepo;
            _cargoRepo = cargoRepo;
        }

        #region Catalogo Formulario de Funcionario
        public async Task<Response> getFuncionariosCatalogos()
        {
            Response res = new Response();
            try
            {
                CatalogosFuncionarios catalogo = new CatalogosFuncionarios();
                catalogo.genero = _mapper.Map<IEnumerable<GenericCatalog>>(await _generoRepo.GetAll());
                catalogo.estadoCivil = _mapper.Map<IEnumerable<GenericCatalog>>(await _estadoCivilRepo.GetAll());
                catalogo.pais = _mapper.Map<IEnumerable<GenericCatalog>>(await _paisRepo.GetAll());
                catalogo.tipoPasaporte = _mapper.Map<IEnumerable<GenericCatalog>>(await _tipoPasaporte.GetAll());
                catalogo.tipoFuncionario = _mapper.Map<IEnumerable<GenericCatalog>>(await _tipoFuncionarioRepo.GetAll());
                catalogo.gradoAcademico = _mapper.Map<IEnumerable<GenericCatalog>>(await _gradoAcademicoRepo.GetAll());
                catalogo.tipoLicencia = _mapper.Map<IEnumerable<GenericCatalog>>(await _tipoLicenciaRepo.GetAll());


                res.codigo = Constanst.ServerOkCode;
                res.data = catalogo;

            }catch(Exception ex)
            {
                res.codigo = Constanst.ServerErrorCode;
                res.innerError = ex.InnerException.Message;
                res.message = "Error al obtener catalogos del formulario de funcionarios";
            }
            return res;
        }
        #endregion

        #region Catalogo Formulario de Dependiente
        public async Task<Response> getDependientesCatalogos()
        {
            Response res = new Response();
            try
            {
                CatalogoDependientes catalogos = new CatalogoDependientes();
                catalogos.pais = _mapper.Map<IEnumerable<GenericCatalog>>(await _paisRepo.GetAll());
                catalogos.parentescos = _mapper.Map<IEnumerable<GenericCatalog>>(await _parentescoRepo.GetAll());
                catalogos.tipoPasaporte = _mapper.Map<IEnumerable<GenericCatalog>>(await _tipoPasaporte.GetAll());
                catalogos.tipoLicencia = _mapper.Map<IEnumerable<GenericCatalog>>(await _tipoLicenciaRepo.GetAll());
                catalogos.genero = _mapper.Map<IEnumerable<GenericCatalog>>(await _generoRepo.GetAll());

                res.codigo = Constanst.ServerOkCode;
                res.data = catalogos;

            }catch(Exception ex)
            {
                res.codigo = Constanst.ServerErrorCode;
                res.innerError = ex.InnerException.Message;
                res.message = "Error al obtener catalogos del formulario de dependientes";
            }
            return res;
        }
        #endregion

        #region Catalogo Formulario de Acreditaciones
        public async Task<Response> getAcreditacionesCatalogos()
        {
            Response res = new Response();
            try
            {
                CatalogoAcreditaciones catalogos = new CatalogoAcreditaciones();
                catalogos.pais = _mapper.Map<IEnumerable<GenericCatalog>>(await _paisRepo.GetAll());
                catalogos.mision = _mapper.Map<IEnumerable<MisionCatalog>>(await _misionesRepo.GetAll());
                catalogos.tipoAcreditacion = _mapper.Map<IEnumerable<GenericCatalog>>(await _tipoAcreditacionesRepo.GetAll());
                catalogos.tratamiento = _mapper.Map<IEnumerable<GenericCatalog>>(await _tratamientoRepo.GetAll());
                catalogos.cargo = _mapper.Map<IEnumerable<GenericCatalog>>(await _cargoRepo.GetAll());

                res.codigo = 200;
                res.data = catalogos;
            }
            catch (Exception ex)
            {
                res.codigo = Constanst.ServerErrorCode;
                res.innerError = ex.InnerException.Message;
                res.message = "Error al obtener catalogos del formulario de acreditaciones";
            }
            return res;
        }
        #endregion
    }
}
