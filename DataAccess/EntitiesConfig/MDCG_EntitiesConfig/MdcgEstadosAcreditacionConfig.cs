using DataAccess.Entities.MDCG_Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntitiesConfig.MDCG_EntitiesConfig
{
    public class MdcgEstadosAcreditacionConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<MdcgEstadosAcreditacion> entity)
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
        }
    }
}
