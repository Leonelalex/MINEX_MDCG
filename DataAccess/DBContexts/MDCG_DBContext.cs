using DataAccess.DBContexts.IDBContracts;
using DataAccess.Entities.Generales;
using DataAccess.Entities.MDCG_Entities;
using DataAccess.EntitiesConfig.General;
using DataAccess.EntitiesConfig.MDCG_EntitiesConfig;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace DataAccess.DBContexts
{
    public partial class MDCG_DBContext : DbContext, IMDCG_DBContext
    {

        #region Constructor
        public MDCG_DBContext()
        {
        }

        //Injection the conection string
        public MDCG_DBContext(DbContextOptions<MDCG_DBContext> options) : base(options)
        {
        }
        #endregion

        #region DBSET Models
        public virtual DbSet<GlobEstadoCivil> GlobEstadoCivils { get; set; }
        public virtual DbSet<GlobGenero> GlobGeneros { get; set; }
        public virtual DbSet<GlobGradoAcademico> GlobGradoAcademicos { get; set; }
        public virtual DbSet<GlobMisionesExterior> GlobMisionesExteriors { get; set; }
        public virtual DbSet<GlobPais> GlobPais { get; set; }
        public virtual DbSet<GlobTipoFuncionario> GlobTipoFuncionarios { get; set; }
        public virtual DbSet<GlobTipoPasaporte> GlobTipoPasaportes { get; set; }
        public virtual DbSet<GlobTratamiento> GlobTratamientos { get; set; }
        public virtual DbSet<GlobtipoLicencia> GlobTipoLicencia { get; set; }
        public virtual DbSet<GlobParentesco> MdcgParentesco { get; set; }
        public virtual DbSet<MdcgAcreditaciones> MdcgAcreditaciones { get; set; }
        public virtual DbSet<MdcgAdjuntoAcreditaciones> MdcgAdjuntoAcreditaciones { get; set; }
        public virtual DbSet<MdcgBitacora> MdcgBitacoras { get; set; }
        public virtual DbSet<MdcgCargo> MdcgCargos { get; set; }
        public virtual DbSet<MdcgDependiente> MdcgDependientes { get; set; }
        public virtual DbSet<MdcgEstadosAcreditacion> MdcgEstadosAcreditacions { get; set; }
        public virtual DbSet<MdcgFirmante> MdcgFirmantes { get; set; }
        public virtual DbSet<MdcgFormatoBc> MdcgFormatoBcs { get; set; }
        public virtual DbSet<MdcgFuncionario> MdcgFuncionarios { get; set; }
        public virtual DbSet<MdcgParametro> MdcgParametros { get; set; }
        public virtual DbSet<MdcgTipoAcreditacion> MdcgTipoAcreditacions { get; set; }
        public virtual DbSet<MdcgTipoGestion> MdcgTipoGestions { get; set; }
        #endregion

        #region Configuration the dbContext for database
        //Configuration the dbContext
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.EnableSensitiveDataLogging();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
             modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");
            // ----------------------------------------------------------------------------------------------------

            //******* GLOB Models ********//
            GlobEstadoCivilConfig.SetEntityBuilder(modelBuilder.Entity<GlobEstadoCivil>());
            GlobGeneroConfig.SetEntityBuilder(modelBuilder.Entity<GlobGenero>());
            GlobGradoAcademicoConfig.SetEntityBuilder(modelBuilder.Entity<GlobGradoAcademico>());
            GlobMisionesExteriorConfig.SetEntityBuilder(modelBuilder.Entity<GlobMisionesExterior>());
            GlobPaisConfig.SetEntityBuilder(modelBuilder.Entity<GlobPais>());
            GlobTipoFuncionarioConfig.SetEntityBuilder(modelBuilder.Entity<GlobTipoFuncionario>());
            GlobTipoPasaporteConfig.SetEntityBuilder(modelBuilder.Entity<GlobTipoPasaporte>());
            GlobTratamientoConfig.SetEntityBuilder(modelBuilder.Entity<GlobTratamiento>());
            GlobTipoLicenciaConfig.SetEntityBuilder(modelBuilder.Entity<GlobtipoLicencia>());
            GlobParentescoConfig.SetEntityBuilder(modelBuilder.Entity<GlobParentesco>());

            //******* MDCG Models ********//
            MdcgAcreditacionesConfig.SetEntityBuilder(modelBuilder.Entity<MdcgAcreditaciones>());
            MdcgAdjuntoAcreditacioneConfig.SetEntityBuilder(modelBuilder.Entity<MdcgAdjuntoAcreditaciones>());
            MdcgBitacoraConfig.SetEntityBuilder(modelBuilder.Entity<MdcgBitacora>());
            MdcgCargoConfig.SetEntityBuilder(modelBuilder.Entity<MdcgCargo>());
            MdcgDependienteConfig.SetEntityBuilder(modelBuilder.Entity<MdcgDependiente>());
            MdcgEstadosAcreditacionConfig.SetEntityBuilder(modelBuilder.Entity<MdcgEstadosAcreditacion>());
            MdcgFirmanteConfig.SetEntityBuilder(modelBuilder.Entity<MdcgFirmante>());
            MdcgFormatoBcConfig.SetEntityBuilder(modelBuilder.Entity<MdcgFormatoBc>());
            MdcgFuncionarioConfig.SetEntityBuilder(modelBuilder.Entity<MdcgFuncionario>());
            MdcgParametroConfig.SetEntityBuilder(modelBuilder.Entity<MdcgParametro>());
            MdcgTipoAcreditacionConfig.SetEntityBuilder(modelBuilder.Entity<MdcgTipoAcreditacion>());
            MdcgTipoGestionConfig.SetEntityBuilder(modelBuilder.Entity<MdcgTipoGestion>());

            base.OnModelCreating(modelBuilder);
        }

        //Configuration the savechanges for audit columns
        public override int SaveChanges()
        {
            //ProcessSave();
            return base.SaveChanges();
        }

        //Configuration the SaveChangesAsync for audit columns
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
           // ProcessSave();
            return base.SaveChangesAsync(cancellationToken);
        }

        #endregion


    }
}
