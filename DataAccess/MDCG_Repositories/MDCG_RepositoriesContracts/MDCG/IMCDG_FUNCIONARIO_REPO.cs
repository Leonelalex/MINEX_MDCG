using DataAccess.Entities.MDCG_Entities;
using DataAccess.Helpers;
using DataAccess.RepositoryBase;
using DataAccess.ViewModels;
using System.Collections.Generic;

namespace DataAccess.MDCG_Repositories.MDCG_RepositoriesContracts.MDCG
{
    public interface IMCDG_FUNCIONARIO_REPO : IRepositoryBase<MdcgFuncionario>
    {
        IEnumerable<Funcionarios_VM> getAllFuncionarios();
        IEnumerable<Funcionarios_VM> getFuncionarios(PaginationFilter filter);
        int countFuncionarios();
        FuncionarioEdit_VM getFuncionarioById(int id);
    }
}
