using DataAccess.Entities.Generales;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntitiesConfig.General
{
    public class GlobEstadoCivilConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<GlobEstadoCivil> entity)
        {
            entity.HasKey(e => e.code)
                   .HasName("GLOB_ESTADO_CIVIL_PK");

            entity.ToTable("GLOB_ESTADO_CIVIL", "glob");

            entity.Property(e => e.code).HasColumnName("CODIGO");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");

            entity.Property(e => e.name)
                .IsRequired()
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
        }
    }
}
