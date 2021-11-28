using DataAccess.Entities.MDCG_Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntitiesConfig.MDCG_EntitiesConfig
{
    public class MdcgParametroConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<MdcgParametro> entity)
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
        }
    }
}
