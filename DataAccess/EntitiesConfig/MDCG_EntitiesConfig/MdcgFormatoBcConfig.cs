using DataAccess.Entities.MDCG_Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntitiesConfig.MDCG_EntitiesConfig
{
    public class MdcgFormatoBcConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<MdcgFormatoBc> entity)
        {
            entity.HasKey(e => e.Codigo);

            entity.ToTable("MDCG_FORMATO_BC");

            entity.Property(e => e.Codigo).HasColumnName("CODIGO");

            entity.Property(e => e.Encabezado).HasColumnName("ENCABEZADO");

            entity.Property(e => e.Pie).HasColumnName("PIE");
        }
    }
}
