using DataAccess.DBContexts.IDBContracts;
using DataAccess.Entities.MDCG_Entities;
using DataAccess.MDCG_Repositories.MDCG_RepositoriesContracts.MDCG;
using DataAccess.RepositoryBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.MDCG_Repositories.MDCG
{
    public class MDCG_CARGO_REPO : RepositoryBase<MdcgCargo>, IMDCG_CARGO_REPO
    {
        private readonly IMDCG_DBContext _DBContext;

        public MDCG_CARGO_REPO(IMDCG_DBContext dbContext) : base(dbContext)
        {
            _DBContext = dbContext;
        }
    }
}
