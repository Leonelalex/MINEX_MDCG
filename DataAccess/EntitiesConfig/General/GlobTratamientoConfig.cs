using DataAccess.Entities.Generales;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntitiesConfig.General
{
    public class GlobTratamientoConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<GlobTratamiento> entity)
        {
            entity.HasKey(e => e.code)
                   .HasName("PK__GLOB_TRATAMIENTO__0425A276");

            entity.ToTable("GLOB_TRATAMIENTO", "glob");

            entity.HasComment("Almacena los tratamientos");

            entity.Property(e => e.code)
                .HasColumnName("CODIGO_TRATAMIENTO")
                .HasComment("Codigo correlativo unico para cada registro");

            entity.Property(e => e.Abreviatura)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("ABREVIATURA")
                .HasComment("Almacena la abreviatura");

            entity.Property(e => e.name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION")
                .HasComment("Almacena la descripcion");
        }
    }
}
