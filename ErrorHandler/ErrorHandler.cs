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

        protected clsErrorHandler() { }

        #endregion

        #region Check Error
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
                case "SqlException":
                    return "";
                default:
                    return e.Message;
            }
        }
        #endregion

        #region Translate Error
        public string translateError(string msg)
        {

            if (msg.Equals(""))
                return string.Empty;

            msg = msg.ToLower();

            if (msg.IndexOf("cannot insert duplicate key") > -1)
                return "Se produjo un error en la Base de Datos. La información primaria ingresada ya ha sido almacenada.";

            if (msg.IndexOf("string or binary data would be truncated") > -1)
                return "Se produjo un error en la Base de Datos. La cantidad de caracteres ingresados es mayor a la permitida.";

            if (msg.IndexOf("cannot insert duplicate key row") > -1)
                return "Se produjo un error en la Base de Datos. La información ingresada ya ha sido almacenada.";

            if (msg.IndexOf("cannot open database") > -1)
                return "No se puede accesar a la Base de Datos";

            if (msg.IndexOf("invalid object name") > -1)
                return "Se produjo un error en la Base de Datos. El objeto " + msg.Substring(24) + " no existe.";

            if (msg.IndexOf("conversion from type DBNull to type String is not valid.") > -1)
                return "Se produjo un error al tratar de convertir un valor de cadena a null";

            if (msg.IndexOf("invalid column name") > -1)
            {
                msg = msg.Replace("invalid column name", "").Trim();
                string columnas = msg.Split('.').AsEnumerable().Aggregate((x, y) => x + y).Replace(" ", ", ");
                return "La(s) columna(s) " + columnas + " no existe(n) en la Base de Datos";
            }

            if (msg.IndexOf("object reference not set to an instance of an object") > -1)
                return "Error en el Servidor. Se hizo referencia a un objeto inexistente.";

            if (msg.IndexOf("column does not allow nulls") > -1)
                return "Se produjo un error en la Base de Datos. Se trato de almacenar un valor nulo en una columna que no lo permite.";

            if (msg.IndexOf("there is no row at position 0") > -1)
                return "Error en el Servidor procesando la información.";

            if (msg.IndexOf("a connection that was expected to be kept alive was closed by the server.") > -1)
                return "Se perdio la conexión con el Servidor de Base de Datos.";

            if (msg.IndexOf("could not find file") > -1)
            {
                msg = msg.Replace("could not find file", "");
                return "No se encontro el archivo en la ruta " + msg.Substring(msg.IndexOf(@":/") + 2);
            }

            if (msg.IndexOf("incorrect syntax near") > -1)
                return "Se produjo un error en la Base de Datos. Se ejecuto una sentencia incorrecta en la Base de Datos.";

            if (msg.IndexOf("conversion of a varchar data type to a datetime") > -1)
                return "Se produjo un error en la Base de Datos. Formato incorrecto en el valor a convertir a fecha.";

            if (msg.IndexOf("does not belong to table") > -1)
            {
               // falta mejorar esta parte, debo sacar los caracteres de la palabra column (5) y de ahi sacar el primer espacio vacio para obtener el nombre de la columna
                int start = 5;
                int end = msg.IndexOf("does");
                string colunm = 
                msg = msg.Replace("does not belong to table", "");

                return "Se produjo un error en la Base de Datos. La columna" + "" + " no existe. Debe crearla para poder continuar.";
            }

            if (msg.IndexOf("The multi-part identifier") > -1)
                return "Se produjo un error en la Base de Datos. La sentencia para obtener la información esta mal elaborada.";

            if (msg.IndexOf("") > -1)
                return "";

            if (msg.IndexOf("") > -1)
                return "";

            if (msg.IndexOf("") > -1)
                return "";

            return msg;
        }
        #endregion

    }
}

