using DataAccess.Entities.Generales;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntitiesConfig.General
{
    public class GlobParentescoConfig
    {
        public static void SetEntityBuilder(EntityTypeBuilder<GlobParentesco> entity)
        {
            entity.HasKey(e => e.code)
                .HasName("GLOB_PARENTESCO_PK");

            entity.ToTable("GLOB_PARENTESCO", "glob");

            entity.Property(e => e.code)
                .HasColumnName("CODIGO");

            entity.Property(e => e.name)
                .HasColumnName("NOMBRE");

            entity.Property(e => e.descripcion)
                .HasColumnName("DESCRIPCION");
        }
    }
}
