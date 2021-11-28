using DataAccess.Entities.Generales;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntitiesConfig.General
{
    class GlobPaisConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<GlobPais> entity)
        {
            entity.HasKey(e => e.code)
                        .HasName("PK__GLOB_PAIS__2E1BDC42");

            entity.ToTable("GLOB_PAIS", "glob");

            entity.HasComment("Almacena los paises");

            entity.Property(e => e.code)
                .HasColumnName("CODIGO_PAIS")
                .HasComment("Codigo correlativo unico para cada pais");

            entity.Property(e => e.CategoriaOficial)
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnName("CATEGORIA_OFICIAL")
                        .HasComment("Almacena la categoria oficial");

            entity.Property(e => e.CategoriaOrdinaria)
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnName("CATEGORIA_ORDINARIA")
                        .HasComment("Almacena la categoria ordinaria");

            entity.Property(e => e.CodigoIsoAlpha3)
                        .IsRequired()
                        .HasMaxLength(3)
                        .IsUnicode(false)
                        .HasColumnName("CODIGO_ISO_ALPHA3")
                        .IsFixedLength(true)
                        .HasComment("Almacena el codigo de iso");

            entity.Property(e => e.CodigoMoneda)
                        .HasColumnName("CODIGO_MONEDA")
                        .HasComment("Almacena el codigo de moneda");

            entity.Property(e => e.CodigoRegion)
                        .HasColumnName("CODIGO_REGION")
                        .HasComment("Almacena el codigo de region");

            entity.Property(e => e.name)
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnName("DESCRIPCION")
                        .HasComment("Almacena la descripcion");

            entity.Property(e => e.FechaInicioRelaciones)
                        .HasColumnType("datetime")
                        .HasColumnName("FECHA_INICIO_RELACIONES")
                        .HasComment("Almacena la fecha de inicio de relaciones");

            entity.Property(e => e.HtmlReloj)
                        .HasColumnType("text")
                        .HasColumnName("HTML_RELOJ");

            entity.Property(e => e.HusoHorario)
                        .HasColumnName("HUSO_HORARIO")
                        .HasComment("Almacena el huso de horari");

            entity.Property(e => e.ImgBandera)
                        .HasColumnType("image")
                        .HasColumnName("IMG_BANDERA")
                        .HasComment("Almacena la bandera");

            entity.Property(e => e.ImgMapa)
                        .HasColumnType("image")
                        .HasColumnName("IMG_MAPA");

            entity.Property(e => e.Nacionalidad)
                        .HasMaxLength(250)
                        .HasColumnName("NACIONALIDAD")
                        .HasComment("Almacena la nacionalidad");

            entity.Property(e => e.Prioridad).HasColumnName("PRIORIDAD");
        }
    }
}
