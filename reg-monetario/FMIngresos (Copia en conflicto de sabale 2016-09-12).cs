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
    public partial class FMIngresos : Form
    {
        public FMIngresos()
        {
            InitializeComponent();

            CargarListaTipo();
            CargarComboxAño();
            ListarIngresosUAnio(DateTime.Now.Year);            
        }

        private void ListarIngresosUAnio(int anio)
        {
            ingresoBindingSource.Clear();

            float tot = 0;
            float totDiezmo = 0;
            DateTime fDesdeDiezmo = DateTime.Now;
            foreach (Ingreso i in DatosIngreso.GetAll())
            {
                if (i.Fecha.Year == anio)
                {
                    ingresoBindingSource.Add(i);
                    tot = tot + i.Cantidad;
                }

                //para el diezmo
                if (!i.DiezmoApartado)
                {
                    if (i.Fecha < fDesdeDiezmo)//para notificar la fecha mas vieja del diezmo
                        fDesdeDiezmo = i.Fecha;

                    totDiezmo = totDiezmo + i.Cantidad;
                }
            }
            labelTotal.Text = "Total: $" + tot.ToString();
            lblDiezmo.Text = "$" + (totDiezmo / 10).ToString() + "\n\n\n Desde: \n" + fDesdeDiezmo.ToString();
        }

        private void button1Guardar_Click(object sender, EventArgs e)
        {
            Tipo ti = (Tipo)tipoDataGridView2.CurrentRow.DataBoundItem;

            Ingreso i = new Ingreso();
            i.Fecha = DateTime.Now;
            i.Tipo = ti;//guarda el tipo que esta seleccionado en la datagrid
            i.Descripcion = txtBoxDescripcion.Text;
            i.DiezmoApartado = chkBxDiezmoApartado.Capture;

            if (string.IsNullOrEmpty(textBox1Pesos.Text))
            {
                MessageBox.Show("Tiene que completar el campo campo \"Cantidad $\" con un número entero... ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                i.Cantidad = int.Parse(textBox1Pesos.Text);
                DatosIngreso.Save(i);
            }

            ListarIngresosUAnio(DateTime.Now.Year);
        }

        private void bnEliminar_Click(object sender, EventArgs e)
        {
            Ingreso i = (Ingreso)IngresosdataGridView.CurrentRow.DataBoundItem;

            if (MessageBox.Show("Esta seguro que decea eliminar " + i.Fecha + " " + i.Tipo.Nombre + " de $" + i.Cantidad, "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                DatosIngreso.Delete(i);
            }

            ingresoBindingSource.Clear();
            ListarIngresosUAnio(i.Fecha.Year);
        }

        //modificacion de un ingreso
        private void IngresosdataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnModifIngreso.Visible = true;
        }

        private void btnModifIngreso_Click(object sender, EventArgs e)
        {
            Ingreso i = (Ingreso)IngresosdataGridView.CurrentRow.DataBoundItem; //guarda el objeto seleccionado
            DatosIngreso.Update(i);

            ListarIngresosUAnio(i.Fecha.Year);
            btnModifIngreso.Visible = false;
        }




        /// ////////////////////////////////// ABM TIPO ///////////////////////////////////////////////////////////////////////////////////
        private void CargarListaTipo()
        {
            tipoBindingSource.Clear();

            foreach (Tipo t in DatosTipo.GetAll())
                tipoBindingSource.Add(t);
        }

        //btn Modificar el tipo de ingreso (no el ingreso)
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (btnModificar.Text == "Modificar Información")
            {
                //se pone en accesible para modificar
                textBoxTipo.Visible = true;
                btnEliminTipo.Visible = true;
                btnGuardarTipo.Visible = true;
                btnModificar.Text = "Terminar Modificación";
            }
            else
            {
                //se anula accesible para modificar
                textBoxTipo.Visible = false;
                btnEliminTipo.Visible = false;
                btnGuardarTipo.Visible = false;
                btnModificar.Text = "Modificar Información";
            }
        }

        //btn guardat TIPO
        private void btnGuardarTipo_Click(object sender, EventArgs e)
        {
            Tipo t = new Tipo();
            t.Nombre = textBoxTipo.Text;
            DatosTipo.Save(t);

            textBoxTipo.Clear();//limpiamos
            //ListarIngresosUAnio(DateTime.Now.Year);
        }

        private void btnEliminTipo_Click(object sender, EventArgs e)
        {
            //el seguiente metodo toma el objeto Tipo que esta seleccionado en la datagrid
            Tipo ti = (Tipo)tipoDataGridView2.CurrentRow.DataBoundItem;

            //ahora comparamos la id seleccionada para validar que lo que queremos seleccionar no esta siendo utilizado
            bool utilizado = false;
            foreach (Ingreso i in DatosIngreso.GetAll())
            {
                if (ti.IdTipo == i.Tipo.IdTipo)
                    utilizado = true;
            }

            if (utilizado)
                MessageBox.Show(ti.Nombre + " no puede ser eliminado, estas siendo utilizado");
            else
            {
                if (MessageBox.Show("Esta seguro que decea eliminar a " + ti.Nombre, "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                {
                    DatosTipo.Delete(ti);
                    CargarListaTipo();
                }
            }
        }

        //cargamos los años 
        private void CargarComboxAño()
        {
            List<int> año = new List<int>();//variables que cargaremos con la lista de año

            int a = 0;
            foreach (Ingreso i in DatosIngreso.GetAll())
            {
                if (a != i.Fecha.Date.Year)//para no repetir los años
                {
                    a = i.Fecha.Date.Year;
                    año.Add(i.Fecha.Date.Year);
                }
            }
            comboBoxAño.DataSource = año;
        }

        private void comboBoxAño_SelectedIndexChanged(object sender, EventArgs e)
        {
            string n = comboBoxAño.SelectedValue.ToString();
            ListarIngresosUAnio(int.Parse(n));
        }

                


    }
}
