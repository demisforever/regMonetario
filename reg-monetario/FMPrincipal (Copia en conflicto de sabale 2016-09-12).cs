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
using reg_monetario.Metodos;



namespace reg_monetario
{
    public partial class FMPrincipal : Form
    {
        
        public FMPrincipal()
        {
            InitializeComponent();
            RadioButtonFijo.Checked = true; //se inicializa el programa con insumos fijos activado

            CargarComboxInsumosFijos();

            ListarGastosMesActual();
        }

        //Déficit Superávit
        private void deficitSuperavit(float i, float g)
        {
            if (i > g)
            {
                btnEstadisticas.ForeColor = Color.ForestGreen;
                btnEstadisticas.BackColor = Color.PaleGoldenrod;
                btnEstadisticas.Text = "Superávit";
            }
            else
            {
                btnEstadisticas.ForeColor = Color.Red;
                btnEstadisticas.BackColor = Color.Snow;
                btnEstadisticas.Text = "¡Déficit!";
            }

        }
          

        private void CargarComboxInsumosFijos()//cargamos el combobox de insumos fijos para la carga de gastos
        {
            List<string> insfij = new List<string>();
            foreach (InsumoFijo infi in DatosInsumoFijo.GetAll())
            {
                insfij.Add(infi.Nombre); 
            }
            comboBoxInsFijos.DataSource = insfij;//este es el combobox de la carga de datos
            comboBoxIFijo.DataSource = insfij;//este es el combobox de el manipuleo de la lista
        }


        private void ListarGastosMesActual()
        {
            gastoBindingSource.Clear();//limpiamos la lista

            //cree un nuevo objeto para traer el ultimo de la lista
            Gasto gUltimo = new Gasto();
            gUltimo = DatosGasto.GetAll().Last();

            //en el titulo aparecera la fecha del resumen de cuenta
            labelArribaLista.Text = ("Resumen de la cuenta del mes " + gUltimo.Fecha.Month.ToString() + " del " + gUltimo.Fecha.Year.ToString() + ". Ultimo mes registrado");
            float totGa = 0;

            foreach (Gasto g in DatosGasto.GetAll())//cargamos la datagrid de gastos
            {
                if (g.Fecha.Month == gUltimo.Fecha.Month && g.Fecha.Year == gUltimo.Fecha.Year)
                {
                    gastoBindingSource.Add(g);
                    totGa = totGa + g.Costo;
                }
                
            }
            labelTotal.Text = ("Total: $" + totGa.ToString());

            //calculamos la cantidad que se Ingreso para el calculo deficitSuperavit
            float totIn = 0;
            foreach (Ingreso i in DatosIngreso.GetAll())
            {
                if (i.Fecha.Month == gUltimo.Fecha.Month && i.Fecha.Year == gUltimo.Fecha.Year)
                    totIn = totIn + i.Cantidad;
            }

            deficitSuperavit(totIn, totGa);

            //para el mes y el año de este momento es: DateTime.Now.Month, DateTime.Now.Year.ToString
        }//cargamos la datagrid solo con los gastos del mes actual

        //hacemos click en el radio butom de tipo de insumo
        public void RadioButtonFijo_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButtonFijo.Checked == true)//mientras que en el radiobuttom este seleccionado "Fijo"
            {
                comboBoxInsFijos.Enabled = true; //el combobox de insumos fijos se habilita
                ButtomModificaciones.Enabled = true;//el boton para las modificaciones de insumos fijos se habilita
            }
        }
        public void RadioButtonVariable_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButtonVariable.Checked == true)//mientras que en el radiobuttom este seleccionado "Variable"
            {
                comboBoxInsFijos.Enabled = false; //el combobox de insumos fijos se deshabilita
                ButtomModificaciones.Enabled = false;//el boton para las modificaciones de insumos fijos se deshabilita
            }
            
        }

        //cargar un gasto
        private void button1Guardar_Click(object sender, EventArgs e)
        {
            InsumoFijo inf = DatosInsumoFijo.GetAll()[comboBoxInsFijos.SelectedIndex];
            Gasto g = new Gasto();
            g.Fecha = DateTime.Now;
            g.InsumoVariable = textBox2InVariable.Text;

            if (string.IsNullOrEmpty(textBox1Pesos.Text))//no nulo, el campo de "cantidad"
            {
                MessageBox.Show("Tiene que completar el campo campo \"Cantidad $\" con un número entero... ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                g.Costo = int.Parse(textBox1Pesos.Text);//SelectionStart me cuenta la cantidad de numeros que ingreso

                //creamos las condiciones si es insumo variable o insumo fijo
                if (RadioButtonFijo.Checked)//mientras que en el radiobuttom este seleccionado "Fijo"
                {
                    g.InsumoFijo = inf;

                    if (inf.Nombre == "-")
                        MessageBox.Show("Seleccione un Insumo Fijo que no sea \"-\" ... ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        if (MessageBox.Show("Esta seguro que desea guardar \"" + inf.Nombre + "\" de $" + textBox1Pesos.Text + " en Insumos Fijos?", "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                            DatosGasto.Save(g);

                }
                else//mientras que en el radiobuttom este seleccionado "Variable"
                {
                    g.InsumoVariable = textBox2InVariable.Text;

                    if (string.IsNullOrEmpty(textBox2InVariable.Text))//el campo NO tiene que estar vacio
                    {
                        MessageBox.Show("Tiene que completar el campo campo \"Insumo Variable\" ... ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (MessageBox.Show("Esta seguro que desea guardar \"" + textBox2InVariable.Text + "\" de $" + textBox1Pesos.Text + " en Insumos Variables?", "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                        {
                            DatosGasto.SaveVariable(g);//tuve que hacer un save exclusivo para variables xq en idInsumosFijos teniamos q guardar si o si 1
                        }
                    }

                }
            }

            textBox1Pesos.Clear();//cuando precionamos "guardar" se limpia el inbox
            textBox2InVariable.Clear();//cuando precionamos "guardar" se limpia el inbox

            //actualizamos
            ListarGastosMesActual();//y la volvemos a cargar, entonces se actualiza la lista
        }

        //al hacer doblre clik abilita el btn guardar modificación
        private void GastosdataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnModifGasto.Visible = true;
        }
        private void btnModifGasto_Click(object sender, EventArgs e)
        {
            //el seguiente metodo toma el objeto Gastos que esta seleccionado en la datagrid
            Gasto g = (Gasto)GastosdataGridView1.CurrentRow.DataBoundItem;

            DatosGasto.Update(g);

            //actualizamos
            ListarGastosMesActual();//y la volvemos a cargar, entonces se actualiza la lista

            btnModifGasto.Visible = false;
        }

        //boton para ingrasar a los ABM de Insumos Fijos
        private void Modificaciones_Click(object sender, EventArgs e)
        {
            ABMInsumoFijo abmInsFij = new ABMInsumoFijo();
            abmInsFij.ShowDialog(this);
        }

       
        private void bnEliminar_Click(object sender, EventArgs e)
        {
            //el seguiente metodo toma el objeto Gastos que esta seleccionado en la datagrid
            Gasto g = (Gasto)GastosdataGridView1.CurrentRow.DataBoundItem;

            if (MessageBox.Show("Esta seguro que decea eliminar " + g.Fecha +" "+ g.InsumoFijo.Nombre + g.InsumoVariable +" de $"+g.Costo, "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                DatosGasto.Delete(g);
            }

            //actualizamos la lista
            gastoBindingSource.Clear();//limpiamos la lista
            ListarGastosMesActual();//y la volvemos a cargar, entonces se actualiza la lista
        }


        //metodo para que en el campo "Cantidad" solo se ingresen num enteros
        private void textBox1Pesos_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        ////////////////////////////////////////////// MANIPULACION DE LA LISTA ///////////////////////////////////////////////////////////////

        //aqui cargamos toda la base de datos en la datagrid sin ningun filtro
        private void btnVerTodaLista_Click(object sender, EventArgs e)
        {
            gastoBindingSource.Clear();//limpiamos la lista

            //en el titulo aparecera la fecha del resumen de cuenta
            labelArribaLista.Text = ("Resumen de cuenta de toda la carga:");

            int tot = 0;
            foreach (Gasto g in DatosGasto.GetAll())//cargamos la datagrid de gastos
            {
                gastoBindingSource.Add(g);
                tot = tot + g.Costo;
            }
            labelTotal.Text = ("Total: $" + tot.ToString());

        }

        //hacemos click en el bt de "mes actual"
        private void btnMesactual_Click(object sender, EventArgs e)
        {
            ListarGastosMesActual();
        }

        //activacion de los combobox, quedan habilitados
        private void checkBoxRangoFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRangoFecha.Checked)
            {
                comboBoxAño.Enabled = true;
                comboBoxMes.Enabled = true;

                comboBoxMes.SelectedIndex = 0;//para que el combobox del mes arranque en 1 y no este en null
                CargarComboxAño();
            }
            else
            {
                comboBoxAño.Enabled = false;
                comboBoxMes.Enabled = false;
            }
        }
        private void checkBoxInsumoFij_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxInsumoFij.Checked)
                comboBoxIFijo.Enabled = true;
            else
                comboBoxIFijo.Enabled = false;
        }

        //cargamos los años, el combobox de meses ya viene carcado con los 12 meses
        private void CargarComboxAño()
        {
            List<int> año = new List<int>();//variables que cargaremos con la lista de año

            int a = 0;
            foreach (Gasto g1 in DatosGasto.GetAll())
            {
                if (a != g1.Fecha.Date.Year)//para no repetir los años
                {
                    a = g1.Fecha.Date.Year;
                    año.Add(g1.Fecha.Date.Year);
                }
            }
            comboBoxAño.DataSource = año;
        }


        //aqui hacemos los filtros para la lista --- esto todavia esta a modificar!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        private void button1Ver_Click(object sender, EventArgs e)
        {
            gastoBindingSource.Clear();//limpiamos la lista

            InsumoFijo inf = DatosInsumoFijo.GetAll()[comboBoxIFijo.SelectedIndex];//seleccionamos un insumo fijo (como objeto) del combobox

            int tot = 0;//para la suma total de dinero gastado
            int x = 0;//para ver si cargo algo en la datagrid


            foreach (Gasto g in DatosGasto.GetAll())//cargamos la datagrid de gastos
            {
                if (checkBoxRangoFecha.Checked && checkBoxInsumoFij.Checked == false)//solo una fecha determinada
                {
                    //en el titulo aparecera la fecha del resumen de cuenta
                    labelArribaLista.Text = ("Resumen de la cuenta del mes " + comboBoxMes.Text + " del " + comboBoxAño.Text);

                    //solo mostrara el mes y el año que seleccionamos aca
                    if (int.Parse(comboBoxAño.Text) == g.Fecha.Date.Year && int.Parse(comboBoxMes.Text) == g.Fecha.Date.Month)
                    {
                        gastoBindingSource.Add(g);
                        tot = tot + g.Costo;
                        x = x + 1;
                    }
                }
                if (checkBoxInsumoFij.Checked && checkBoxRangoFecha.Checked == false)//solo un insumo determinado
                {
                    labelArribaLista.Text = ("Resumen total de: " + inf.Nombre);//en el titulo aparecera la fecha del resumen de cuenta

                    if (inf.IdInsumoFijo == g.InsumoFijo.IdInsumoFijo)
                    {
                        gastoBindingSource.Add(g);
                        tot = tot + g.Costo;
                        x = x + 1;
                    }
                }
                if (checkBoxInsumoFij.Checked && checkBoxRangoFecha.Checked)//un insumo y una fecha especifica
                {
                    //en el titulo aparecera la fecha del resumen de cuenta
                    labelArribaLista.Text = ("Resumen total de: " + inf.Nombre + " en el mes " + comboBoxMes.Text + " del " + comboBoxAño.Text);


                    if (inf.IdInsumoFijo == g.InsumoFijo.IdInsumoFijo && int.Parse(comboBoxAño.Text) == g.Fecha.Date.Year && int.Parse(comboBoxMes.Text) == g.Fecha.Date.Month)
                    {
                        gastoBindingSource.Add(g);
                        tot = tot + g.Costo;
                        x = x + 1;
                    }
                }
            }
            labelTotal.Text = ("Total: $" + tot.ToString());//el total sera segun el resultado de la suma

            

            if (checkBoxRangoFecha.Checked == false && checkBoxInsumoFij.Checked == false)
                MessageBox.Show("Debe especificar una fecha y/o Insumo Fijo. Vuelva a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (x == 0)
                {
                    MessageBox.Show("No se encontraron datos guardados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            }

        }

        //botones para cambiar los meses (< y >)
        int mesTotal = DateTime.Now.Month;
        private void btnMenor_Click(object sender, EventArgs e)
        {
            mesTotal = mesTotal - 1;
            mesMenosMas(mesTotal);
        }

        private void btnMayor_Click(object sender, EventArgs e)
        {
            mesTotal = mesTotal + 1;
            mesMenosMas(mesTotal);
        }

        public void mesMenosMas(int x)
        {
            gastoBindingSource.Clear();//limpiamos la lista
            labelArribaLista.Text = ("Resumen de la cuenta del mes " + x + " del " + comboBoxAño.Text);

            float tot = 0;
            foreach (Gasto g in DatosGasto.GetAll())//cargamos la datagrid de gastos
            {
                if (2016 == g.Fecha.Date.Year && x == g.Fecha.Date.Month)
                {
                    gastoBindingSource.Add(g);
                    tot = tot + g.Costo;
                }
            }
            labelTotal.Text = ("Total: $" + tot.ToString());//el total sera segun el resultado de la suma
        }

        //metodos para la barra del Buscador
        private void txtBxBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            gastoBindingSource.Clear();//limpiamos la lista

            //en el titulo aparecera la fecha del resumen de cuenta
            labelArribaLista.Text = ("resultados de: \"" + txtBxBuscar.Text +"\"");

            char[] chrBus = txtBxBuscar.Text.ToCharArray();//dividimos la palabra que buscamos en caracteres

            int tot = 0;
            int n = 0;
            foreach (Gasto g in DatosGasto.GetAll())//cargamos la datagrid de gastos
            {
                if (g.InsumoVariable == null) { }
                else //si no es null, podemos listar
                {
                    n = g.InsumoVariable.ToLower().IndexOf(txtBxBuscar.Text.ToLower());//IndexOf encuentra la primer aparicion del caracter que queremos buscar que esta en txtBxBuscar
                    //ToLower() Convierte todos los caracteres de una cadena en minúsculas.
                    if (n > -1)//IndexOf te da la posicion del caracter que arranca desde 0, asique si existe esta desde -1 en adelante
                    {
                        gastoBindingSource.Add(g);//cargamos la datagrid
                        tot = tot + g.Costo;
                    }
                }
            }
            labelTotal.Text = ("Total: $" + tot.ToString());
        }

        private void txtBxBuscar_Click(object sender, EventArgs e)
        {
            txtBxBuscar.Clear();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //para que salte una notificacion
        private void btnVerTodaLista_MouseMove(object sender, MouseEventArgs e)
        {
        }

        

        //btn de Estadisticas para acceder a las estadisticas
        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            FMEstadisticas es = new FMEstadisticas();
            es.ShowDialog();
        }

        //btn de Ingresos
        private void ingresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FMIngresos ing = new FMIngresos();
            ing.ShowDialog();
        }

        private void exportarAExelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xls)|*.xls";
            sfd.FileName = "export.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Metodos.exportExel.ToCsV(GastosdataGridView1, sfd.FileName);//el metodo esta en Metodos> exportExel
            }
        }
        




    }
}
