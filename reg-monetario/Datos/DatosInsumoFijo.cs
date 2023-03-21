using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using reg_monetario.Clases;

namespace reg_monetario.Datos
{
    public class DatosInsumoFijo
    {
        public static List<InsumoFijo> GetAll()
        {
            List<InsumoFijo> insumosFijos = new List<InsumoFijo>();
            Conexion.OpenConexion();
            SQLiteCommand cmd = new SQLiteCommand("SELECT IdInsumoFijo, nombre FROM InsumoFijo ORDER BY nombre;");
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();
            Conexion.BlockConexion = true;
            while (obdr.Read())
            {
                InsumoFijo ins = new InsumoFijo();
                ins.IdInsumoFijo = obdr.GetInt32(0);
                ins.Nombre = obdr.GetString(1);
                insumosFijos.Add(ins);
            }
            Conexion.BlockConexion = false;
            Conexion.CloseConexion();
            return insumosFijos;
        }

        public static InsumoFijo GetById(int idInsumoFijo)
        {
            InsumoFijo insFij = new InsumoFijo();
            Conexion.OpenConexion();
            SQLiteCommand cmd = new SQLiteCommand("SELECT IdInsumoFijo, nombre FROM InsumoFijo WHERE idInsumoFijo = @idInsumoFijo;");
            cmd.Parameters.Add(new SQLiteParameter("@idInsumoFijo", idInsumoFijo));
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();
            while (obdr.Read())
            {
                insFij = new InsumoFijo(obdr.GetInt32(0), obdr.GetString(1));
            }
            Conexion.CloseConexion();
            return insFij;
        }

        public static void Save(InsumoFijo insumoFijo)
        {
            Conexion.OpenConexion();
            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO InsumoFijo ( nombre ) VALUES ( @nombre );");
            cmd.Parameters.Add(new SQLiteParameter("@nombre", insumoFijo.Nombre));
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
            Conexion.CloseConexion();
        }

        public static void Delete(InsumoFijo insumoFijo)
        {
            Conexion.OpenConexion();
            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM InsumoFijo WHERE idInsumoFijo = @idInsumoFijo");
            cmd.Parameters.Add(new SQLiteParameter("@idInsumoFijo", insumoFijo.IdInsumoFijo));
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
            Conexion.CloseConexion();
        }

        public static void Update(InsumoFijo insumoFijo)
        {
            Conexion.OpenConexion();
            SQLiteCommand cmd = new SQLiteCommand("UPDATE InsumoFijo SET nombre = @nombre WHERE idInsumoFijo = @idInsumoFijo;");
            cmd.Parameters.Add(new SQLiteParameter("@idInsumoFijo", insumoFijo.IdInsumoFijo));
            cmd.Parameters.Add(new SQLiteParameter("@nombre", insumoFijo.Nombre));

            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
            Conexion.CloseConexion();
        }

    }
}
