using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ServiceApp.Utils
{
    public static class Constanst
    {
        #region HTTP Codes
        public static int ServerOkCode = 200;
        public static int ServerErrorCode = 500;
        public static int BadRequestCode = 400;
        #endregion

        #region Server Messages
        public static string MISSING_TOKEN_ERROR_MSG = "missing token header";
        public static string TOKEN_ERROR_MSG = "Token Inválido";
        #endregion

        #region Parametros
        public static string BIO_FUNC_PATH = @"C:\MDCG_BiometricFiles\Funcionarios\";
        public static string BIO_DEP_PATH = @"C:\MDCG_BiometricFiles\Dependientes\";
        #endregion
    }
}
