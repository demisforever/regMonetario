using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

namespace reg_monetario.Datos
{
    public class Conexion
    {
        //C:\Users\Demisgero\Documents\reg-monetario1.0\reg-monetario\Datos\reg-mon1.0.s3db";
        public static string cadena = @"Data Source=reg-mon1.0.s3db";
        //public static string cadena = @"Data Source=reg-mon1.0Ruth.s3db";
        //public static string cadena = @"Data Source=reg-mon-en.s3db";
        private static SQLiteConnection connection = new SQLiteConnection(Conexion.cadena);
        private static Boolean blockConexion = false;

        public static void OpenConexion()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public static void CloseConexion()
        {
            if (!blockConexion)
                connection.Close();
        }

        public static Boolean BlockConexion
        {
            set { blockConexion = value; }
            get { return blockConexion; }
        }

        public static SQLiteConnection Connection
        {
            set { connection = value; }
            get { return connection; }
        }
    }
}
