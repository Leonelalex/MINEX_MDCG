using DataAccess.DBContexts.IDBContracts;
using DataAccess.Entities.Generales;
using DataAccess.MDCG_Repositories.MDCG_RepositoriesContracts.GLOB;
using DataAccess.RepositoryBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.MDCG_Repositories.GLOB
{
    public class GLOB_TIPO_PASAPORTE_REPO : RepositoryBase<GlobTipoPasaporte>, IGLOB_TIPO_PASAPORTE_REPO
    {
        private readonly IMDCG_DBContext _DBContext;

        public GLOB_TIPO_PASAPORTE_REPO(IMDCG_DBContext dbContext) : base(dbContext)
        {
            _DBContext = dbContext;
        }
    }
}
