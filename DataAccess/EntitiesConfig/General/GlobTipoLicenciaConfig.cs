using DataAccess.Entities.Generales;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace DataAccess.EntitiesConfig.General
{
    public class GlobTipoLicenciaConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<GlobtipoLicencia> entity)
        {
            entity.HasKey(e => e.code).HasName("GLOB_TIPO_LICENCIA_PK");

            entity.ToTable("GLOB_TIPO_LICENCIA", "glob");

            entity.Property(e => e.code)
                .HasColumnName("CODIGO");

            entity.Property(e => e.name)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");

            entity.Property(e => e.description)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
        }
    }
}
