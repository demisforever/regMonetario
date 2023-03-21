﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace reg_monetario.Clases
{
    public class Gasto
    {
        int id;
        int costo;
        DateTime fecha;
        string insumoVariable;
        string currency;
        InsumoFijo insumoFijo;

        public Gasto()
        {
        }

        public Gasto(int id, int costo, DateTime fecha, string insumoVariable, string currency, InsumoFijo insumoFijo)
        {
            this.id = id;
            this.costo = costo;
            this.fecha = fecha;
            this.insumoVariable = insumoVariable;
            this.insumoFijo = insumoFijo;
            this.currency = currency;
        }

        public int Id
        {
            set { id = value; }
            get { return id; }
        }

        public int Costo
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
    }
}
