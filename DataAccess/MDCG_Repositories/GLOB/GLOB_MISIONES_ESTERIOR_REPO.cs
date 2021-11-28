using DataAccess.DBContexts.IDBContracts;
using DataAccess.Entities.Generales;
using DataAccess.MDCG_Repositories.MDCG_RepositoriesContracts.GLOB;
using DataAccess.RepositoryBase;


namespace DataAccess.MDCG_Repositories.GLOB
{
    public class GLOB_MISIONES_ESTERIOR_REPO : RepositoryBase<GlobMisionesExterior>, IGLOB_MISIONES_ESTERIOR_REPO
    {
        private readonly IMDCG_DBContext _DBContext;

        public GLOB_MISIONES_ESTERIOR_REPO(IMDCG_DBContext dbContext) : base(dbContext)
        {
            _DBContext = dbContext;
        }
    }
}
