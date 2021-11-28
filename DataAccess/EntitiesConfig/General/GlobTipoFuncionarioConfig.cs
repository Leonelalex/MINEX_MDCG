using DataAccess.Entities.Generales;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntitiesConfig.General
{
    public class GlobTipoFuncionarioConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<GlobTipoFuncionario> entity)
        {
            entity.HasKey(e => e.code)
                    .HasName("PK__GLOB_TIPO_FUNCIO__29AC2CE0");

            entity.ToTable("GLOB_TIPO_FUNCIONARIO", "glob");

            entity.HasComment("Almacena los tipos de funcionarios");

            entity.Property(e => e.code)
                .HasColumnName("CODIGO_TIPO_FUNCIONARIO")
                .HasComment("Codigo correlativo unico para cada registro");

            entity.Property(e => e.CodigoTipoInstitucion)
                .HasColumnName("CODIGO_TIPO_INSTITUCION")
                .HasComment("Almacena el tipo de institucion");

            entity.Property(e => e.name)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION")
                .HasComment("Almacena la descripcion");

            entity.Property(e => e.Prioridad)
                .HasColumnName("PRIORIDAD")
                .HasComment("Almacena prioridad");
        }
    }
}
