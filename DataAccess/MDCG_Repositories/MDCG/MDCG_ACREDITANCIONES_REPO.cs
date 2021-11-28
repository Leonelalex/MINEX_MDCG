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
    public class MDCG_ACREDITANCIONES_REPO : RepositoryBase<MdcgAcreditaciones>, IMDCG_ACREDITACIONES_REPO
    {
        private readonly IMDCG_DBContext _DBContext;

        public MDCG_ACREDITANCIONES_REPO(IMDCG_DBContext dbContext) : base(dbContext)
        {
            _DBContext = dbContext;
        }

        public IEnumerable<Acreditaciones_VM>  GetAcreditacionesByCodeFuncionario (int codFuncionario)
        {
            return _DBContext.MdcgAcreditaciones.Where(x => x.CodigoFuncionario == codFuncionario)
                .Select(x => new Acreditaciones_VM { 
                    Codigo = x.Codigo,
                    CodigoFuncionario = x.CodigoFuncionario,
                    Mision = x.CodigoMisionNavigation.name,
                    EsJefeMision = x.EsJefeMision ? "Si" : "No",
                    FechaBeneplacito = x.FechaBeneplacito,
                    FechaSolicitudBeneplacito = x.FechaSolicitudBeneplacito,
                    FechaPresentacionCredenciales = x.FechaPresentacionCredenciales,
                    FechaArribo = x.FechaArribo,
                    FechaTomaPosesion = x.FechaTomaPosesion,
                    NoAcreditacion = x.NoAcreditacion,
                    FechaAcreditacion = x.FechaAcreditacion,
                    FechaSalida = x.FechaSalida,
                    ViaSalida = x.ViaSalida,
                    LugarAvisoRetiro = x.LugarAvisoRetiro,
                    FechaAvisoRetiro = x.FechaAvisoRetiro,
                    NumeroCarne = x.NumeroCarne,
                    FechaVigencia = x.FechaVigencia,
                    FechaDevolucion = x.FechaDevolucion,
                    NotaDevolucion = x.NotaDevolucion,
                    Observaciones = x.Observaciones,
                    FechaImpresion = x.FechaImpresion,
                    Estado = x.EstadoNavigation.Nombre,
                    SolicitaLicencia = x.SolicitaLicencia ? "Si" : "No",
                    Tratamiento = x.CodigoTratamientoNavigation.name,
                    TipoAcreditacion = x.CodigoTipoAcreditacionNavigation.name,
                    Cargo = x.CodigoCargoNavigation.name,
                    Guia = x.Guia
                });
        }

        public AcreditacionesEdit_VM GetAcreditacionById(int codAcreditacion)
        {
            return _DBContext.MdcgAcreditaciones.Where(x => x.Codigo == codAcreditacion)
                .Select(x => new AcreditacionesEdit_VM {
                    Codigo = x.Codigo,
                    CodigoFuncionario = x.CodigoFuncionario,
                    Mision = new CodeName_obj { code = x.CodigoMision, name = x.CodigoMisionNavigation.name },
                    EsJefeMision = x.EsJefeMision,
                    FechaBeneplacito = x.FechaBeneplacito,
                    FechaSolicitudBeneplacito = x.FechaSolicitudBeneplacito,
                    FechaPresentacionCredenciales = x.FechaPresentacionCredenciales,
                    FechaArribo = x.FechaArribo,
                    FechaTomaPosesion = x.FechaTomaPosesion,
                    NoAcreditacion = x.NoAcreditacion,
                    FechaAcreditacion = x.FechaAcreditacion,
                    FechaSalida = x.FechaSalida,
                    ViaSalida = x.ViaSalida,
                    LugarAvisoRetiro = x.LugarAvisoRetiro,
                    FechaAvisoRetiro = x.FechaAvisoRetiro,
                    NumeroCarne = x.NumeroCarne,
                    FechaVigencia = x.FechaVigencia,
                    FechaDevolucion = x.FechaDevolucion,
                    NotaDevolucion = x.NotaDevolucion,
                    Observaciones = x.Observaciones,
                    FechaImpresion = x.FechaImpresion,
                    Estado = new CodeName_obj { code = x.Estado, name = x.EstadoNavigation.Descripcion },
                    SolicitaLicencia = x.SolicitaLicencia,
                    Tratamiento = new CodeName_obj { code = x.CodigoTratamiento, name = x.CodigoTratamientoNavigation.name },
                    TipoAcreditacion = new CodeName_obj { code = x.CodigoTipoAcreditacion, name = x.CodigoTipoAcreditacionNavigation.name },
                    Cargo = new CodeName_obj { code = x.CodigoCargo, name = x.CodigoCargoNavigation.name },
                    Guia = x.Guia,
                    CorrelativoProtocolo = x.CorrelativoProtocolo
                }).FirstOrDefault();
        }

        public bool AcreditacionActiva (int codFuncionario)
        {
            return _DBContext.MdcgAcreditaciones.Where(x => x.CodigoFuncionario == codFuncionario && x.Estado != 12).Any();
        }

        public IEnumerable<Acreditaciones_VM> GetBandejaRecepcion()
        {
            return _DBContext.MdcgAcreditaciones.Where(x => x.Estado == 13).Select(x => new Acreditaciones_VM
            {
                Codigo = x.Codigo,
                CodigoFuncionario = x.CodigoFuncionario,
                Mision = x.CodigoMisionNavigation.name,
                EsJefeMision = x.EsJefeMision ? "Si" : "No",
                FechaBeneplacito = x.FechaBeneplacito,
                FechaSolicitudBeneplacito = x.FechaSolicitudBeneplacito,
                FechaPresentacionCredenciales = x.FechaPresentacionCredenciales,
                FechaArribo = x.FechaArribo,
                FechaTomaPosesion = x.FechaTomaPosesion,
                NoAcreditacion = x.NoAcreditacion,
                FechaAcreditacion = x.FechaAcreditacion,
                FechaSalida = x.FechaSalida,
                ViaSalida = x.ViaSalida,
                LugarAvisoRetiro = x.LugarAvisoRetiro,
                FechaAvisoRetiro = x.FechaAvisoRetiro,
                NumeroCarne = x.NumeroCarne,
                FechaVigencia = x.FechaVigencia,
                FechaDevolucion = x.FechaDevolucion,
                NotaDevolucion = x.NotaDevolucion,
                Observaciones = x.Observaciones,
                FechaImpresion = x.FechaImpresion,
                Estado = x.EstadoNavigation.Nombre,
                SolicitaLicencia = x.SolicitaLicencia ? "Si" : "No",
                Tratamiento = x.CodigoTratamientoNavigation.name,
                TipoAcreditacion = x.CodigoTipoAcreditacionNavigation.name,
                Cargo = x.CodigoCargoNavigation.name,
                Guia = x.Guia,
                CorrelativoProtocolo = x.CorrelativoProtocolo
            });
        }
    }
}
