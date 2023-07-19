using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace reg_monetario.Clases
{
    public class Gasto
    {
        int id;
        double costo;
        DateTime fecha;
        string insumoVariable;
        string currency;
        InsumoFijo insumoFijo;
        int personId;

        public Gasto()
        {
        }

        public Gasto(int id, double costo, DateTime fecha, string insumoVariable, string currency, InsumoFijo insumoFijo, int personId)
        {
            this.id = id;
            this.costo = costo;
            this.fecha = fecha;
            this.insumoVariable = insumoVariable;
            this.insumoFijo = insumoFijo;
            this.currency = currency;
            this.personId = personId;
        }

        public int Id
        {
            set { id = value; }
            get { return id; }
        }

        public double Costo
        {
            set { costo = value; }
            get { return costo; }
        }

        public DateTime Fecha
        {
            set { fecha = value; }
            get { return fecha; }
        }

        public string InsumoVariable
        {
            set { insumoVariable = value; }
            get { return insumoVariable; }
        }

        public string Currency
        {
            set { currency = value; }
            get { return currency; }
        }

        public InsumoFijo InsumoFijo
        {
            set { insumoFijo = value; }
            get { return insumoFijo; }
        }
        public int PersonId
        {
            set { personId = value; }
            get { return personId; }
        }
    }
}
