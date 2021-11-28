using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace scafflMDCG
{
    public partial class MDCG_DBContext : DbContext
    {
        public MDCG_DBContext()
        {
        }

        public MDCG_DBContext(DbContextOptions<MDCG_DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<GlobEstadoCivil> GlobEstadoCivils { get; set; }
        public virtual DbSet<GlobGenero> GlobGeneros { get; set; }
        public virtual DbSet<GlobGradoAcademico> GlobGradoAcademicos { get; set; }
        public virtual DbSet<GlobMisionesExterior> GlobMisionesExteriors { get; set; }
        public virtual DbSet<GlobPai> GlobPais { get; set; }
        public virtual DbSet<GlobTipoFuncionario> GlobTipoFuncionarios { get; set; }
        public virtual DbSet<GlobTipoPasaporte> GlobTipoPasaportes { get; set; }
        public virtual DbSet<GlobTratamiento> GlobTratamientos { get; set; }
        public virtual DbSet<MdcgAcreditacione> MdcgAcreditaciones { get; set; }
        public virtual DbSet<MdcgAdjuntoAcreditacione> MdcgAdjuntoAcreditaciones { get; set; }
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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DIIN-VESTRADA;Initial Catalog=CancilleriaGuatemalaDb2021; User ID=usr_cgdb;Password=Us3r_CgDb2019");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP850_CI_AI");

            modelBuilder.Entity<GlobEstadoCivil>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("GLOB_ESTADO_CIVIL_PK");

                entity.ToTable("GLOB_ESTADO_CIVIL", "glob");

                entity.Property(e => e.Codigo).HasColumnName("CODIGO");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");
            });

            modelBuilder.Entity<GlobGenero>(entity =>
            {
                entity.HasKey(e => e.CodigoGenero)
                    .HasName("PK__GLOB_GENERO__153B1FDF");

                entity.ToTable("GLOB_GENERO", "glob");

                entity.HasComment("Almacena los generos");

                entity.Property(e => e.CodigoGenero)
                    .HasColumnName("CODIGO_GENERO")
                    .HasComment("Codigo correlativo unico para cada registro");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION")
                    .HasComment("Almacena la descripcion");
            });

            modelBuilder.Entity<GlobGradoAcademico>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("GLOB_GRADO_ACADEMICO_PK");

                entity.ToTable("GLOB_GRADO_ACADEMICO", "glob");

                entity.Property(e => e.Codigo).HasColumnName("CODIGO");

                entity.Property(e => e.Descripcion).HasColumnName("DESCRIPCION");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");
            });

            modelBuilder.Entity<GlobMisionesExterior>(entity =>
            {
                entity.HasKey(e => e.IdMisionExterior);

                entity.ToTable("GLOB_MISIONES_EXTERIOR", "glob");

                entity.Property(e => e.IdMisionExterior).HasColumnName("ID_MISION_EXTERIOR");

                entity.Property(e => e.CircunscripcionSeccionConsular)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("CIRCUNSCRIPCION_SECCION_CONSULAR");

                entity.Property(e => e.CodigoCiudad).HasColumnName("CODIGO_CIUDAD");

                entity.Property(e => e.CodigoDepartamento).HasColumnName("CODIGO_DEPARTAMENTO");

                entity.Property(e => e.CodigoPais).HasColumnName("CODIGO_PAIS");

                entity.Property(e => e.CodigoTipoMision).HasColumnName("CODIGO_TIPO_MISION");

                entity.Property(e => e.CorreoElectronico)
                    .HasMaxLength(150)
                    .HasColumnName("CORREO_ELECTRONICO");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(255)
                    .HasColumnName("DIRECCION");

                entity.Property(e => e.Fax)
                    .HasMaxLength(150)
                    .HasColumnName("FAX");

                entity.Property(e => e.FechaAcreditacion)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ACREDITACION");

                entity.Property(e => e.FiestaNacional)
                    .HasMaxLength(250)
                    .HasColumnName("FIESTA_NACIONAL");

                entity.Property(e => e.Horario)
                    .HasMaxLength(150)
                    .HasColumnName("HORARIO");

                entity.Property(e => e.Moneda).HasColumnName("MONEDA");

                entity.Property(e => e.NombreMision)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("NOMBRE_MISION");

                entity.Property(e => e.NombreMisionTransferencia)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("NOMBRE_MISION_TRANSFERENCIA");

                entity.Property(e => e.Notas)
                    .HasMaxLength(250)
                    .HasColumnName("NOTAS");

                entity.Property(e => e.Prioridad).HasColumnName("PRIORIDAD");

                entity.Property(e => e.SitioWeb)
                    .HasMaxLength(250)
                    .HasColumnName("SITIO_WEB");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(150)
                    .HasColumnName("TELEFONO");

                entity.Property(e => e.Zip)
                    .HasMaxLength(10)
                    .HasColumnName("ZIP")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<GlobPai>(entity =>
            {
                entity.HasKey(e => e.CodigoPais)
                    .HasName("PK__GLOB_PAIS__2E1BDC42");

                entity.ToTable("GLOB_PAIS", "glob");

                entity.HasComment("Almacena los paises");

                entity.Property(e => e.CodigoPais)
                    .HasColumnName("CODIGO_PAIS")
                    .HasComment("Codigo correlativo unico para cada pais");

                entity.Property(e => e.CategoriaOficial)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("CATEGORIA_OFICIAL")
                    .HasComment("Almacena la categoria oficial");

                entity.Property(e => e.CategoriaOrdinaria)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("CATEGORIA_ORDINARIA")
                    .HasComment("Almacena la categoria ordinaria");

                entity.Property(e => e.CodigoIsoAlpha3)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CODIGO_ISO_ALPHA3")
                    .IsFixedLength(true)
                    .HasComment("Almacena el codigo de iso");

                entity.Property(e => e.CodigoMoneda)
                    .HasColumnName("CODIGO_MONEDA")
                    .HasComment("Almacena el codigo de moneda");

                entity.Property(e => e.CodigoRegion)
                    .HasColumnName("CODIGO_REGION")
                    .HasComment("Almacena el codigo de region");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION")
                    .HasComment("Almacena la descripcion");

                entity.Property(e => e.FechaInicioRelaciones)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_INICIO_RELACIONES")
                    .HasComment("Almacena la fecha de inicio de relaciones");

                entity.Property(e => e.HtmlReloj)
                    .HasColumnType("text")
                    .HasColumnName("HTML_RELOJ");

                entity.Property(e => e.HusoHorario)
                    .HasColumnName("HUSO_HORARIO")
                    .HasComment("Almacena el huso de horari");

                entity.Property(e => e.ImgBandera)
                    .HasColumnType("image")
                    .HasColumnName("IMG_BANDERA")
                    .HasComment("Almacena la bandera");

                entity.Property(e => e.ImgMapa)
                    .HasColumnType("image")
                    .HasColumnName("IMG_MAPA");

                entity.Property(e => e.Nacionalidad)
                    .HasMaxLength(250)
                    .HasColumnName("NACIONALIDAD")
                    .HasComment("Almacena la nacionalidad");

                entity.Property(e => e.Prioridad).HasColumnName("PRIORIDAD");
            });

            modelBuilder.Entity<GlobTipoFuncionario>(entity =>
            {
                entity.HasKey(e => e.CodigoTipoFuncionario)
                    .HasName("PK__GLOB_TIPO_FUNCIO__29AC2CE0");

                entity.ToTable("GLOB_TIPO_FUNCIONARIO", "glob");

                entity.HasComment("Almacena los tipos de funcionarios");

                entity.Property(e => e.CodigoTipoFuncionario)
                    .HasColumnName("CODIGO_TIPO_FUNCIONARIO")
                    .HasComment("Codigo correlativo unico para cada registro");

                entity.Property(e => e.CodigoTipoInstitucion)
                    .HasColumnName("CODIGO_TIPO_INSTITUCION")
                    .HasComment("Almacena el tipo de institucion");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION")
                    .HasComment("Almacena la descripcion");

                entity.Property(e => e.Prioridad)
                    .HasColumnName("PRIORIDAD")
                    .HasComment("Almacena prioridad");
            });

            modelBuilder.Entity<GlobTipoPasaporte>(entity =>
            {
                entity.HasKey(e => e.CodigoTipoPasaporte);

                entity.ToTable("GLOB_TIPO_PASAPORTE", "glob");

                entity.HasComment("Almacena los tipos de pasaporte");

                entity.Property(e => e.CodigoTipoPasaporte)
                    .HasColumnName("CODIGO_TIPO_PASAPORTE")
                    .HasComment("Codigo correlativo unico para cada registro");

                entity.Property(e => e.NombreTipoPasaporte)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_TIPO_PASAPORTE")
                    .HasComment("Almacena el nombre del tipo de pasaporte");
            });

            modelBuilder.Entity<GlobTratamiento>(entity =>
            {
                entity.HasKey(e => e.CodigoTratamiento)
                    .HasName("PK__GLOB_TRATAMIENTO__0425A276");

                entity.ToTable("GLOB_TRATAMIENTO", "glob");

                entity.HasComment("Almacena los tratamientos");

                entity.Property(e => e.CodigoTratamiento)
                    .HasColumnName("CODIGO_TRATAMIENTO")
                    .HasComment("Codigo correlativo unico para cada registro");

                entity.Property(e => e.Abreviatura)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ABREVIATURA")
                    .HasComment("Almacena la abreviatura");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION")
                    .HasComment("Almacena la descripcion");
            });

            modelBuilder.Entity<MdcgAcreditacione>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.ToTable("MDCG_ACREDITACIONES");

                entity.Property(e => e.Codigo).HasColumnName("CODIGO");

                entity.Property(e => e.Asistente)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("ASISTENTE");

                entity.Property(e => e.CodigoCargo).HasColumnName("CODIGO_CARGO");

                entity.Property(e => e.CodigoFuncionario).HasColumnName("CODIGO_FUNCIONARIO");

                entity.Property(e => e.CodigoMision).HasColumnName("CODIGO_MISION");

                entity.Property(e => e.CodigoTipoAcreditacion).HasColumnName("CODIGO_TIPO_ACREDITACION");

                entity.Property(e => e.CodigoTratamiento).HasColumnName("CODIGO_TRATAMIENTO");

                entity.Property(e => e.Eliminado).HasColumnName("ELIMINADO");

                entity.Property(e => e.EsJefeMision).HasColumnName("ES_JEFE_MISION");

                entity.Property(e => e.Estado).HasColumnName("ESTADO");

                entity.Property(e => e.FechaAcreditacion)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ACREDITACION");

                entity.Property(e => e.FechaArribo)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ARRIBO");

                entity.Property(e => e.FechaAvisoRetiro)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_AVISO_RETIRO");

                entity.Property(e => e.FechaBeneplacito)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_BENEPLACITO");

                entity.Property(e => e.FechaDevolucion)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_DEVOLUCION");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ELIMINACION");

                entity.Property(e => e.FechaImpresion)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_IMPRESION");

                entity.Property(e => e.FechaModificacion)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_MODIFICACION");

                entity.Property(e => e.FechaPresentacionCredenciales)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_PRESENTACION_CREDENCIALES");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_REGISTRO");

                entity.Property(e => e.FechaSalida)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_SALIDA");

                entity.Property(e => e.FechaSolicitudBeneplacito)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_SOLICITUD_BENEPLACITO");

                entity.Property(e => e.FechaTomaPosesion)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_TOMA_POSESION");

                entity.Property(e => e.FechaVigencia)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_VIGENCIA");

                entity.Property(e => e.Guia)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("GUIA");

                entity.Property(e => e.LugarAvisoRetiro)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("LUGAR_AVISO_RETIRO");

                entity.Property(e => e.NoAcreditacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NO_ACREDITACION");

                entity.Property(e => e.NotaDevolucion)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("NOTA_DEVOLUCION");

                entity.Property(e => e.NumeroCarne)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NUMERO_CARNE");

                entity.Property(e => e.NumeroPnc).HasColumnName("NUMERO_PNC");

                entity.Property(e => e.NumeroTransito).HasColumnName("NUMERO_TRANSITO");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(2500)
                    .IsUnicode(false)
                    .HasColumnName("OBSERVACIONES");

                entity.Property(e => e.Orden).HasColumnName("ORDEN");

                entity.Property(e => e.ServiciosPrestados)
                    .IsUnicode(false)
                    .HasColumnName("SERVICIOS_PRESTADOS");

                entity.Property(e => e.SolicitaLicencia).HasColumnName("SOLICITA_LICENCIA");

                entity.Property(e => e.TipoAcreditacion).HasColumnName("TIPO_ACREDITACION");

                entity.Property(e => e.UsuarioElimina)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_ELIMINA");

                entity.Property(e => e.UsuarioModifica)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_MODIFICA");

                entity.Property(e => e.UsuarioRegistra)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_REGISTRA");

                entity.Property(e => e.ViaSalida)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("VIA_SALIDA");

                entity.HasOne(d => d.CodigoCargoNavigation)
                    .WithMany(p => p.MdcgAcreditaciones)
                    .HasForeignKey(d => d.CodigoCargo)
                    .HasConstraintName("MDCG_ACREDITACIONES_FK_CARGO");

                entity.HasOne(d => d.CodigoFuncionarioNavigation)
                    .WithMany(p => p.MdcgAcreditaciones)
                    .HasForeignKey(d => d.CodigoFuncionario)
                    .HasConstraintName("MDCG_ACREDITACIONES_FK");

                entity.HasOne(d => d.CodigoMisionNavigation)
                    .WithMany(p => p.MdcgAcreditaciones)
                    .HasForeignKey(d => d.CodigoMision)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MDCG_ACREDITACIONES_FK_MISION");

                entity.HasOne(d => d.CodigoTipoAcreditacionNavigation)
                    .WithMany(p => p.MdcgAcreditaciones)
                    .HasForeignKey(d => d.CodigoTipoAcreditacion)
                    .HasConstraintName("MDCG_ACREDITACIONES_FK_TIPO_ACREDITACION");

                entity.HasOne(d => d.CodigoTratamientoNavigation)
                    .WithMany(p => p.MdcgAcreditaciones)
                    .HasForeignKey(d => d.CodigoTratamiento)
                    .HasConstraintName("MDCG_ACREDITACIONES_FK_TRATAMIENTO");

                entity.HasOne(d => d.EstadoNavigation)
                    .WithMany(p => p.MdcgAcreditaciones)
                    .HasForeignKey(d => d.Estado)
                    .HasConstraintName("MDCG_ACREDITACIONES_FK_ESTADO");
            });

            modelBuilder.Entity<MdcgAdjuntoAcreditacione>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_MDCG_ADJUNTO_FUNCIONARIO");

                entity.ToTable("MDCG_ADJUNTO_ACREDITACIONES");

                entity.Property(e => e.Codigo)
                    .ValueGeneratedNever()
                    .HasColumnName("CODIGO");

                entity.Property(e => e.CodigoAcreditacion).HasColumnName("CODIGO_ACREDITACION");

                entity.Property(e => e.CodigoGestion).HasColumnName("CODIGO_GESTION");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("OBSERVACIONES");

                entity.Property(e => e.RutaDocumento)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("RUTA_DOCUMENTO");

                entity.Property(e => e.TituloDocumento)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("TITULO_DOCUMENTO");

                entity.HasOne(d => d.CodigoAcreditacionNavigation)
                    .WithMany(p => p.MdcgAdjuntoAcreditaciones)
                    .HasForeignKey(d => d.CodigoAcreditacion)
                    .HasConstraintName("MDCG_ADJUNTO_ACREDITACIONES_FK");

                entity.HasOne(d => d.CodigoGestionNavigation)
                    .WithMany(p => p.MdcgAdjuntoAcreditaciones)
                    .HasForeignKey(d => d.CodigoGestion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MDCG_ADJUNTO_ACREDITACIONES_FK_TIPO_GESTION");
            });

            modelBuilder.Entity<MdcgBitacora>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.ToTable("MDCG_BITACORA");

                entity.Property(e => e.Codigo).HasColumnName("CODIGO");

                entity.Property(e => e.CodigoAcreditacion).HasColumnName("CODIGO_ACREDITACION");

                entity.Property(e => e.Estado).HasColumnName("ESTADO");

                entity.Property(e => e.FechaMovimiento)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_MOVIMIENTO");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("OBSERVACIONES");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO");

                entity.HasOne(d => d.CodigoAcreditacionNavigation)
                    .WithMany(p => p.MdcgBitacoras)
                    .HasForeignKey(d => d.CodigoAcreditacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MDCG_BITACORA_FK_BITACORA_ACREDITACION");
            });

            modelBuilder.Entity<MdcgCargo>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.ToTable("MDCG_CARGOS");

                entity.Property(e => e.Codigo).HasColumnName("CODIGO");

                entity.Property(e => e.Cargo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("CARGO");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION");
            });

            modelBuilder.Entity<MdcgDependiente>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.ToTable("MDCG_DEPENDIENTES");

                entity.Property(e => e.Codigo).HasColumnName("CODIGO");

                entity.Property(e => e.ApellidoCasada)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("APELLIDO_CASADA");

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("APELLIDOS");

                entity.Property(e => e.CodigoAcreditacion).HasColumnName("CODIGO_ACREDITACION");

                entity.Property(e => e.CodigoGenero).HasColumnName("CODIGO_GENERO");

                entity.Property(e => e.CodigoParentesco).HasColumnName("CODIGO_PARENTESCO");

                entity.Property(e => e.CodigoTipoLicencia).HasColumnName("CODIGO_TIPO_LICENCIA");

                entity.Property(e => e.CodigoTipoPasaporte).HasColumnName("CODIGO_TIPO_PASAPORTE");

                entity.Property(e => e.CodigoXAcreditacion).HasColumnName("CODIGO_X_ACREDITACION");

                entity.Property(e => e.Eliminado).HasColumnName("ELIMINADO");

                entity.Property(e => e.Estado).HasColumnName("ESTADO");

                entity.Property(e => e.FechaAcreditacion)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ACREDITACION");

                entity.Property(e => e.FechaDevolucion)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_DEVOLUCION");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ELIMINACION");

                entity.Property(e => e.FechaModificacion)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_MODIFICACION");

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_NACIMIENTO");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_REGISTRO");

                entity.Property(e => e.FechaVigencia)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_VIGENCIA");

                entity.Property(e => e.Firma)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FIRMA");

                entity.Property(e => e.Fotografia)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("FOTOGRAFIA");

                entity.Property(e => e.HuellaImg)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("HUELLA_IMG");

                entity.Property(e => e.HuellaTxt)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("HUELLA_TXT");

                entity.Property(e => e.LugarNacimiento)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("LUGAR_NACIMIENTO");

                entity.Property(e => e.NoAcreditacion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NO_ACREDITACION");

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRES");

                entity.Property(e => e.NotaDevolucion)
                    .HasMaxLength(5000)
                    .IsUnicode(false)
                    .HasColumnName("NOTA_DEVOLUCION");

                entity.Property(e => e.NumeroCarne)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NUMERO_CARNE");

                entity.Property(e => e.NumeroLicencia)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("NUMERO_LICENCIA");

                entity.Property(e => e.NumeroPasaporte)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("NUMERO_PASAPORTE");

                entity.Property(e => e.PaisOrigen).HasColumnName("PAIS_ORIGEN");

                entity.Property(e => e.UsuarioElimina)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_ELIMINA");

                entity.Property(e => e.UsuarioModifica)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_MODIFICA");

                entity.Property(e => e.UsuarioRegistra)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_REGISTRA");

                entity.HasOne(d => d.CodigoAcreditacionNavigation)
                    .WithMany(p => p.MdcgDependientes)
                    .HasForeignKey(d => d.CodigoAcreditacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MDCG_DEPENDIENTES_FK");

                entity.HasOne(d => d.CodigoGeneroNavigation)
                    .WithMany(p => p.MdcgDependientes)
                    .HasForeignKey(d => d.CodigoGenero)
                    .HasConstraintName("FK_MDCG_DEPENDIENTES_GLOB_GENERO");

                entity.HasOne(d => d.CodigoTipoPasaporteNavigation)
                    .WithMany(p => p.MdcgDependientes)
                    .HasForeignKey(d => d.CodigoTipoPasaporte)
                    .HasConstraintName("FK_MDCG_DEPENDIENTES_GLOB_TIPO_PASAPORTE");

                entity.HasOne(d => d.PaisOrigenNavigation)
                    .WithMany(p => p.MdcgDependientes)
                    .HasForeignKey(d => d.PaisOrigen)
                    .HasConstraintName("MDCG_DEPENDIENTES_FK_PAIS");
            });

            modelBuilder.Entity<MdcgEstadosAcreditacion>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK_MDCG_ESTADOS_ACRE");

                entity.ToTable("MDCG_ESTADOS_ACREDITACION");

                entity.Property(e => e.Codigo).HasColumnName("CODIGO");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");
            });

            modelBuilder.Entity<MdcgFirmante>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.ToTable("MDCG_FIRMANTE");

                entity.Property(e => e.Codigo).HasColumnName("CODIGO");

                entity.Property(e => e.Activo).HasColumnName("ACTIVO");

                entity.Property(e => e.Cargo)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("CARGO");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ELIMINACION");

                entity.Property(e => e.FechaFin)
                    .HasMaxLength(10)
                    .HasColumnName("FECHA_FIN")
                    .IsFixedLength(true);

                entity.Property(e => e.FechaInicio)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_INICIO");

                entity.Property(e => e.FechaModificacion)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_MODIFICACION");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_REGISTRO");

                entity.Property(e => e.Firma)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("FIRMA");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.UsuarioElimina)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_ELIMINA");

                entity.Property(e => e.UsuarioModifica)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_MODIFICA");

                entity.Property(e => e.UsuarioRegistra)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_REGISTRA");
            });

            modelBuilder.Entity<MdcgFormatoBc>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.ToTable("MDCG_FORMATO_BC");

                entity.Property(e => e.Codigo).HasColumnName("CODIGO");

                entity.Property(e => e.Encabezado).HasColumnName("ENCABEZADO");

                entity.Property(e => e.Pie).HasColumnName("PIE");
            });

            modelBuilder.Entity<MdcgFuncionario>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.ToTable("MDCG_FUNCIONARIO");

                entity.Property(e => e.Codigo).HasColumnName("CODIGO");

                entity.Property(e => e.ApellidoCasada)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("APELLIDO_CASADA");

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("APELLIDOS");

                entity.Property(e => e.CodigoEstadoCivil).HasColumnName("CODIGO_ESTADO_CIVIL");

                entity.Property(e => e.CodigoGenero).HasColumnName("CODIGO_GENERO");

                entity.Property(e => e.CodigoGradoAcademico).HasColumnName("CODIGO_GRADO_ACADEMICO");

                entity.Property(e => e.CodigoTipoFuncionario).HasColumnName("CODIGO_TIPO_FUNCIONARIO");

                entity.Property(e => e.CodigoTipoLicencia).HasColumnName("CODIGO_TIPO_LICENCIA");

                entity.Property(e => e.CodigoTipoPasaporte).HasColumnName("CODIGO_TIPO_PASAPORTE");

                entity.Property(e => e.CorrelativoTipo)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("CORRELATIVO_TIPO");

                entity.Property(e => e.CorreoElectronico)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CORREO_ELECTRONICO");

                entity.Property(e => e.DatosFamilia)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("DATOS_FAMILIA");

                entity.Property(e => e.DireccionParticular)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("DIRECCION_PARTICULAR");

                entity.Property(e => e.Eliminado).HasColumnName("ELIMINADO");

                entity.Property(e => e.Estado).HasColumnName("ESTADO");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ELIMINACION");

                entity.Property(e => e.FechaModificacion)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_MODIFICACION");

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_NACIMIENTO");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_REGISTRO");

                entity.Property(e => e.Firma)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("FIRMA");

                entity.Property(e => e.Fotografia)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("FOTOGRAFIA");

                entity.Property(e => e.HuellaImg)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("HUELLA_IMG");

                entity.Property(e => e.HuellaTxt)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("HUELLA_TXT");

                entity.Property(e => e.IdCorrelativoAnterior).HasColumnName("ID_CORRELATIVO_ANTERIOR");

                entity.Property(e => e.LugarNacimiento)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("LUGAR_NACIMIENTO");

                entity.Property(e => e.NacionalidadAdquirida).HasColumnName("NACIONALIDAD_ADQUIRIDA");

                entity.Property(e => e.NombreCompletoConyuge)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE_COMPLETO_CONYUGE");

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRES");

                entity.Property(e => e.NumeroLicencia)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("NUMERO_LICENCIA");

                entity.Property(e => e.NumeroPasaporte)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("NUMERO_PASAPORTE");

                entity.Property(e => e.OtrosMediosComunicacion)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("OTROS_MEDIOS_COMUNICACION");

                entity.Property(e => e.PaisOrigen).HasColumnName("PAIS_ORIGEN");

                entity.Property(e => e.ResidenteGt).HasColumnName("RESIDENTE_GT");

                entity.Property(e => e.ResidenteGtFecha)
                    .HasColumnType("datetime")
                    .HasColumnName("RESIDENTE_GT_FECHA");

                entity.Property(e => e.TelefonoParticular)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TELEFONO_PARTICULAR");

                entity.Property(e => e.UsuarioElimina)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_ELIMINA");

                entity.Property(e => e.UsuarioModifica)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_MODIFICA");

                entity.Property(e => e.UsuarioRegistra)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_REGISTRA");

                entity.HasOne(d => d.CodigoEstadoCivilNavigation)
                    .WithMany(p => p.MdcgFuncionarios)
                    .HasForeignKey(d => d.CodigoEstadoCivil)
                    .HasConstraintName("MDCG_FUNCIONARIO_FK_ESTADO_CIVIL");

                entity.HasOne(d => d.CodigoGeneroNavigation)
                    .WithMany(p => p.MdcgFuncionarios)
                    .HasForeignKey(d => d.CodigoGenero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MDCG_FUNCIONARIO_GLOB_GENERO");

                entity.HasOne(d => d.CodigoGradoAcademicoNavigation)
                    .WithMany(p => p.MdcgFuncionarios)
                    .HasForeignKey(d => d.CodigoGradoAcademico)
                    .HasConstraintName("MDCG_FUNCIONARIO_FK_GRADO_ACADEMICO");

                entity.HasOne(d => d.CodigoTipoFuncionarioNavigation)
                    .WithMany(p => p.MdcgFuncionarios)
                    .HasForeignKey(d => d.CodigoTipoFuncionario)
                    .HasConstraintName("FK_MDCG_FUNCIONARIO_GLOB_TIPO_FUNCIONARIO");

                entity.HasOne(d => d.CodigoTipoPasaporteNavigation)
                    .WithMany(p => p.MdcgFuncionarios)
                    .HasForeignKey(d => d.CodigoTipoPasaporte)
                    .HasConstraintName("MDCG_FUNCIONARIO_FK_TIPO_PASAPORTE");

                entity.HasOne(d => d.NacionalidadAdquiridaNavigation)
                    .WithMany(p => p.MdcgFuncionarioNacionalidadAdquiridaNavigations)
                    .HasForeignKey(d => d.NacionalidadAdquirida)
                    .HasConstraintName("MDCG_FUNCIONARIO_FK_NACIONALIDAD_ADQUIRIDA");

                entity.HasOne(d => d.PaisOrigenNavigation)
                    .WithMany(p => p.MdcgFuncionarioPaisOrigenNavigations)
                    .HasForeignKey(d => d.PaisOrigen)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MDCG_FUNCIONARIO_FK");
            });

            modelBuilder.Entity<MdcgParametro>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.ToTable("MDCG_PARAMETROS");

                entity.Property(e => e.Codigo).HasColumnName("CODIGO");

                entity.Property(e => e.CodigoModulo).HasColumnName("CODIGO_MODULO");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION");

                entity.Property(e => e.FechaEliminacion)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_ELIMINACION");

                entity.Property(e => e.FechaModificacion)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_MODIFICACION");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasColumnName("FECHA_REGISTRO");

                entity.Property(e => e.Imagen).HasColumnName("IMAGEN");

                entity.Property(e => e.UsuarioElimina)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_ELIMINA");

                entity.Property(e => e.UsuarioModifica)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_MODIFICA");

                entity.Property(e => e.UsuarioRegistra)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO_REGISTRA");

                entity.Property(e => e.Valor)
                    .HasMaxLength(150)
                    .HasColumnName("VALOR")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<MdcgTipoAcreditacion>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.ToTable("MDCG_TIPO_ACREDITACION");

                entity.Property(e => e.Codigo).HasColumnName("CODIGO");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");
            });

            modelBuilder.Entity<MdcgTipoGestion>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("MDCG_TIPO_GESTION_PK");

                entity.ToTable("MDCG_TIPO_GESTION");

                entity.Property(e => e.Codigo).HasColumnName("CODIGO");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
