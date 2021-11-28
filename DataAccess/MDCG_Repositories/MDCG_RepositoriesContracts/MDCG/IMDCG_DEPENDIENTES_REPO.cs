using DataAccess.Entities.MDCG_Entities;
using DataAccess.RepositoryBase;
using DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.MDCG_Repositories.MDCG_RepositoriesContracts.MDCG
{
    public interface IMDCG_DEPENDIENTES_REPO : IRepositoryBase<MdcgDependiente>
    {
        IEnumerable<Dependientes_VM> getDependienteByCodFuncionario(int codFuncionario);
        DependientesEdit_VM getDependienteById(int codDependiente);
    }
}
