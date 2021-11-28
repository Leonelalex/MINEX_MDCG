using DataAccess.Entities.MDCG_Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntitiesConfig.MDCG_EntitiesConfig
{
    public class MdcgCargoConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<MdcgCargo> entity)
        {
            entity.HasKey(e => e.code);

            entity.ToTable("MDCG_CARGOS");

            entity.Property(e => e.code).HasColumnName("CODIGO");

            entity.Property(e => e.name)
                .IsRequired()
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("CARGO");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
        }
    }
}
