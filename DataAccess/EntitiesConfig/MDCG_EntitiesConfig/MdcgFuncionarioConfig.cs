using DataAccess.Entities.MDCG_Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntitiesConfig.MDCG_EntitiesConfig
{
    public class MdcgFuncionarioConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<MdcgFuncionario> entity)
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

            entity.Property(e => e.Genero).HasColumnName("CODIGO_GENERO");

            entity.Property(e => e.CodigoGradoAcademico).HasColumnName("CODIGO_GRADO_ACADEMICO");

            entity.Property(e => e.CodigoTipoFuncionario).HasColumnName("CODIGO_TIPO_FUNCIONARIO");

            entity.Property(e => e.TipoLicencia).HasColumnName("CODIGO_TIPO_LICENCIA");

            entity.Property(e => e.CodigoTipoPasaporte).HasColumnName("CODIGO_TIPO_PASAPORTE");

            entity.Property(e => e.CorrelativoTipo)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("CORRELATIVO_TIPO");

            entity.Property(e => e.CorreoElectronico)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CORREO_ELECTRONICO");

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
                .HasColumnType("date")
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

            entity.Property(e => e.Acreditado).HasColumnName("ACREDITADO");

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

            entity.Property(e => e.FechaVencimientoPasaporte)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_VENCIMIENTO_PASAPORTE");

            entity.Property(e => e.FechaVencimientoLicencia)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_VENCIMIENTO_LICENCIA");

            entity.HasOne(d => d.CodigoEstadoCivilNavigation)
                .WithMany(p => p.MdcgFuncionarios)
                .HasForeignKey(d => d.CodigoEstadoCivil)
                .HasConstraintName("MDCG_FUNCIONARIO_FK_ESTADO_CIVIL");

            entity.HasOne(d => d.CodigoGeneroNavigation)
                .WithMany(p => p.MdcgFuncionarios)
                .HasForeignKey(d => d.Genero)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MDCG_FUNCIONARIO_GLOB_GENERO");

            entity.HasOne(d => d.CodigoTipoLicenciaNavigation)
                .WithMany(p => p.MdcgFuncionarios)
                .HasForeignKey(d => d.TipoLicencia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("MDCG_FUNCIONARIO_FK_LICENCIA");

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
        }
    }
}
