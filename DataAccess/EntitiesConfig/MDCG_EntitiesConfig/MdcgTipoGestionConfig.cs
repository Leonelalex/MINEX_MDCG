using DataAccess.Entities.MDCG_Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntitiesConfig.MDCG_EntitiesConfig
{
    public class MdcgTipoGestionConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<MdcgTipoGestion> entity)
        {
            entity.HasKey(e => e.Codigo)
                     .HasName("MDCG_TIPO_GESTION_PK");

            entity.ToTable("MDCG_TIPO_GESTION");

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
