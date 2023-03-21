namespace reg_monetario
{
    partial class FMEstadisticas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartEstadisticas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.coBxAnios = new System.Windows.Forms.ComboBox();
            this.raBtnMes = new System.Windows.Forms.RadioButton();
            this.raBtnAnio = new System.Windows.Forms.RadioButton();
            this.raBtnIngresoGastos = new System.Windows.Forms.RadioButton();
            this.trackBarMeses = new System.Windows.Forms.TrackBar();
            this.lblMes = new System.Windows.Forms.Label();
            this.raBtnIngresoGastosAnio = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.chartEstadisticas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMeses)).BeginInit();
            this.SuspendLayout();
            // 
            // chartEstadisticas
            // 
            chartArea1.Name = "ChartArea1";
            this.chartEstadisticas.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartEstadisticas.Legends.Add(legend1);
            this.chartEstadisticas.Location = new System.Drawing.Point(12, 57);
            this.chartEstadisticas.Name = "chartEstadisticas";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartEstadisticas.Series.Add(series1);
            this.chartEstadisticas.Size = new System.Drawing.Size(1200, 319);
            this.chartEstadisticas.TabIndex = 0;
            this.chartEstadisticas.Text = "chart1";
            // 
            // coBxAnios
            // 
            this.coBxAnios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coBxAnios.FormattingEnabled = true;
            this.coBxAnios.Location = new System.Drawing.Point(12, 12);
            this.coBxAnios.Name = "coBxAnios";
            this.coBxAnios.Size = new System.Drawing.Size(80, 21);
            this.coBxAnios.TabIndex = 1;
            this.coBxAnios.SelectedIndexChanged += new System.EventHandler(this.coBxAnios_SelectedIndexChanged);
            // 
            // raBtnMes
            // 
            this.raBtnMes.AutoSize = true;
            this.raBtnMes.Location = new System.Drawing.Point(12, 411);
            this.raBtnMes.Name = "raBtnMes";
            this.raBtnMes.Size = new System.Drawing.Size(56, 17);
            this.raBtnMes.TabIndex = 2;
            this.raBtnMes.Text = "Meses";
            this.raBtnMes.UseVisualStyleBackColor = true;
            this.raBtnMes.CheckedChanged += new System.EventHandler(this.raBtnMes_CheckedChanged);
            // 
            // raBtnAnio
            // 
            this.raBtnAnio.AutoSize = true;
            this.raBtnAnio.Location = new System.Drawing.Point(12, 518);
            this.raBtnAnio.Name = "raBtnAnio";
            this.raBtnAnio.Size = new System.Drawing.Size(44, 17);
            this.raBtnAnio.TabIndex = 3;
            this.raBtnAnio.Text = "Año";
            this.raBtnAnio.UseVisualStyleBackColor = true;
            this.raBtnAnio.CheckedChanged += new System.EventHandler(this.raBtnAnio_CheckedChanged);
            // 
            // raBtnIngresoGastos
            // 
            this.raBtnIngresoGastos.AutoSize = true;
            this.raBtnIngresoGastos.Checked = true;
            this.raBtnIngresoGastos.Location = new System.Drawing.Point(12, 481);
            this.raBtnIngresoGastos.Name = "raBtnIngresoGastos";
            this.raBtnIngresoGastos.Size = new System.Drawing.Size(109, 17);
            this.raBtnIngresoGastos.TabIndex = 4;
            this.raBtnIngresoGastos.TabStop = true;
            this.raBtnIngresoGastos.Text = "Ingresos y Gastos";
            this.raBtnIngresoGastos.UseVisualStyleBackColor = true;
            this.raBtnIngresoGastos.CheckedChanged += new System.EventHandler(this.raBtnIngresoGastos_CheckedChanged);
            // 
            // trackBarMeses
            // 
            this.trackBarMeses.Location = new System.Drawing.Point(168, 481);
            this.trackBarMeses.Maximum = 12;
            this.trackBarMeses.Minimum = 1;
            this.trackBarMeses.Name = "trackBarMeses";
            this.trackBarMeses.Size = new System.Drawing.Size(149, 45);
            this.trackBarMeses.TabIndex = 5;
            this.trackBarMeses.Value = 1;
            this.trackBarMeses.Scroll += new System.EventHandler(this.trackBarMeses_Scroll);
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(116, 485);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(26, 13);
            this.lblMes.TabIndex = 6;
            this.lblMes.Text = "mes";
            // 
            // raBtnIngresoGastosAnio
            // 
            this.raBtnIngresoGastosAnio.AutoSize = true;
            this.raBtnIngresoGastosAnio.Location = new System.Drawing.Point(12, 445);
            this.raBtnIngresoGastosAnio.Name = "raBtnIngresoGastosAnio";
            this.raBtnIngresoGastosAnio.Size = new System.Drawing.Size(154, 17);
            this.raBtnIngresoGastosAnio.TabIndex = 7;
            this.raBtnIngresoGastosAnio.TabStop = true;
            this.raBtnIngresoGastosAnio.Text = "Ingresos y gastos en el año";
            this.raBtnIngresoGastosAnio.UseVisualStyleBackColor = true;
            this.raBtnIngresoGastosAnio.CheckedChanged += new System.EventHandler(this.raBtnIngresoGastosAnio_CheckedChanged);
            // 
            // FMEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 555);
            this.Controls.Add(this.raBtnIngresoGastosAnio);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.trackBarMeses);
            this.Controls.Add(this.raBtnIngresoGastos);
            this.Controls.Add(this.raBtnAnio);
            this.Controls.Add(this.raBtnMes);
            this.Controls.Add(this.coBxAnios);
            this.Controls.Add(this.chartEstadisticas);
            this.Name = "FMEstadisticas";
            this.Text = "Estadísticas";
            ((System.ComponentModel.ISupportInitialize)(this.chartEstadisticas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMeses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartEstadisticas;
        private System.Windows.Forms.ComboBox coBxAnios;
        private System.Windows.Forms.RadioButton raBtnMes;
        private System.Windows.Forms.RadioButton raBtnAnio;
        private System.Windows.Forms.RadioButton raBtnIngresoGastos;
        private System.Windows.Forms.TrackBar trackBarMeses;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.RadioButton raBtnIngresoGastosAnio;

    }
}