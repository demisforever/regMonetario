using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using reg_monetario.Clases;

namespace reg_monetario.Datos
{
    public class DatosGasto
    {
        /**
         *agregamos un try y un catch para los campos que estan nulos
         *en este  caso agregamos para g.InsumoVariable = obdr.GetString(3); 
         **/
        public static List<Gasto> GetAll()//ordenado por fecha
        {
            List<Gasto> gastos = new List<Gasto>();
            Conexion.OpenConexion();
            SQLiteCommand cmd = new SQLiteCommand("SELECT idGasto, costo, fecha, insumoVariable, currency, idInsumo, personId FROM Gasto ORDER BY fecha;");
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();
            Conexion.BlockConexion = true;
            while (obdr.Read())
            {
                Gasto g = new Gasto();
                g.Id = obdr.GetInt32(0);
                g.Costo = obdr.GetDouble(1);
                g.Fecha = obdr.GetDateTime(2);
                try //si no vienen datos en los campos, no salta ningun error
                {
                    g.InsumoVariable = obdr.GetString(3);
                    g.Currency = obdr.GetString(4);
                }
                catch { }
                g.InsumoFijo = DatosInsumoFijo.GetById(obdr.GetInt32(5));
                g.PersonId = obdr.GetInt32(6);
                gastos.Add(g);
            }
            Conexion.BlockConexion = false;
            Conexion.CloseConexion();
            return gastos;
        }

        public static List<Gasto> GetGastoByAttributes(string insFijo, string year, string month, string description, string currency, decimal cost)
        {
            List<Gasto> gastos = new List<Gasto>();
            Conexion.OpenConexion();
            string query = "SELECT idGasto, costo, fecha, insumoVariable, currency, idInsumo, personId FROM Gasto WHERE currency = @currency AND strftime('%Y-%m', fecha) = @yearmonth";
            month = month.Length == 1 ? "0"+month : month; //agregmos el 0 adelante si es una sola sifra

            if (insFijo.Length > 0) {
                query += " AND idInsumo = @insFijo";
            }
            if (description.Length > 0) {
                query += " AND insumoVariable = @description";
            }
            if (cost != 00)
            {
                query += " AND costo = @cost";
            }
            query += " ORDER BY fecha;"; //ordenado por fecha
            SQLiteCommand cmd = new SQLiteCommand(query);
            cmd.Parameters.Add(new SQLiteParameter("@insFijo", insFijo));
            cmd.Parameters.Add(new SQLiteParameter("@yearmonth", year + "-" + month));
            cmd.Parameters.Add(new SQLiteParameter("@description", description));
            cmd.Parameters.Add(new SQLiteParameter("@currency", currency));
            cmd.Parameters.Add(new SQLiteParameter("@cost", cost));
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();
            Conexion.BlockConexion = true;
            while (obdr.Read())
            {
                Gasto g = new Gasto();
                g.Id = obdr.GetInt32(0);
                g.Costo = obdr.GetDouble(1);
                g.Fecha = obdr.GetDateTime(2);
                try //si no vienen datos en los campos, no salta ningun error
                {
                    g.InsumoVariable = obdr.GetString(3);
                    g.Currency = obdr.GetString(4);
                }
                catch { }
                g.InsumoFijo = DatosInsumoFijo.GetById(obdr.GetInt32(5));
                g.PersonId = obdr.GetInt32(6);
                gastos.Add(g);

            }
            Conexion.BlockConexion = false;
            Conexion.CloseConexion();
            return gastos;
        }

        public static void Save(Gasto gastos)
        {
            Conexion.OpenConexion();
            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Gasto (costo, fecha, insumoVariable, currency, idInsumo, personId) VALUES (@costo, @fecha, @insumoVariable, @currency, @idInsumo, @personId);");
            cmd.Parameters.Add(new SQLiteParameter("@costo", gastos.Costo));
            cmd.Parameters.Add(new SQLiteParameter("@fecha", gastos.Fecha));
            cmd.Parameters.Add(new SQLiteParameter("@insumoVariable", gastos.InsumoVariable));
            cmd.Parameters.Add(new SQLiteParameter("@currency", gastos.Currency));
            cmd.Parameters.Add(new SQLiteParameter("@idInsumo", gastos.InsumoFijo.IdInsumoFijo));
            cmd.Parameters.Add(new SQLiteParameter("@personId", gastos.PersonId));

            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
            Conexion.CloseConexion(); 
        }

        public static void Delete(Gasto gastos)
        {
            Conexion.OpenConexion();
            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM Gasto WHERE idGasto = @idGasto");
            cmd.Parameters.Add(new SQLiteParameter("@idGasto", gastos.Id));
            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
            Conexion.CloseConexion();
        }

        public static void Update(Gasto gastos)
        {
            Conexion.OpenConexion();
            SQLiteCommand cmd = new SQLiteCommand("UPDATE Gasto SET costo = @costo, fecha = @fecha, insumoVariable = @insumoVariable, currency = @currency, idInsumo = @idInsumo, personId = @personId WHERE idGasto = @idGasto;");
            cmd.Parameters.Add(new SQLiteParameter("@idGasto", gastos.Id));
            cmd.Parameters.Add(new SQLiteParameter("@costo", gastos.Costo));
            cmd.Parameters.Add(new SQLiteParameter("@fecha", gastos.Fecha));
            cmd.Parameters.Add(new SQLiteParameter("@insumoVariable", gastos.InsumoVariable));
            cmd.Parameters.Add(new SQLiteParameter("@currency", gastos.Currency));
            cmd.Parameters.Add(new SQLiteParameter("@idInsumo", gastos.InsumoFijo.IdInsumoFijo));
            cmd.Parameters.Add(new SQLiteParameter("@personId", gastos.PersonId));

            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
            Conexion.CloseConexion();
        }


    }
}
