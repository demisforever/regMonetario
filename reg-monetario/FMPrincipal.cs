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

            CargarComboxInsumosFijos();

            ListarGastosMesActual();

            //mas adelande, guardar en un metodo
            List<string> currencyList = new List<string>();
            currencyList.Add("ARS");
            currencyList.Add("USD");
            currencyList.Add("BRS");
            currencyCboBox.DataSource = currencyList;
        }

        //Déficit Superávit
        private void deficitSuperavit(float i, double g)
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
            double totGa = 0;

            //DateTime dtUltimo = DateTimePicker.date

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


        //cargar un gasto
        private void button1Guardar_Click(object sender, EventArgs e)
        {
            InsumoFijo inf = DatosInsumoFijo.GetAll()[comboBoxInsFijos.SelectedIndex];
            Gasto g = new Gasto();
            g.Fecha = dateTimePicker1.Value;
            g.InsumoVariable = textBox2InVariable.Text;
            g.Currency = currencyCboBox.SelectedValue.ToString();
            g.InsumoFijo = inf;

            if (string.IsNullOrEmpty(textBox1Pesos.Text))//no nulo, el campo de "cantidad"
            {
                MessageBox.Show("Tiene que completar el campo campo \"Cantidad $\" con un número entero... ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                g.Costo = int.Parse(textBox1Pesos.Text);//SelectionStart me cuenta la cantidad de numeros que ingreso
                if (MessageBox.Show("Esta seguro que desea guardar \"" + inf.Nombre + "\" de $" + textBox1Pesos.Text, "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                    DatosGasto.Save(g);
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

            if (MessageBox.Show("Esta seguro que desea eliminar " + g.Fecha +" "+ g.InsumoFijo.Nombre + g.InsumoVariable +" de $"+g.Costo, "Atencion", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
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
            else if (e.KeyChar == 45)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void viewTotal()
        {
            // crear metodo total pra todo los que muestran total
        }

        ////////////////////////////////////////////// MANIPULACION DE LA LISTA ///////////////////////////////////////////////////////////////

        //aqui cargamos toda la base de datos en la datagrid sin ningun filtro
        private void btnVerTodaLista_Click(object sender, EventArgs e)
        {
            gastoBindingSource.Clear();//limpiamos la lista

            //en el titulo aparecera la fecha del resumen de cuenta
            labelArribaLista.Text = ("Resumen de cuenta de toda la carga:");

            double tot = 0;
            foreach (Gasto g in DatosGasto.GetAll())//cargamos la datagrid de gastos
            {
                gastoBindingSource.Add(g);
                tot = tot + g.Costo;
            }
            labelTotal.Text = ("Total: $" + tot.ToString());
            //labelTotal.Text = "<!DOCTYPE html>< html >< body >< h1 > My First Heading</ h1 > < p > My first paragraph.</ p ></ body ></ html > ";

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

                comboBoxMes.SelectedIndex = DateTime.Now.Month - 1;//para que el combobox del mes arranque en el mes actual y no este en null
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
            año.Sort((p, b) => b.CompareTo(p));//ordenamos la lista de mayor a menor
            comboBoxAño.DataSource = año;
        }


        //aqui hacemos los filtros para la lista --- esto todavia esta a modificar!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        private void button1Ver_Click(object sender, EventArgs e)
        {
            gastoBindingSource.Clear();//limpiamos la lista

            InsumoFijo inf = DatosInsumoFijo.GetAll()[comboBoxIFijo.SelectedIndex];//seleccionamos un insumo fijo (como objeto) del combobox

            double tot = 0;//para la suma total de dinero gastado
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
        int anioTotal = DateTime.Now.Year;
        private void btnMenor_Click(object sender, EventArgs e)
        {
            mesTotal = mesTotal - 1;
            if (mesTotal == 0)
            {
                mesTotal = 12;
                anioTotal = anioTotal - 1;
            }
            mesMenosMas(mesTotal, anioTotal);
        }

        private void btnMayor_Click(object sender, EventArgs e)
        {
            mesTotal = mesTotal + 1;
            if (mesTotal == 13)
            {
                mesTotal = 1;
                anioTotal = anioTotal + 1;
            }
            mesMenosMas(mesTotal, anioTotal);
        }

        public void mesMenosMas(int m, int a)
        {
            gastoBindingSource.Clear();//limpiamos la lista
            labelArribaLista.Text = ("Resumen de la cuenta del mes " + m + " del " + a);

            double tot = 0;
            foreach (Gasto g in DatosGasto.GetAll())//cargamos la datagrid de gastos
            {
                if (a == g.Fecha.Date.Year && m == g.Fecha.Date.Month)
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

            double tot = 0;
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

        private void GastosdataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
