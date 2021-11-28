using DataAccess.Entities.MDCG_Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntitiesConfig.MDCG_EntitiesConfig
{
    public class MdcgAdjuntoAcreditacioneConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<MdcgAdjuntoAcreditaciones> entity)
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
        }
    }
}
