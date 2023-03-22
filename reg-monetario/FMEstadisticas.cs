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

using System.Windows.Forms.DataVisualization.Charting;

namespace reg_monetario
{
    public partial class FMEstadisticas : Form
    {
        public FMEstadisticas()
        {
            InitializeComponent();

            CargarComboxAño();
            trackBarMeses.Value = DateTime.Now.Month; //arranca con el mes del momento
        }

        //cargamos los años, el combobox de meses ya viene carcado con los 12 meses
        private void CargarComboxAño()
        {
            List<int> año = new List<int>();//variables que cargaremos con la lista de año

            int priaño = DatosGasto.GetAll().First().Fecha.Date.Year;
            int ultaño = DateTime.Now.Year;

            for (int i = ultaño; i >= priaño; i--)
            {
                año.Add(i);
            }
            coBxAnios.DataSource = año;
        }

        private void coBxAnios_SelectedIndexChanged(object sender, EventArgs e)
        {
            raBtnMes.Checked = true;//cuando seleccionamos los meses, se chequea "por mes"

            int n = int.Parse(coBxAnios.SelectedItem.ToString());
            cantDineroMes(n);
        }

        private void raBtnIngresoGastosAnio_CheckedChanged(object sender, EventArgs e)
        {
            int n = int.Parse(coBxAnios.SelectedItem.ToString());
            gastosIngresosAn(n);
        }

        private void raBtnIngresoGastos_CheckedChanged(object sender, EventArgs e)
        {
            int n = int.Parse(coBxAnios.SelectedItem.ToString());
            gastosIngresos(Convert.ToDateTime("01/" + trackBarMeses.Value + "/" + n));
        }
        private void trackBarMeses_Scroll(object sender, EventArgs e)
        {
            raBtnIngresoGastos.Checked = true;

            lblMes.Text = "mes " + trackBarMeses.Value.ToString();
            int n = int.Parse(coBxAnios.SelectedItem.ToString());
            gastosIngresos(Convert.ToDateTime("01/" + trackBarMeses.Value + "/" + n));
        }

        private void raBtnMes_CheckedChanged(object sender, EventArgs e)
        {
            int n = int.Parse(coBxAnios.SelectedItem.ToString());
            cantDineroMes(n);
        }

        private void raBtnAnio_CheckedChanged(object sender, EventArgs e)
        {
            cantDineroAnio();
        }

        private void gastosIngresos(DateTime anioMes)
        {
            lblMes.Text = trackBarMeses.Value.ToString();
            double gas = 0;
            float ing = 0;

            foreach (Gasto ga in DatosGasto.GetAll())
            {
                if (ga.Fecha.Month == anioMes.Month && ga.Fecha.Year == anioMes.Year)
                    gas = gas + ga.Costo;
                
            }

            foreach (Ingreso i in DatosIngreso.GetAll())
            {
                if (i.Fecha.Month == anioMes.Month && i.Fecha.Year == anioMes.Year)
                    ing = ing + i.Cantidad;
            }

            double[] yValues = { gas, ing};
            string[] xNames = { "Gastos", "Ingresos" };
            chartEstadisticas.Series[0].Points.DataBindXY(xNames, yValues);
            chartEstadisticas.Series[0].IsValueShownAsLabel = true;//muestra el total arriba de la barra

            chartEstadisticas.ChartAreas[0].Area3DStyle.Enable3D = false;
        }

        private void gastosIngresosAn(int anio)
        {
            double gas = 0;
            float ing = 0;

            foreach (Gasto ga in DatosGasto.GetAll())
            {
                if (ga.Fecha.Year == anio)
                    gas = gas + ga.Costo;

            }

            foreach (Ingreso i in DatosIngreso.GetAll())
            {
                if (i.Fecha.Year == anio)
                    ing = ing + i.Cantidad;
            }

            double[] yValues = { gas, ing };
            string[] xNames = { "Gastos", "Ingresos" };
            chartEstadisticas.Series[0].Points.DataBindXY(xNames, yValues);
            chartEstadisticas.Series[0].IsValueShownAsLabel = true;//muestra el total arriba de la barra

            chartEstadisticas.ChartAreas[0].Area3DStyle.Enable3D = false;

            raBtnIngresoGastosAnio.Text = "Ingresos y gastos en el año $ " + (ing - gas);
        }
        


        private void cantDineroMes(int x)
        {
            double m1 = 0, m2 = 0, m3 = 0, m4 = 0, m5 = 0, m6 = 0, m7 = 0, m8 = 0, m9 = 0, m10 = 0, m11 = 0, m12 = 0;

            foreach (Gasto ga in DatosGasto.GetAll())
            {
                if (ga.Fecha.Year == x)
                {
                    switch (ga.Fecha.Date.Month)
                    {
                        case 1: m1 = m1 + ga.Costo; break;
                        case 2: m2 = m2 + ga.Costo; break;
                        case 3: m3 = m3 + ga.Costo; break;
                        case 4: m4 = m4 + ga.Costo; break;
                        case 5: m5 = m5 + ga.Costo; break;
                        case 6: m6 = m6 + ga.Costo; break;
                        case 7: m7 = m7 + ga.Costo; break;
                        case 8: m8 = m8 + ga.Costo; break;
                        case 9: m9 = m9 + ga.Costo; break;
                        case 10: m10 = m10 + ga.Costo; break;
                        case 11: m11 = m11 + ga.Costo; break;
                        case 12: m12 = m12 + ga.Costo; break;
                    }
                }
            }


            double[] yValues = { m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12 };
            string[] xNames = { "ene", "feb", "mar", "abr", "may", "jun", "jul", "ago", "sep", "oct", "nov", "dic" };
            chartEstadisticas.Series[0].Points.DataBindXY(xNames, yValues);
            chartEstadisticas.Series[0].IsValueShownAsLabel = true;//muestra el total arriba de la barra

            chartEstadisticas.ChartAreas[0].Area3DStyle.Enable3D = true;
        }

        private void cantDineroAnio()
        {
            double a2013 = 0, a2014 = 0, a2015 = 0, a2016 = 0, a2017 = 0, a2018 = 0, a2019 = 0, a2020 = 0, a2021 = 0;

            foreach (Gasto ga in DatosGasto.GetAll())
            {
                switch (ga.Fecha.Year)
                {
                    case 2013: a2013 = a2013 + ga.Costo; break;
                    case 2014: a2014 = a2014 + ga.Costo; break;
                    case 2015: a2015 = a2015 + ga.Costo; break;
                    case 2016: a2016 = a2016 + ga.Costo; break;
                    case 2017: a2017 = a2017 + ga.Costo; break;
                    case 2018: a2018 = a2018 + ga.Costo; break;
                    case 2019: a2019 = a2019 + ga.Costo; break;
                    case 2020: a2020 = a2020 + ga.Costo; break;
                    case 2021: a2021 = a2021 + ga.Costo; break;
                }
            }


            double[] yValues = { a2013, a2014, a2015, a2016, a2017, a2018, a2019, a2020, a2021 };
            string[] xNames = { "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021" };
            chartEstadisticas.Series[0].Points.DataBindXY(xNames, yValues);
            chartEstadisticas.Series[0].IsValueShownAsLabel = true;//muestra el total arriba de la barra

            chartEstadisticas.ChartAreas[0].Area3DStyle.Enable3D = true;
        }

        

        



    }
}
