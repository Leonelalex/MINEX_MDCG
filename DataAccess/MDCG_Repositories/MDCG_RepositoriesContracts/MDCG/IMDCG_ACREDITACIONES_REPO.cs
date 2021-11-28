using DataAccess.Entities.MDCG_Entities;
using DataAccess.RepositoryBase;
using DataAccess.ViewModels;
using System.Collections.Generic;

namespace DataAccess.MDCG_Repositories.MDCG_RepositoriesContracts.MDCG
{
    public interface IMDCG_ACREDITACIONES_REPO : IRepositoryBase<MdcgAcreditaciones>
    {
        IEnumerable<Acreditaciones_VM> GetAcreditacionesByCodeFuncionario(int codFuncionario);
        AcreditacionesEdit_VM GetAcreditacionById(int codAcreditacion);
        bool AcreditacionActiva(int codFuncionario);
        IEnumerable<Acreditaciones_VM> GetBandejaRecepcion();
    }
}
