using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace reg_monetario.Clases
{
    public class Ingreso
    {
        int idIngresos;
        float cantidad;
        DateTime fecha;
        string descripcion;
        string currency;
        Tipo tipo;
        bool diezmoApartado;

        public Ingreso()
        {
        }

        public Ingreso(int idIngresos, float cantidad, DateTime fecha, string descripcion, string currency, Tipo tipo, bool diezmoApartado)
        {
            this.idIngresos = idIngresos;
            this.cantidad = cantidad;
            this.fecha = fecha;
            this.tipo = tipo;
            this.descripcion = descripcion;
            this.currency = currency;
            this.diezmoApartado = diezmoApartado;
        }

        public int IdIngreso
        {
            set { idIngresos = value; }
            get { return idIngresos; }
        }

        public float Cantidad
        {
            set { cantidad = value; }
            get { return cantidad; }
        }

        public DateTime Fecha
        {
            set { fecha = value; }
            get { return fecha; }
        }

        public string Descripcion
        {
            set { descripcion = value; }
            get { return descripcion; }
        }

        public string Currency
        {
            set { currency = value; }
            get { return currency; }
        }

        public Tipo Tipo
        {
            set { tipo = value; }
            get { return tipo; }
        }

        public bool DiezmoApartado
        {
            set { diezmoApartado = value; }
            get { return diezmoApartado; }
        }

    }
}
