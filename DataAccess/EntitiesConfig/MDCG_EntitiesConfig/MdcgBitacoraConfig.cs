using DataAccess.Entities.MDCG_Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntitiesConfig.MDCG_EntitiesConfig
{
    public class MdcgBitacoraConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<MdcgBitacora> entity)
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
        }
    }
}
