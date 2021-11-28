using DataAccess.Entities.MDCG_Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntitiesConfig.MDCG_EntitiesConfig
{
    public class MdcgFirmanteConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<MdcgFirmante> entity)
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
                .HasColumnType("date")
                .HasColumnName("FECHA_ELIMINACION");

            entity.Property(e => e.FechaFin)
                .HasMaxLength(10)
                .HasColumnName("FECHA_FIN")
                .IsFixedLength(true);

            entity.Property(e => e.FechaInicio)
                .HasColumnType("date")
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
        }
    }
}
