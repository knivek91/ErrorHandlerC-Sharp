using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandler
{
    public class clsErrorHandler
    {

        #region Variables 

        private static clsErrorHandler error = null;

        #endregion 

        #region Propiedades

        public static clsErrorHandler getInstancia
        {
            get
            {
                if (error == null) 
                    return new clsErrorHandler(); 
                return error;
            }
        }
        #endregion

        #region Constructor

        protected clsErrorHandler()  { }

        #endregion


        public string checkError(Exception e)
        {
            Type baseEx = e.GetBaseException().GetType();
            string errorName = baseEx.FullName;

            switch (errorName)
            {
                case "System.IndexOutOfRangeException":
                    return "";

                case "System.NullReferenceException":
                    return "";

                case "System.InvalidOperationException":
                    return "";

                case "System.ArgumentNullException":
                    return "";

                case "System.ArgumentOutOfRangeException":
                    return "";
                default:
                    return e.Message;
            }
        }

    }
}

