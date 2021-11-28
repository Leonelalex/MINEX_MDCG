using DataAccess.Entities.Generales;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntitiesConfig.General
{
    public class GlobTipoPasaporteConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<GlobTipoPasaporte> entity)
        {
            entity.HasKey(e => e.code);

            entity.ToTable("GLOB_TIPO_PASAPORTE", "glob");

            entity.HasComment("Almacena los tipos de pasaporte");

            entity.Property(e => e.code)
                .HasColumnName("CODIGO_TIPO_PASAPORTE")
                .HasComment("Codigo correlativo unico para cada registro");

            entity.Property(e => e.name)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("NOMBRE_TIPO_PASAPORTE")
                .HasComment("Almacena el nombre del tipo de pasaporte");
        }
    }
}
