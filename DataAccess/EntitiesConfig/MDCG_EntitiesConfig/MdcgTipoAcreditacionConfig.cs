using DataAccess.Entities.MDCG_Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntitiesConfig.MDCG_EntitiesConfig
{
    public class MdcgTipoAcreditacionConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<MdcgTipoAcreditacion> entity)
        {
            entity.HasKey(e => e.code);

            entity.ToTable("MDCG_TIPO_ACREDITACION");

            entity.Property(e => e.code).HasColumnName("CODIGO");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");

            entity.Property(e => e.name)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
        }
    }
}
