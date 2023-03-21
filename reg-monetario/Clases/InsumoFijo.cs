using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace reg_monetario.Clases
{
    public class InsumoFijo
    {
        int idInsumoFijo;
        string nombre;

        public InsumoFijo()
        { }

        public InsumoFijo(int idInsumoFijo, string nombre)
        {
            this.idInsumoFijo = idInsumoFijo;
            this.nombre = nombre;
        }

        public int IdInsumoFijo
        {
            set { idInsumoFijo = value; }
            get { return idInsumoFijo; }
        }

        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }

        public override string ToString()//este metodo es para que en la datagrid de la pantalla principal se pueda ver el nombre del insumo fijo
        {
            return nombre;
        }

    }
}
