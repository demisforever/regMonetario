using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using reg_monetario.Clases;

namespace reg_monetario.Datos
{
    public class DatosTipo
    {

        public static List<Tipo> GetAll()
        {
            List<Tipo> tipos = new List<Tipo>();
            Conexion.OpenConexion();
            SQLiteCommand cmd = new SQLiteCommand("SELECT idTipo, nombre FROM Tipo;");
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();
            Conexion.BlockConexion = true;
            while (obdr.Read())
            {
                Tipo t = new Tipo();
                t.IdTipo = obdr.GetInt32(0);
                t.Nombre = obdr.GetString(1);
                tipos.Add(t);
            }
            Conexion.BlockConexion = false;
            Conexion.CloseConexion();
            return tipos;
        }

        public static Tipo GetById(int idTipo)
        {
            Tipo tipo = new Tipo();
            Conexion.OpenConexion();
            SQLiteCommand cmd = new SQLiteCommand("SELECT idTipo, nombre FROM Tipo WHERE idTipo = @idTipo;");
            cmd.Parameters.Add(new SQLiteParameter("@idTipo", idTipo));
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();
            while (obdr.Read())
            {
                tipo = new Tipo(obdr.GetInt32(0), obdr.GetString(1));
            }
            Conexion.CloseConexion();
            return tipo;
        }

        public static void Save(Tipo tipo)
        {
            Conexion.OpenConexion();
            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Tipo ( nombre ) VALUES ( @nombre );");
            cmd.Parameters.Add(new SQLiteParameter("@nombre", tipo.Nombre));
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
            Conexion.CloseConexion();
        }

        public static void Delete(Tipo tipo)
        {
            Conexion.OpenConexion();
            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM Tipo WHERE idTipo = @idTipo");
            cmd.Parameters.Add(new SQLiteParameter("@idTipo", tipo.IdTipo));
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
            Conexion.CloseConexion();
        }

    }
}
