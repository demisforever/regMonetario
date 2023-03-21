using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace reg_monetario.Clases
{
    public class Tipo
    {
        int idTipo;
        string nombre;

        public Tipo()
        { }

        public Tipo(int idTipo, string nombre)
        {
            this.idTipo = idTipo;
            this.nombre = nombre;
        }

        public int IdTipo
        {
            set { idTipo = value; }
            get { return idTipo; }
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
