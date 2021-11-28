using DataAccess.DBContexts.IDBContracts;
using DataAccess.Entities.MDCG_Entities;
using DataAccess.MDCG_Repositories.MDCG_RepositoriesContracts.MDCG;
using DataAccess.RepositoryBase;


namespace DataAccess.MDCG_Repositories.MDCG
{
    public class MDCG_TIPO_ACREDITACION_REPO : RepositoryBase<MdcgTipoAcreditacion>, IMDCG_TIPO_ACREDITACION_REPO
    {
        private readonly IMDCG_DBContext _DBContext;

        public MDCG_TIPO_ACREDITACION_REPO(IMDCG_DBContext dbContext) : base(dbContext)
        {
            _DBContext = dbContext;
        }
    }
}
