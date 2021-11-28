using DataAccess.DBContexts.IDBContracts;
using DataAccess.Entities.MDCG_Entities;
using DataAccess.Helpers;
using DataAccess.MDCG_Repositories.MDCG_RepositoriesContracts.MDCG;
using DataAccess.RepositoryBase;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.MDCG_Repositories.MDCG
{
    public class MDCG_DEPENDIENTES_REPO : RepositoryBase<MdcgDependiente>, IMDCG_DEPENDIENTES_REPO
    {
        private readonly IMDCG_DBContext _DBContext;

        public MDCG_DEPENDIENTES_REPO(IMDCG_DBContext dbContext) : base(dbContext)
        {
            _DBContext = dbContext;
        }

        public IEnumerable<Dependientes_VM> getDependienteByCodFuncionario (int codFuncionario)
        {
            IEnumerable<Dependientes_VM> dependientes = _DBContext.MdcgDependientes.Where(x => x.CodigoFuncionario == codFuncionario && x.Estado == true)
                .Select(x => new Dependientes_VM { 
                    Codigo = x.Codigo,
                    CodigoFuncionario = x.CodigoFuncionario,
                    PaisOrigen = x.PaisOrigenNavigation.name,
                    Nombres = x.Nombres,
                    Apellidos = x.Apellidos,
                    ApellidoCasada = x.ApellidoCasada,
                    FechaNacimiento = x.FechaNacimiento,
                    LugarNacimiento = x.LugarNacimiento,
                    FechaVigencia = x.FechaVigencia,
                    NumeroCarne = x.NumeroCarne,
                    FechaDevolucion = x.FechaDevolucion,
                    NotaDevolucion = x.NotaDevolucion,
                    Parentesco = x.CodigoParentescoNavigation.name,
                    FechaAcreditacion = x.FechaAcreditacion,
                    NumeroPasaporte = x.NumeroPasaporte,
                    TipoPasaporte = x.CodigoTipoPasaporteNavigation.name,
                    TipoLicencia = x.CodigoTipoLicenciaNavigation.name,
                    Genero = x.CodigoGeneroNavigation.name,
                    Acreditado = x.Acreditado
                });

            return dependientes;
        }

        public DependientesEdit_VM getDependienteById (int codDependiente)
        {
            DependientesEdit_VM dependiente = _DBContext.MdcgDependientes.Where(x => x.Codigo == codDependiente && x.Estado == true)
                .Select(x => new DependientesEdit_VM {
                    CodigoFuncionario = x.CodigoFuncionario,
                    PaisOrigen = new CodeName_obj { code = x.PaisOrigen, name = x.PaisOrigenNavigation.name},
                    Nombres = x.Nombres,
                    Apellidos = x.Apellidos,
                    ApellidoCasada = x.ApellidoCasada,
                    FechaNacimiento = x.FechaNacimiento,
                    LugarNacimiento = x.LugarNacimiento,
                    FechaVigencia = x.FechaVigencia,
                    NumeroCarne = x.NumeroCarne,
                    FechaDevolucion = x.FechaDevolucion,
                    NotaDevolucion = x.NotaDevolucion,
                    Parentesco = new CodeName_obj { code = x.CodigoParentesco, name = x.CodigoParentescoNavigation.name },
                    FechaAcreditacion = x.FechaAcreditacion,
                    NumeroPasaporte = x.NumeroPasaporte,
                    TipoPasaporte = new CodeName_obj { code = x.CodigoTipoPasaporte, name = x.CodigoTipoPasaporteNavigation.name },
                    NumeroLicencia = x.NumeroLicencia,
                    TipoLicencia = new CodeName_obj { code = x.CodigoTipoLicencia, name = x.CodigoTipoLicenciaNavigation.name },
                    NoAcreditacion = x.NoAcreditacion,
                    Genero = new CodeName_obj { code = x.CodigoGenero, name = x.CodigoGeneroNavigation.name },
                    Acreditado = x.Acreditado,
                    Fotografia = x.Fotografia,
                    FechaVencimientoPasaporte = x.FechaVencimientoPasaporte,
                    FechaVencimientoLicencia = x.FechaVencimientoLicencia
                }).FirstOrDefault();

            return dependiente;
        }
    }
}
