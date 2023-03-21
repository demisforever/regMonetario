using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using reg_monetario.Clases;

namespace reg_monetario.Datos
{
    public class DatosIngreso
    {

        public static List<Ingreso> GetAll()//ordenado por fecha
        {
            List<Ingreso> ingresos = new List<Ingreso>();
            Conexion.OpenConexion();
            SQLiteCommand cmd = new SQLiteCommand("SELECT idIngreso, cantidad, fecha, descripcion, currency, diezmoApartado, idTipo FROM Ingreso ORDER BY fecha;");
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();
            Conexion.BlockConexion = true;
            while (obdr.Read())
            {
                Ingreso i = new Ingreso();
                i.IdIngreso = obdr.GetInt32(0);
                i.Cantidad = obdr.GetFloat(1);
                i.Fecha = obdr.GetDateTime(2);
                try //si no vienen datos en los campos, no salta ningun error
                {
                    i.Descripcion = obdr.GetString(3);
                    i.Currency = obdr.GetString(4);
                }
                catch { }
                i.DiezmoApartado = obdr.GetBoolean(5);
                i.Tipo = DatosTipo.GetById(obdr.GetInt32(6));
                ingresos.Add(i);

            }
            Conexion.BlockConexion = false;
            Conexion.CloseConexion();
            return ingresos;
        }

        public static void Save(Ingreso ingreso)
        {
            Conexion.OpenConexion();
            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Ingreso (cantidad, fecha, descripcion, currency, diezmoApartado, idTipo) VALUES (@cantidad, @fecha, @descripcion, @currency, @diezmoApartado, @idTipo);");
            cmd.Parameters.Add(new SQLiteParameter("@cantidad", ingreso.Cantidad));
            cmd.Parameters.Add(new SQLiteParameter("@fecha", ingreso.Fecha));
            cmd.Parameters.Add(new SQLiteParameter("@descripcion", ingreso.Descripcion));
            cmd.Parameters.Add(new SQLiteParameter("@currency", ingreso.Currency));
            cmd.Parameters.Add(new SQLiteParameter("@diezmoApartado", ingreso.DiezmoApartado));
            cmd.Parameters.Add(new SQLiteParameter("@idTipo", ingreso.Tipo.IdTipo));

            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
            Conexion.CloseConexion(); 
        }

        public static void Delete(Ingreso ingreso)
        {
            Conexion.OpenConexion();
            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM Ingreso WHERE idIngreso = @idIngreso");
            cmd.Parameters.Add(new SQLiteParameter("@idIngreso", ingreso.IdIngreso));
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
            Conexion.CloseConexion();
        }

        public static void Update(Ingreso ingresos)
        {
            Conexion.OpenConexion();
            SQLiteCommand cmd = new SQLiteCommand("UPDATE Ingreso SET cantidad = @cantidad, fecha = @fecha, idTipo = @idTipo, descripcion = @descripcion, currency = @currency, diezmoApartado = @diezmoApartado WHERE idIngreso = @idIngreso;");
            cmd.Parameters.Add(new SQLiteParameter("@idIngreso", ingresos.IdIngreso));
            cmd.Parameters.Add(new SQLiteParameter("@cantidad", ingresos.Cantidad));
            cmd.Parameters.Add(new SQLiteParameter("@fecha", ingresos.Fecha));
            cmd.Parameters.Add(new SQLiteParameter("@idTipo", ingresos.Tipo.IdTipo));
            cmd.Parameters.Add(new SQLiteParameter("@descripcion", ingresos.Descripcion));
            cmd.Parameters.Add(new SQLiteParameter("@currency", ingresos.Currency));
            cmd.Parameters.Add(new SQLiteParameter("@diezmoApartado", ingresos.DiezmoApartado));

            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
            Conexion.CloseConexion();
        }

    }
}
