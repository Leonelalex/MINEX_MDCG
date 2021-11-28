using DataAccess.DBContexts.IDBContracts;
using DataAccess.Entities.Generales;
using DataAccess.MDCG_Repositories.MDCG_RepositoriesContracts.GLOB;
using DataAccess.RepositoryBase;


namespace DataAccess.MDCG_Repositories.GLOB
{
    public class GLOB_GRADO_ACADEMICO : RepositoryBase<GlobGradoAcademico>, IGLOB_GRADO_ACADEMICO
    {
        private readonly IMDCG_DBContext _DBContext;

        public GLOB_GRADO_ACADEMICO(IMDCG_DBContext dbContext) : base(dbContext)
        {
            _DBContext = dbContext;
        }
    }
}
