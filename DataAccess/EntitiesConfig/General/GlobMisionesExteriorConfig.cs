using DataAccess.Entities.Generales;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntitiesConfig.General
{
    public class GlobMisionesExteriorConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<GlobMisionesExterior> entity)
        {
            entity.HasKey(e => e.code);

            entity.ToTable("GLOB_MISIONES_EXTERIOR", "glob");

            entity.Property(e => e.code).HasColumnName("ID_MISION_EXTERIOR");

            entity.Property(e => e.CircunscripcionSeccionConsular)
                .HasMaxLength(5000)
                .IsUnicode(false)
                .HasColumnName("CIRCUNSCRIPCION_SECCION_CONSULAR");

            entity.Property(e => e.CodigoCiudad).HasColumnName("CODIGO_CIUDAD");

            entity.Property(e => e.CodigoDepartamento).HasColumnName("CODIGO_DEPARTAMENTO");

            entity.Property(e => e.CodigoPais).HasColumnName("CODIGO_PAIS");

            entity.Property(e => e.CodigoTipoMision).HasColumnName("CODIGO_TIPO_MISION");

            entity.Property(e => e.CorreoElectronico)
                .HasMaxLength(150)
                .HasColumnName("CORREO_ELECTRONICO");

            entity.Property(e => e.Direccion)
                .HasMaxLength(255)
                .HasColumnName("DIRECCION");

            entity.Property(e => e.Fax)
                .HasMaxLength(150)
                .HasColumnName("FAX");

            entity.Property(e => e.FechaAcreditacion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_ACREDITACION");

            entity.Property(e => e.FiestaNacional)
                .HasMaxLength(250)
                .HasColumnName("FIESTA_NACIONAL");

            entity.Property(e => e.Horario)
                .HasMaxLength(150)
                .HasColumnName("HORARIO");

            entity.Property(e => e.Moneda).HasColumnName("MONEDA");

            entity.Property(e => e.name)
                .IsRequired()
                .HasMaxLength(250)
                .HasColumnName("NOMBRE_MISION");

            entity.Property(e => e.NombreMisionTransferencia)
                .IsRequired()
                .HasMaxLength(250)
                .HasColumnName("NOMBRE_MISION_TRANSFERENCIA");

            entity.Property(e => e.Notas)
                .HasMaxLength(250)
                .HasColumnName("NOTAS");

            entity.Property(e => e.Prioridad).HasColumnName("PRIORIDAD");

            entity.Property(e => e.SitioWeb)
                .HasMaxLength(250)
                .HasColumnName("SITIO_WEB");

            entity.Property(e => e.Telefono)
                .HasMaxLength(150)
                .HasColumnName("TELEFONO");

            entity.Property(e => e.Zip)
                .HasMaxLength(10)
                .HasColumnName("ZIP")
                .IsFixedLength(true);
        }
    }
}
