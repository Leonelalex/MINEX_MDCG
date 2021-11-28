using DataAccess.Entities.MDCG_Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntitiesConfig.MDCG_EntitiesConfig
{
    public class MdcgDependienteConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<MdcgDependiente> entity)
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

            entity.Property(e => e.CodigoFuncionario).HasColumnName("CODIGO_FUNCIONARIO");

            entity.Property(e => e.CodigoGenero).HasColumnName("CODIGO_GENERO");

            entity.Property(e => e.CodigoParentesco).HasColumnName("CODIGO_PARENTESCO");

            entity.Property(e => e.CodigoTipoLicencia).HasColumnName("CODIGO_TIPO_LICENCIA");

            entity.Property(e => e.CodigoTipoPasaporte).HasColumnName("CODIGO_TIPO_PASAPORTE");

            entity.Property(e => e.CodigoXAcreditacion).HasColumnName("CODIGO_X_ACREDITACION");

            entity.Property(e => e.Eliminado).HasColumnName("ELIMINADO");

            entity.Property(e => e.Estado).HasColumnName("ESTADO");

            entity.Property(e => e.Acreditado).HasColumnName("ACREDITADO");

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

            entity.Property(e => e.FechaVencimientoPasaporte)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_VENCIMIENTO_PASAPORTE");

            entity.Property(e => e.FechaVencimientoLicencia)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_VENCIMIENTO_LICENCIA");

            entity.Property(e => e.EstadoAcreditacion)
                .HasColumnName("ESTADO_ACREDITACION");

            entity.HasOne(d => d.CodigoFuncionarioNavigation)
                .WithMany(p => p.MdcgDependientes)
                .HasForeignKey(d => d.CodigoFuncionario)
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

            entity.HasOne(d => d.CodigoTipoLicenciaNavigation)
                .WithMany(p => p.MdcgDependientes)
                .HasForeignKey(d => d.CodigoTipoLicencia)
                .HasConstraintName("MDCG_DEPENDIENTES_FK_TIPO_LICENCIA");

            entity.HasOne(d => d.CodigoParentescoNavigation)
                .WithMany(p => p.MdcgDependientes)
                .HasForeignKey(d => d.CodigoParentesco)
                .HasConstraintName("FK_MDCG_DEPENDIENTES_GLOB_PARENTESCO");
        }
    }
}
