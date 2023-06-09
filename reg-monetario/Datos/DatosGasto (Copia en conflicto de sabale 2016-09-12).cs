﻿using System;
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
            SQLiteCommand cmd = new SQLiteCommand("SELECT idGasto, costo, fecha, insumoVariable, idInsumo FROM Gasto ORDER BY fecha;");
            cmd.Connection = Conexion.Connection;
            SQLiteDataReader obdr = cmd.ExecuteReader();
            Conexion.BlockConexion = true;
            while (obdr.Read())
            {
                Gasto g = new Gasto();
                g.Id = obdr.GetInt32(0);
                g.Costo = obdr.GetInt32(1);
                g.Fecha = obdr.GetDateTime(2);
                try
                {
                    g.InsumoVariable = obdr.GetString(3);
                }
                catch { }
                g.InsumoFijo = DatosInsumoFijo.GetById(obdr.GetInt32(4));
                gastos.Add(g);

            }
            Conexion.BlockConexion = false;
            Conexion.CloseConexion();
            return gastos;
        }

        public static void Save(Gasto gastos)
        {
            Conexion.OpenConexion();
            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Gasto (costo, fecha, insumoVariable, idInsumo) VALUES (@costo, @fecha, @insumoVariable, @idInsumo);");
            cmd.Parameters.Add(new SQLiteParameter("@costo", gastos.Costo));
            cmd.Parameters.Add(new SQLiteParameter("@fecha", gastos.Fecha));
            cmd.Parameters.Add(new SQLiteParameter("@insumoVariable", gastos.InsumoVariable));
            cmd.Parameters.Add(new SQLiteParameter("@idInsumo", gastos.InsumoFijo.IdInsumoFijo));

            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
            Conexion.CloseConexion(); 
        }
        //creamos un nuevo save donde nos gurda un 1 en "idInsumoFijo", el id 1 hace referencia a INSUMO VARIABLE
        public static void SaveVariable(Gasto gastos)
        {
            Conexion.OpenConexion();
            SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Gasto (costo, fecha, insumoVariable, idInsumo) VALUES (@costo, @fecha, @insumoVariable, 1);");
            cmd.Parameters.Add(new SQLiteParameter("@costo", gastos.Costo));
            cmd.Parameters.Add(new SQLiteParameter("@fecha", gastos.Fecha));
            cmd.Parameters.Add(new SQLiteParameter("@insumoVariable", gastos.InsumoVariable));
            //cmd.Parameters.Add(new SQLiteParameter("@idInsumo", gastos.InsumoFijo.IdInsumoFijo));

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
            SQLiteCommand cmd = new SQLiteCommand("UPDATE Gasto SET costo = @costo, fecha = @fecha, insumoVariable = @insumoVariable, idInsumo= @idInsumo WHERE idGasto = @idGasto;");
            cmd.Parameters.Add(new SQLiteParameter("@idGasto", gastos.Id));
            cmd.Parameters.Add(new SQLiteParameter("@costo", gastos.Costo));
            cmd.Parameters.Add(new SQLiteParameter("@fecha", gastos.Fecha));
            cmd.Parameters.Add(new SQLiteParameter("@insumoVariable", gastos.InsumoVariable));
            cmd.Parameters.Add(new SQLiteParameter("@idInsumo", gastos.InsumoFijo.IdInsumoFijo));

            cmd.Connection = Conexion.Connection;
            cmd.ExecuteNonQuery();
            Conexion.CloseConexion();
        }


    }
}
