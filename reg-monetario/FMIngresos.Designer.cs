namespace reg_monetario
{
    partial class FMIngresos
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
            this.components = new System.ComponentModel.Container();
            this.Cargar = new System.Windows.Forms.GroupBox();
            this.currencyCboBox = new System.Windows.Forms.ComboBox();
            this.chkBxDiezmoApartado = new System.Windows.Forms.CheckBox();
            this.txtBoxDescripcion = new System.Windows.Forms.TextBox();
            this.label3Cantidad = new System.Windows.Forms.Label();
            this.grBxTipo = new System.Windows.Forms.GroupBox();
            this.btnGuardarTipo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.tipoDataGridView2 = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnEliminTipo = new System.Windows.Forms.Button();
            this.textBoxTipo = new System.Windows.Forms.TextBox();
            this.label2Peso = new System.Windows.Forms.Label();
            this.button1Guardar = new System.Windows.Forms.Button();
            this.label1Fecha = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1Pesos = new System.Windows.Forms.TextBox();
            this.IngresosdataGridView = new System.Windows.Forms.DataGridView();
            this.labelTotal = new System.Windows.Forms.Label();
            this.bnEliminar = new System.Windows.Forms.Button();
            this.lblAño = new System.Windows.Forms.Label();
            this.comboBoxAño = new System.Windows.Forms.ComboBox();
            this.btnModifIngreso = new System.Windows.Forms.Button();
            this.grupBxDiezmo = new System.Windows.Forms.GroupBox();
            this.lblDiezmo = new System.Windows.Forms.Label();
            this.txtBxBuscarIn = new System.Windows.Forms.TextBox();
            this.ingresoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diezmoApartadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Cargar.SuspendLayout();
            this.grBxTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IngresosdataGridView)).BeginInit();
            this.grupBxDiezmo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ingresoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Cargar
            // 
            this.Cargar.Controls.Add(this.currencyCboBox);
            this.Cargar.Controls.Add(this.chkBxDiezmoApartado);
            this.Cargar.Controls.Add(this.txtBoxDescripcion);
            this.Cargar.Controls.Add(this.label3Cantidad);
            this.Cargar.Controls.Add(this.grBxTipo);
            this.Cargar.Controls.Add(this.label2Peso);
            this.Cargar.Controls.Add(this.button1Guardar);
            this.Cargar.Controls.Add(this.label1Fecha);
            this.Cargar.Controls.Add(this.dateTimePicker1);
            this.Cargar.Controls.Add(this.textBox1Pesos);
            this.Cargar.Location = new System.Drawing.Point(16, 41);
            this.Cargar.Margin = new System.Windows.Forms.Padding(4);
            this.Cargar.Name = "Cargar";
            this.Cargar.Padding = new System.Windows.Forms.Padding(4);
            this.Cargar.Size = new System.Drawing.Size(303, 641);
            this.Cargar.TabIndex = 18;
            this.Cargar.TabStop = false;
            this.Cargar.Text = "Cargar Ingresos";
            // 
            // currencyCboBox
            // 
            this.currencyCboBox.FormattingEnabled = true;
            this.currencyCboBox.Location = new System.Drawing.Point(180, 62);
            this.currencyCboBox.Name = "currencyCboBox";
            this.currencyCboBox.Size = new System.Drawing.Size(77, 24);
            this.currencyCboBox.TabIndex = 23;
            // 
            // chkBxDiezmoApartado
            // 
            this.chkBxDiezmoApartado.AutoSize = true;
            this.chkBxDiezmoApartado.Location = new System.Drawing.Point(33, 117);
            this.chkBxDiezmoApartado.Margin = new System.Windows.Forms.Padding(4);
            this.chkBxDiezmoApartado.Name = "chkBxDiezmoApartado";
            this.chkBxDiezmoApartado.Size = new System.Drawing.Size(138, 21);
            this.chkBxDiezmoApartado.TabIndex = 22;
            this.chkBxDiezmoApartado.Text = "Diezmo apartado";
            this.chkBxDiezmoApartado.UseVisualStyleBackColor = true;
            // 
            // txtBoxDescripcion
            // 
            this.txtBoxDescripcion.Location = new System.Drawing.Point(33, 91);
            this.txtBoxDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxDescripcion.Name = "txtBoxDescripcion";
            this.txtBoxDescripcion.Size = new System.Drawing.Size(236, 22);
            this.txtBoxDescripcion.TabIndex = 21;
            // 
            // label3Cantidad
            // 
            this.label3Cantidad.AutoSize = true;
            this.label3Cantidad.Location = new System.Drawing.Point(8, 44);
            this.label3Cantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3Cantidad.Name = "label3Cantidad";
            this.label3Cantidad.Size = new System.Drawing.Size(68, 17);
            this.label3Cantidad.TabIndex = 6;
            this.label3Cantidad.Text = "Cantidad:";
            // 
            // grBxTipo
            // 
            this.grBxTipo.Controls.Add(this.btnGuardarTipo);
            this.grBxTipo.Controls.Add(this.btnModificar);
            this.grBxTipo.Controls.Add(this.tipoDataGridView2);
            this.grBxTipo.Controls.Add(this.btnEliminTipo);
            this.grBxTipo.Controls.Add(this.textBoxTipo);
            this.grBxTipo.Location = new System.Drawing.Point(15, 223);
            this.grBxTipo.Margin = new System.Windows.Forms.Padding(4);
            this.grBxTipo.Name = "grBxTipo";
            this.grBxTipo.Padding = new System.Windows.Forms.Padding(4);
            this.grBxTipo.Size = new System.Drawing.Size(265, 375);
            this.grBxTipo.TabIndex = 20;
            this.grBxTipo.TabStop = false;
            this.grBxTipo.Text = "Seleccione el Tipos de Ingresos";
            // 
            // btnGuardarTipo
            // 
            this.btnGuardarTipo.Location = new System.Drawing.Point(157, 68);
            this.btnGuardarTipo.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardarTipo.Name = "btnGuardarTipo";
            this.btnGuardarTipo.Size = new System.Drawing.Size(100, 30);
            this.btnGuardarTipo.TabIndex = 27;
            this.btnGuardarTipo.Text = "Guardar";
            this.btnGuardarTipo.UseVisualStyleBackColor = true;
            this.btnGuardarTipo.Visible = false;
            this.btnGuardarTipo.Click += new System.EventHandler(this.btnGuardarTipo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnModificar.Location = new System.Drawing.Point(23, 23);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(172, 25);
            this.btnModificar.TabIndex = 26;
            this.btnModificar.Text = "Modificar Información";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // tipoDataGridView2
            // 
            this.tipoDataGridView2.AutoGenerateColumns = false;
            this.tipoDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tipoDataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn});
            this.tipoDataGridView2.DataSource = this.tipoBindingSource;
            this.tipoDataGridView2.Location = new System.Drawing.Point(23, 103);
            this.tipoDataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.tipoDataGridView2.Name = "tipoDataGridView2";
            this.tipoDataGridView2.Size = new System.Drawing.Size(219, 229);
            this.tipoDataGridView2.TabIndex = 25;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // tipoBindingSource
            // 
            this.tipoBindingSource.DataSource = typeof(reg_monetario.Clases.Tipo);
            // 
            // btnEliminTipo
            // 
            this.btnEliminTipo.Location = new System.Drawing.Point(23, 340);
            this.btnEliminTipo.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminTipo.Name = "btnEliminTipo";
            this.btnEliminTipo.Size = new System.Drawing.Size(100, 28);
            this.btnEliminTipo.TabIndex = 24;
            this.btnEliminTipo.Text = "Eliminar";
            this.btnEliminTipo.UseVisualStyleBackColor = true;
            this.btnEliminTipo.Visible = false;
            this.btnEliminTipo.Click += new System.EventHandler(this.btnEliminTipo_Click);
            // 
            // textBoxTipo
            // 
            this.textBoxTipo.Location = new System.Drawing.Point(23, 71);
            this.textBoxTipo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTipo.Name = "textBoxTipo";
            this.textBoxTipo.Size = new System.Drawing.Size(132, 22);
            this.textBoxTipo.TabIndex = 22;
            this.textBoxTipo.Visible = false;
            // 
            // label2Peso
            // 
            this.label2Peso.AutoSize = true;
            this.label2Peso.Location = new System.Drawing.Point(8, 68);
            this.label2Peso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2Peso.Name = "label2Peso";
            this.label2Peso.Size = new System.Drawing.Size(16, 17);
            this.label2Peso.TabIndex = 5;
            this.label2Peso.Text = "$";
            // 
            // button1Guardar
            // 
            this.button1Guardar.Location = new System.Drawing.Point(180, 606);
            this.button1Guardar.Margin = new System.Windows.Forms.Padding(4);
            this.button1Guardar.Name = "button1Guardar";
            this.button1Guardar.Size = new System.Drawing.Size(100, 28);
            this.button1Guardar.TabIndex = 1;
            this.button1Guardar.Text = "Guardar";
            this.button1Guardar.UseVisualStyleBackColor = true;
            this.button1Guardar.Click += new System.EventHandler(this.button1Guardar_Click);
            // 
            // label1Fecha
            // 
            this.label1Fecha.AutoSize = true;
            this.label1Fecha.Location = new System.Drawing.Point(8, 158);
            this.label1Fecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1Fecha.Name = "label1Fecha";
            this.label1Fecha.Size = new System.Drawing.Size(47, 17);
            this.label1Fecha.TabIndex = 2;
            this.label1Fecha.Text = "fecha:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 177);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // textBox1Pesos
            // 
            this.textBox1Pesos.Location = new System.Drawing.Point(33, 64);
            this.textBox1Pesos.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1Pesos.Name = "textBox1Pesos";
            this.textBox1Pesos.Size = new System.Drawing.Size(132, 22);
            this.textBox1Pesos.TabIndex = 4;
            // 
            // IngresosdataGridView
            // 
            this.IngresosdataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IngresosdataGridView.AutoGenerateColumns = false;
            this.IngresosdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IngresosdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.currencyDataGridViewTextBoxColumn,
            this.diezmoApartadoDataGridViewCheckBoxColumn});
            this.IngresosdataGridView.DataSource = this.ingresoBindingSource;
            this.IngresosdataGridView.Location = new System.Drawing.Point(327, 41);
            this.IngresosdataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.IngresosdataGridView.Name = "IngresosdataGridView";
            this.IngresosdataGridView.Size = new System.Drawing.Size(712, 591);
            this.IngresosdataGridView.TabIndex = 19;
            this.IngresosdataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.IngresosdataGridView_CellDoubleClick);
            // 
            // labelTotal
            // 
            this.labelTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(893, 646);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(71, 24);
            this.labelTotal.TabIndex = 21;
            this.labelTotal.Text = "Total: $";
            // 
            // bnEliminar
            // 
            this.bnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bnEliminar.ForeColor = System.Drawing.Color.Red;
            this.bnEliminar.Location = new System.Drawing.Point(327, 646);
            this.bnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.bnEliminar.Name = "bnEliminar";
            this.bnEliminar.Size = new System.Drawing.Size(100, 28);
            this.bnEliminar.TabIndex = 22;
            this.bnEliminar.Text = "Eliminar";
            this.bnEliminar.UseVisualStyleBackColor = true;
            this.bnEliminar.Click += new System.EventHandler(this.bnEliminar_Click);
            // 
            // lblAño
            // 
            this.lblAño.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(1044, 41);
            this.lblAño.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(37, 17);
            this.lblAño.TabIndex = 24;
            this.lblAño.Text = "Año:";
            // 
            // comboBoxAño
            // 
            this.comboBoxAño.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAño.FormattingEnabled = true;
            this.comboBoxAño.Location = new System.Drawing.Point(1047, 62);
            this.comboBoxAño.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxAño.Name = "comboBoxAño";
            this.comboBoxAño.Size = new System.Drawing.Size(105, 24);
            this.comboBoxAño.TabIndex = 23;
            this.comboBoxAño.SelectedIndexChanged += new System.EventHandler(this.comboBoxAño_SelectedIndexChanged);
            // 
            // btnModifIngreso
            // 
            this.btnModifIngreso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModifIngreso.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnModifIngreso.Location = new System.Drawing.Point(435, 646);
            this.btnModifIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifIngreso.Name = "btnModifIngreso";
            this.btnModifIngreso.Size = new System.Drawing.Size(156, 28);
            this.btnModifIngreso.TabIndex = 25;
            this.btnModifIngreso.Text = "Guardar Modificación";
            this.btnModifIngreso.UseVisualStyleBackColor = true;
            this.btnModifIngreso.Visible = false;
            this.btnModifIngreso.Click += new System.EventHandler(this.btnModifIngreso_Click);
            // 
            // grupBxDiezmo
            // 
            this.grupBxDiezmo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grupBxDiezmo.Controls.Add(this.lblDiezmo);
            this.grupBxDiezmo.Location = new System.Drawing.Point(1047, 119);
            this.grupBxDiezmo.Margin = new System.Windows.Forms.Padding(4);
            this.grupBxDiezmo.Name = "grupBxDiezmo";
            this.grupBxDiezmo.Padding = new System.Windows.Forms.Padding(4);
            this.grupBxDiezmo.Size = new System.Drawing.Size(161, 135);
            this.grupBxDiezmo.TabIndex = 26;
            this.grupBxDiezmo.TabStop = false;
            this.grupBxDiezmo.Text = "Diezmo que falta devolver";
            // 
            // lblDiezmo
            // 
            this.lblDiezmo.AutoSize = true;
            this.lblDiezmo.Location = new System.Drawing.Point(9, 38);
            this.lblDiezmo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiezmo.Name = "lblDiezmo";
            this.lblDiezmo.Size = new System.Drawing.Size(16, 17);
            this.lblDiezmo.TabIndex = 0;
            this.lblDiezmo.Text = "$";
            // 
            // txtBxBuscarIn
            // 
            this.txtBxBuscarIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBxBuscarIn.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtBxBuscarIn.Location = new System.Drawing.Point(1047, 603);
            this.txtBxBuscarIn.Margin = new System.Windows.Forms.Padding(4);
            this.txtBxBuscarIn.Name = "txtBxBuscarIn";
            this.txtBxBuscarIn.Size = new System.Drawing.Size(154, 22);
            this.txtBxBuscarIn.TabIndex = 27;
            this.txtBxBuscarIn.Text = "Buscar descripción";
            this.txtBxBuscarIn.Click += new System.EventHandler(this.txtBxBuscarIn_Click);
            this.txtBxBuscarIn.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBxBuscarIn_KeyUp);
            // 
            // ingresoBindingSource
            // 
            this.ingresoBindingSource.DataSource = typeof(reg_monetario.Clases.Ingreso);
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.Width = 95;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.Width = 190;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.Width = 50;
            // 
            // currencyDataGridViewTextBoxColumn
            // 
            this.currencyDataGridViewTextBoxColumn.DataPropertyName = "Currency";
            this.currencyDataGridViewTextBoxColumn.HeaderText = "Currency";
            this.currencyDataGridViewTextBoxColumn.Name = "currencyDataGridViewTextBoxColumn";
            this.currencyDataGridViewTextBoxColumn.Width = 45;
            // 
            // diezmoApartadoDataGridViewCheckBoxColumn
            // 
            this.diezmoApartadoDataGridViewCheckBoxColumn.DataPropertyName = "DiezmoApartado";
            this.diezmoApartadoDataGridViewCheckBoxColumn.HeaderText = "DiezmoApartado";
            this.diezmoApartadoDataGridViewCheckBoxColumn.Name = "diezmoApartadoDataGridViewCheckBoxColumn";
            this.diezmoApartadoDataGridViewCheckBoxColumn.Width = 30;
            // 
            // FMIngresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 697);
            this.Controls.Add(this.txtBxBuscarIn);
            this.Controls.Add(this.grupBxDiezmo);
            this.Controls.Add(this.btnModifIngreso);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.comboBoxAño);
            this.Controls.Add(this.bnEliminar);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.IngresosdataGridView);
            this.Controls.Add(this.Cargar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FMIngresos";
            this.Text = "FMIngresos";
            this.Cargar.ResumeLayout(false);
            this.Cargar.PerformLayout();
            this.grBxTipo.ResumeLayout(false);
            this.grBxTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tipoDataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IngresosdataGridView)).EndInit();
            this.grupBxDiezmo.ResumeLayout(false);
            this.grupBxDiezmo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ingresoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Cargar;
        private System.Windows.Forms.Label label3Cantidad;
        private System.Windows.Forms.Label label2Peso;
        private System.Windows.Forms.Button button1Guardar;
        private System.Windows.Forms.Label label1Fecha;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1Pesos;
        private System.Windows.Forms.DataGridView IngresosdataGridView;
        private System.Windows.Forms.GroupBox grBxTipo;
        private System.Windows.Forms.DataGridView tipoDataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tipoBindingSource;
        private System.Windows.Forms.Button btnEliminTipo;
        private System.Windows.Forms.TextBox textBoxTipo;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardarTipo;
        private System.Windows.Forms.Button bnEliminar;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.ComboBox comboBoxAño;
        private System.Windows.Forms.TextBox txtBoxDescripcion;
        private System.Windows.Forms.CheckBox chkBxDiezmoApartado;
        private System.Windows.Forms.Button btnModifIngreso;
        private System.Windows.Forms.GroupBox grupBxDiezmo;
        private System.Windows.Forms.Label lblDiezmo;
        private System.Windows.Forms.TextBox txtBxBuscarIn;
        private System.Windows.Forms.ComboBox currencyCboBox;
        private System.Windows.Forms.BindingSource ingresoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn diezmoApartadoDataGridViewCheckBoxColumn;
    }
}