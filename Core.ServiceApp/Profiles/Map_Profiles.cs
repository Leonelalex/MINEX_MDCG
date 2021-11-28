using AutoMapper;
using Core.ServiceApp.Requests;
using Core.ServiceApp.Responses;
using DataAccess.Entities.Generales;
using DataAccess.Entities.MDCG_Entities;

namespace Core.ServiceApp.Profiles
{
    public class Map_Profiles
    {
        public Map_Profiles()
        {
            //mapeamos el modelo con nuestro DTO
        }
    }

    #region Mapeo Catalogos
    public class Genero_Profile : Profile
    {
        public Genero_Profile()
        {
            CreateMap<GlobGenero, GenericCatalog>();
        }
    }

    public class EstadoCivil_Profile : Profile
    {
        public EstadoCivil_Profile()
        {
            CreateMap<GlobEstadoCivil, GenericCatalog>();
        }
    }

    public class Pais_Profile : Profile
    {
        public Pais_Profile()
        {
            CreateMap<GlobPais, GenericCatalog>();
        }
    }

    public class TipoPasaporte_Profile : Profile
    {
        public TipoPasaporte_Profile()
        {
            CreateMap<GlobTipoPasaporte, GenericCatalog>();
        }
    }

    public class TipoFuncionario_Profile : Profile
    {
        public TipoFuncionario_Profile()
        {
            CreateMap<GlobTipoFuncionario, GenericCatalog>();
        }
    }

    public class GradoAcademico_Profile : Profile
    {
        public GradoAcademico_Profile()
        {
            CreateMap<GlobGradoAcademico, GenericCatalog>();
        }
    }

    public class TipoLicencia_Profile : Profile
    {
        public TipoLicencia_Profile()
        {
            CreateMap<GlobtipoLicencia, GenericCatalog>();
        }
    }

    public class Parentesco_Profile : Profile
    {
        public Parentesco_Profile()
        {
            CreateMap<GlobParentesco, GenericCatalog>();
        }
    }

    public class MisionesExterior_Profile : Profile
    {
        public MisionesExterior_Profile()
        {
            CreateMap<GlobMisionesExterior, MisionCatalog>();
        }
    }

    public class TipoAcreditaciones_Profile : Profile
    {
        public TipoAcreditaciones_Profile()
        {
            CreateMap<MdcgTipoAcreditacion, GenericCatalog>();
        }
    }

    public class Tratamiento_Profile : Profile
    {
        public Tratamiento_Profile()
        {
            CreateMap<GlobTratamiento, GenericCatalog>();
        }
    }

    public class Cargo_Profile : Profile
    {
        public Cargo_Profile()
        {
            CreateMap<MdcgCargo, GenericCatalog>();
        }
    }
#endregion

    public class FuncionarioEdit_Profile : Profile
    {
        public FuncionarioEdit_Profile()
        {
            CreateMap<FuncionarioEdit_Req, MdcgFuncionario>();
            CreateMap<MdcgFuncionario, FuncionarioEdit_Req>();
        }
    }

    public class DependienteEdit_Profile : Profile
    {
        public DependienteEdit_Profile()
        {
            CreateMap<DependienteEdit_Req, MdcgDependiente>();
            CreateMap<MdcgDependiente, DependienteEdit_Req>();
        }
    }

    public class AcreditacionEdit_Profile : Profile
    {
        public AcreditacionEdit_Profile()
        {
            CreateMap<AcreditacionEdit_Req, MdcgAcreditaciones>();
            CreateMap<MdcgAcreditaciones, AcreditacionEdit_Req>();
        }
    }

    public class Dependiente_Profile : Profile
    {
        public Dependiente_Profile()
        {
            CreateMap<Dependientes_Req, MdcgDependiente>();
            CreateMap<MdcgDependiente, Dependientes_Req>();
        }
    }

    public class Acreditaciones_Profile : Profile
    {
        public Acreditaciones_Profile()
        {
            CreateMap<MdcgAcreditaciones, Acreditacion_Req>();
            CreateMap<Acreditacion_Req, MdcgAcreditaciones>();
        }
    }
}
