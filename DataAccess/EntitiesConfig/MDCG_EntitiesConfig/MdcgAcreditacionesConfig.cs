using DataAccess.Entities.MDCG_Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntitiesConfig.MDCG_EntitiesConfig
{
    public class MdcgAcreditacionesConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<MdcgAcreditaciones> entity)
        {
            entity.HasKey(e => e.Codigo);

            entity.ToTable("MDCG_ACREDITACIONES");

            entity.Property(e => e.Codigo).HasColumnName("CODIGO");

            entity.Property(e => e.CodigoCargo).HasColumnName("CODIGO_CARGO");

            entity.Property(e => e.CodigoFuncionario).HasColumnName("CODIGO_FUNCIONARIO");

            entity.Property(e => e.CodigoMision).HasColumnName("CODIGO_MISION");

            entity.Property(e => e.CodigoTipoAcreditacion).HasColumnName("CODIGO_TIPO_ACREDITACION");

            entity.Property(e => e.CodigoTratamiento).HasColumnName("CODIGO_TRATAMIENTO");

            entity.Property(e => e.Eliminado).HasColumnName("ELIMINADO");

            entity.Property(e => e.EsJefeMision).HasColumnName("ES_JEFE_MISION");

            entity.Property(e => e.Estado).HasColumnName("ESTADO");

            entity.Property(e => e.FechaAcreditacion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_ACREDITACION");

            entity.Property(e => e.FechaArribo)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_ARRIBO");

            entity.Property(e => e.FechaAvisoRetiro)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_AVISO_RETIRO");

            entity.Property(e => e.FechaBeneplacito)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_BENEPLACITO");

            entity.Property(e => e.FechaDevolucion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_DEVOLUCION");

            entity.Property(e => e.FechaEliminacion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_ELIMINACION");

            entity.Property(e => e.FechaImpresion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_IMPRESION");

            entity.Property(e => e.FechaModificacion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_MODIFICACION");

            entity.Property(e => e.FechaPresentacionCredenciales)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_PRESENTACION_CREDENCIALES");

            entity.Property(e => e.FechaRegistro)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_REGISTRO");

            entity.Property(e => e.FechaSalida)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_SALIDA");

            entity.Property(e => e.FechaSolicitudBeneplacito)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_SOLICITUD_BENEPLACITO");

            entity.Property(e => e.FechaTomaPosesion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_TOMA_POSESION");

            entity.Property(e => e.FechaVigencia)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_VIGENCIA");

            entity.Property(e => e.Guia)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("GUIA");

            entity.Property(e => e.LugarAvisoRetiro)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("LUGAR_AVISO_RETIRO");

            entity.Property(e => e.NoAcreditacion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NO_ACREDITACION");

            entity.Property(e => e.NotaDevolucion)
                .HasMaxLength(5000)
                .IsUnicode(false)
                .HasColumnName("NOTA_DEVOLUCION");

            entity.Property(e => e.NumeroCarne)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NUMERO_CARNE");

            entity.Property(e => e.NumeroPnc).HasColumnName("NUMERO_PNC");

            entity.Property(e => e.NumeroTransito).HasColumnName("NUMERO_TRANSITO");

            entity.Property(e => e.Observaciones)
                .HasMaxLength(2500)
                .IsUnicode(false)
                .HasColumnName("OBSERVACIONES");

            entity.Property(e => e.SolicitaLicencia).HasColumnName("SOLICITA_LICENCIA");

            entity.Property(e => e.UsuarioElimina)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("USUARIO_ELIMINA");

            entity.Property(e => e.UsuarioModifica)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("USUARIO_MODIFICA");

            entity.Property(e => e.UsuarioRegistra)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("USUARIO_REGISTRA");

            entity.Property(e => e.ViaSalida)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("VIA_SALIDA");

            entity.Property(e => e.CorrelativoProtocolo)
                .HasColumnName("CORRELATIVO_PROTOCOLO");

            entity.HasOne(d => d.CodigoCargoNavigation)
                .WithMany(p => p.MdcgAcreditaciones)
                .HasForeignKey(d => d.CodigoCargo)
                .HasConstraintName("MDCG_ACREDITACIONES_FK_CARGO");

            entity.HasOne(d => d.CodigoFuncionarioNavigation)
                .WithMany(p => p.MdcgAcreditaciones)
                .HasForeignKey(d => d.CodigoFuncionario)
                .HasConstraintName("MDCG_ACREDITACIONES_FK");

            entity.HasOne(d => d.CodigoMisionNavigation)
                .WithMany(p => p.MdcgAcreditaciones)
                .HasForeignKey(d => d.CodigoMision)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("MDCG_ACREDITACIONES_FK_MISION");

            entity.HasOne(d => d.CodigoTipoAcreditacionNavigation)
                .WithMany(p => p.MdcgAcreditaciones)
                .HasForeignKey(d => d.CodigoTipoAcreditacion)
                .HasConstraintName("MDCG_ACREDITACIONES_FK_TIPO_ACREDITACION");

            entity.HasOne(d => d.CodigoTratamientoNavigation)
                .WithMany(p => p.MdcgAcreditaciones)
                .HasForeignKey(d => d.CodigoTratamiento)
                .HasConstraintName("MDCG_ACREDITACIONES_FK_TRATAMIENTO");

            entity.HasOne(d => d.EstadoNavigation)
                .WithMany(p => p.MdcgAcreditaciones)
                .HasForeignKey(d => d.Estado)
                .HasConstraintName("MDCG_ACREDITACIONES_FK_ESTADO");
        }
    }
}
