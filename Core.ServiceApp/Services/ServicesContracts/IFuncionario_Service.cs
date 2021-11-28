using Core.ServiceApp.Requests;
using Core.ServiceApp.Utils;
using DataAccess.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ServiceApp.Services.ServicesContracts
{
    public interface IFuncionario_Service
    {
        Task<Response> CrearFuncionario(Funcionario_Req funcionario);
        Task<Response> GetFuncionarios(PaginationFilter filter);
        Task<Response> GetFuncionarioById(int code);
        Task<Response> EditarFuncionario(int code, FuncionarioEdit_Req funcInfo);
        Task<Response> GuardarBiometricos(int codFuncionario, Biometricos_Req biometricos);
        Task<Response> getBiometricos(int codFuncionario);
        Task<Response> editarBiometricos(int codFuncionario, Biometricos_Req biometricos);
    }
}
