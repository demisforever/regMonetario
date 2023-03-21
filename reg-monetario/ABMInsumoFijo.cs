using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using reg_monetario.Clases;
using reg_monetario.Datos;

namespace reg_monetario
{
    public partial class ABMInsumoFijo : Form
    {
        public ABMInsumoFijo()
        {
            InitializeComponent();

            CargarListadeDatos();
            
        }

        private void CargarListadeDatos()
        {
            foreach (InsumoFijo iFij in DatosInsumoFijo.GetAll())
            {
                if (iFij.IdInsumoFijo > 1)//este filtro es para que en el combobox no nos muestre el insumoFijo 1 que es "-"
                    insumoFijoBindingSource.Add(iFij);
            }
        }//cargamos la BindingSource para cargar la grilla

        //cargamos un insumo fijo
        private void GuardarInsFij_Click_1(object sender, EventArgs e)
        {
            if (btnGuardarInsFij.Text == "Guardar")
            {
                InsumoFijo infi = new InsumoFijo();
                infi.Nombre = txtBInsFijos.Text;
                DatosInsumoFijo.Save(infi);
                txtBInsFijos.Clear();//cuando precionamos "guardar" se limpia el inbox
            }
            else
            {
                InsumoFijo insFij = (InsumoFijo)InsumosFdataGridView1.CurrentRow.DataBoundItem;
                insFij.Nombre = txtBInsFijos.Text;
                DatosInsumoFijo.Update(insFij);

                btnGuardarInsFij.Text = "Guardar";
                txtBInsFijos.Clear();
            }

            //actualizamos la lista
            insumoFijoBindingSource.Clear();//limpiamos la lista
            CargarListadeDatos();//y la volvemos a cargar, entonces se actualiza la lista
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            //el seguiente metodo toma el objeto InsumoFijo que esta seleccionado en la datagrid
            InsumoFijo insFij = (InsumoFijo)InsumosFdataGridView1.CurrentRow.DataBoundItem;

            //ahora comparamos la id seleccionada para validar que lo que queremos seleccionar no esta siendo utilizado
            bool utilizado = false;
            int cant = 0;
            foreach (Gasto g in DatosGasto.GetAll())
            {
                if (g.InsumoFijo.IdInsumoFijo == insFij.IdInsumoFijo)//si encontramos un insumoFijo que esta siendo utilizado, "utilizado" es falsa
                {
                    cant = cant + 1;
                    utilizado = true;
                }
            }

            if (utilizado)
            {
                MessageBox.Show(insFij.Nombre + " no puede ser eliminado, estas siendo utilizado " + cant + " veces");
            }
            else
            {
                if (MessageBox.Show("Esta seguro que desea eliminar a " + insFij.Nombre, "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    DatosInsumoFijo.Delete(insFij);

                    //actualizamos la lista
                    insumoFijoBindingSource.Clear();//limpiamos la lista
                    CargarListadeDatos();//y la volvemos a cargar, entonces se actualiza la lista
                }
            }
        }

        private void InsumosFdataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            InsumoFijo insFij = (InsumoFijo)InsumosFdataGridView1.CurrentRow.DataBoundItem;

            txtBInsFijos.Text = insFij.Nombre;

            btnGuardarInsFij.Text = "Guardar Modific";
        }


    }
}
