using DataAccess.Entities.Generales;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntitiesConfig.General
{
    public class GlobGradoAcademicoConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<GlobGradoAcademico> entity)
        {
            entity.HasKey(e => e.code)
                    .HasName("GLOB_GRADO_ACADEMICO_PK");

            entity.ToTable("GLOB_GRADO_ACADEMICO", "glob");

            entity.Property(e => e.code).HasColumnName("CODIGO");

            entity.Property(e => e.Descripcion).HasColumnName("DESCRIPCION");

            entity.Property(e => e.name)
                .IsRequired()
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
        }
    }
}
