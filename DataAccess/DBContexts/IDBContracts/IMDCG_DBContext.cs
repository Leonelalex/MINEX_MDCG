using DataAccess.Entities.Generales;
using DataAccess.Entities.MDCG_Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DataAccess.DBContexts.IDBContracts
{
    public interface IMDCG_DBContext
    {
        #region DBSET Models
        DbSet<GlobEstadoCivil> GlobEstadoCivils { get; set; }
        DbSet<GlobGenero> GlobGeneros { get; set; }
        DbSet<GlobGradoAcademico> GlobGradoAcademicos { get; set; }
        DbSet<GlobMisionesExterior> GlobMisionesExteriors { get; set; }
        DbSet<GlobPais> GlobPais { get; set; }
        DbSet<GlobTipoFuncionario> GlobTipoFuncionarios { get; set; }
        DbSet<GlobTipoPasaporte> GlobTipoPasaportes { get; set; }
        DbSet<GlobTratamiento> GlobTratamientos { get; set; }
        DbSet<MdcgAcreditaciones> MdcgAcreditaciones { get; set; }
        DbSet<MdcgAdjuntoAcreditaciones> MdcgAdjuntoAcreditaciones { get; set; }
        DbSet<MdcgBitacora> MdcgBitacoras { get; set; }
        DbSet<MdcgCargo> MdcgCargos { get; set; }
        DbSet<MdcgDependiente> MdcgDependientes { get; set; }
        DbSet<MdcgEstadosAcreditacion> MdcgEstadosAcreditacions { get; set; }
        DbSet<MdcgFirmante> MdcgFirmantes { get; set; }
        DbSet<MdcgFormatoBc> MdcgFormatoBcs { get; set; }
        DbSet<MdcgFuncionario> MdcgFuncionarios { get; set; }
        DbSet<MdcgParametro> MdcgParametros { get; set; }
        DbSet<MdcgTipoAcreditacion> MdcgTipoAcreditacions { get; set; }
        DbSet<MdcgTipoGestion> MdcgTipoGestions { get; set; }
        #endregion

        #region Properties the CONTEXT

        #region Propiedades the database
        DatabaseFacade Database { get; }
        ChangeTracker ChangeTracker { get; }
        #endregion

        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));

        //Task<int> AddRangeAsync(IEnumerable<object> entities, CancellationToken cancellationToken = default(CancellationToken));

        void AddRange(IEnumerable<object> entities);
        void RemoveRange(IEnumerable<object> entities);
        EntityEntry Update(object entity);
        EntityEntry<TEntity> Update<TEntity>(TEntity entity) where TEntity : class;

        EntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        EntityEntry Entry(object entity);
        #endregion
    }
}
