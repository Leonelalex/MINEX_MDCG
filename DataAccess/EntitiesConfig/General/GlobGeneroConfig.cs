using DataAccess.Entities.Generales;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntitiesConfig.General
{
    public class GlobGeneroConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<GlobGenero> entity)
        {
            entity.HasKey(e => e.code)
                    .HasName("PK__GLOB_GENERO__153B1FDF");

            entity.ToTable("GLOB_GENERO", "glob");

            entity.HasComment("Almacena los generos");

            entity.Property(e => e.code)
                .HasColumnName("CODIGO_GENERO")
                .HasComment("Codigo correlativo unico para cada registro");

            entity.Property(e => e.name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION")
                .HasComment("Almacena la descripcion");
        }
    }
}
