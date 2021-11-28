
using DataAccess.DBContexts.IDBContracts;
using DataAccess.Entities.MDCG_Entities;
using DataAccess.Helpers;
using DataAccess.MDCG_Repositories.MDCG_RepositoriesContracts.MDCG;
using DataAccess.RepositoryBase;
using DataAccess.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.MDCG_Repositories.MDCG
{
    public class MCDG_FUNCIONARIO_REPO : RepositoryBase<MdcgFuncionario>, IMCDG_FUNCIONARIO_REPO
    {
        private readonly IMDCG_DBContext _DBContext;

        public MCDG_FUNCIONARIO_REPO(IMDCG_DBContext dbContext) : base(dbContext)
        {
            _DBContext = dbContext;
        }

        public IEnumerable<Funcionarios_VM> getAllFuncionarios()
        {
            return _DBContext.MdcgFuncionarios.Where(x => x.Estado == true)
                .Select(x => new Funcionarios_VM
                {
                    Codigo = x.Codigo,
                    Nombres = x.Nombres,
                    Apellidos = x.Apellidos,
                    Genero = x.CodigoGeneroNavigation.name,
                    FechaNacimiento = x.FechaNacimiento,
                    PaisOrigen = x.PaisOrigenNavigation.name,
                    CorreoElectronico = x.CorreoElectronico,
                    OtrosMediosComunicacion = x.OtrosMediosComunicacion,
                    ApellidoCasada = x.ApellidoCasada,
                    LugarNacimiento = x.LugarNacimiento,
                    TipoPasaporte = x.CodigoTipoPasaporteNavigation.name,
                    NumeroPasaporte = x.NumeroPasaporte,
                    GradoAcademico = x.CodigoGradoAcademicoNavigation.name,
                    DireccionParticular = x.DireccionParticular,
                    TelefonoParticular = x.TelefonoParticular,
                    EstadoCivil = x.CodigoEstadoCivilNavigation.name,
                    NumeroLicencia = x.NumeroLicencia,
                    TipoLicencia = x.CodigoTipoLicenciaNavigation.name,
                    NacionalidadAdquirida = x.NacionalidadAdquiridaNavigation.Nacionalidad,
                    Acreditado = x.Acreditado,
                    FechaRegistro = x.FechaRegistro,
                    FechaVencimientoPasaporte = x.FechaVencimientoPasaporte,
                    FechaVencimientoLicencia = x.FechaVencimientoLicencia
                }).OrderByDescending(x => x.FechaRegistro);
        }

        public IEnumerable<Funcionarios_VM> getFuncionarios (PaginationFilter filter)
        {
            return  _DBContext.MdcgFuncionarios.Where(x => x.Estado == true)
                .Select(x => new Funcionarios_VM
                {
                    Codigo = x.Codigo,
                    Nombres = x.Nombres,
                    Apellidos = x.Apellidos,
                    Genero = x.CodigoGeneroNavigation.name,
                    FechaNacimiento = x.FechaNacimiento,
                    PaisOrigen = x.PaisOrigenNavigation.name,
                    CorreoElectronico = x.CorreoElectronico,
                    OtrosMediosComunicacion = x.OtrosMediosComunicacion,
                    ApellidoCasada = x.ApellidoCasada,
                    LugarNacimiento = x.LugarNacimiento,
                    TipoPasaporte = x.CodigoTipoPasaporteNavigation.name,
                    NumeroPasaporte = x.NumeroPasaporte,
                    GradoAcademico  = x.CodigoGradoAcademicoNavigation.name,
                    DireccionParticular = x.DireccionParticular,
                    TelefonoParticular = x.TelefonoParticular,
                    EstadoCivil = x.CodigoEstadoCivilNavigation.name,
                    NumeroLicencia = x.NumeroLicencia,
                    TipoLicencia = x.CodigoTipoLicenciaNavigation.name,
                    NacionalidadAdquirida = x.NacionalidadAdquiridaNavigation.Nacionalidad,
                    Acreditado = x.Acreditado,
                    FechaRegistro = x.FechaRegistro,
                    FechaVencimientoPasaporte = x.FechaVencimientoPasaporte,
                    FechaVencimientoLicencia = x.FechaVencimientoLicencia
                })
                .OrderByDescending(x => x.FechaRegistro)
                .Skip((filter.PageNumber - 1) * filter.PageSize).Take(filter.PageSize);
        }

        public int countFuncionarios()
        {
            return _DBContext.MdcgFuncionarios.Where(x => x.Estado == true).Count();
        }

        public FuncionarioEdit_VM getFuncionarioById(int id)
        {
            return _DBContext.MdcgFuncionarios.Where(x => x.Estado == true && x.Codigo == id)
                .Select(x => new FuncionarioEdit_VM {
                    Codigo = x.Codigo,
                    Nombres = x.Nombres,
                    Apellidos = x.Apellidos,
                    Genero = new CodeName_obj { code = x.Genero,  name = x.CodigoGeneroNavigation.name},
                    FechaNacimiento = x.FechaNacimiento,
                    PaisOrigen = new CodeName_obj { code = x.PaisOrigen, name = x.PaisOrigenNavigation.name },
                    CorreoElectronico = x.CorreoElectronico,
                    OtrosMediosComunicacion = x.OtrosMediosComunicacion,
                    ApellidoCasada = x.ApellidoCasada,
                    LugarNacimiento = x.LugarNacimiento,
                    TipoPasaporte = new CodeName_obj { code = x.CodigoTipoPasaporte, name = x.CodigoTipoPasaporteNavigation.name },
                    NumeroPasaporte = x.NumeroPasaporte,
                    GradoAcademico = new CodeName_obj { code = x.CodigoGradoAcademico, name = x.CodigoGradoAcademicoNavigation.name },
                    DireccionParticular = x.DireccionParticular,
                    TelefonoParticular = x.TelefonoParticular,
                    EstadoCivil = new CodeName_obj { code = x.CodigoEstadoCivil, name = x.CodigoEstadoCivilNavigation.name },
                    NumeroLicencia = x.NumeroLicencia,
                    TipoLicencia = new CodeName_obj { code = x.TipoLicencia, name = x.CodigoTipoLicenciaNavigation.name },
                    NacionalidadAdquirida = new CodeName_obj { code = x.NacionalidadAdquirida, name = x.NacionalidadAdquiridaNavigation.name },
                    TipoFuncionario = new CodeName_obj { code = x.CodigoTipoFuncionario, name = x.CodigoTipoFuncionarioNavigation.name },
                    Acreditado = x.Acreditado,
                    Fotografia = x.Fotografia,
                    FechaVencimientoPasaporte = x.FechaVencimientoPasaporte,
                    FechaVencimientoLicencia = x.FechaVencimientoLicencia
                }).FirstOrDefault();
        }
    }
}
