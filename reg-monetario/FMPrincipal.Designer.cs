﻿namespace reg_monetario
{
    partial class FMPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMPrincipal));
            this.button1Guardar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1Pesos = new System.Windows.Forms.TextBox();
            this.label2Peso = new System.Windows.Forms.Label();
            this.label3Cantidad = new System.Windows.Forms.Label();
            this.textBox2InVariable = new System.Windows.Forms.TextBox();
            this.comboBoxInsFijos = new System.Windows.Forms.ComboBox();
            this.bindingSource1InsFijos = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarAExelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Cargar = new System.Windows.Forms.GroupBox();
            this.ButtomModificaciones = new System.Windows.Forms.Button();
            this.label4TipodInsumo = new System.Windows.Forms.Label();
            this.currencyCboBox = new System.Windows.Forms.ComboBox();
            this.GastosdataGridView1 = new System.Windows.Forms.DataGridView();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insumoFijoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insumoVariableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gastoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bnEliminar = new System.Windows.Forms.Button();
            this.labelTotal = new System.Windows.Forms.Label();
            this.groupBoxManipularLista = new System.Windows.Forms.GroupBox();
            this.txtBxBuscar = new System.Windows.Forms.TextBox();
            this.lblAño = new System.Windows.Forms.Label();
            this.comboBoxAño = new System.Windows.Forms.ComboBox();
            this.lblMes = new System.Windows.Forms.Label();
            this.comboBoxMes = new System.Windows.Forms.ComboBox();
            this.btnUltiMesCarg = new System.Windows.Forms.Button();
            this.btnVerTodaLista = new System.Windows.Forms.Button();
            this.comboBoxIFijo = new System.Windows.Forms.ComboBox();
            this.checkBoxInsumoFij = new System.Windows.Forms.CheckBox();
            this.btnModifGasto = new System.Windows.Forms.Button();
            this.lblPatente = new System.Windows.Forms.Label();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.btnMenor = new System.Windows.Forms.Button();
            this.btnMayor = new System.Windows.Forms.Button();
            this.textBoxSearchCost = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1InsFijos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.Cargar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GastosdataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gastoBindingSource)).BeginInit();
            this.groupBoxManipularLista.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1Guardar
            // 
            this.button1Guardar.Location = new System.Drawing.Point(162, 171);
            this.button1Guardar.Name = "button1Guardar";
            this.button1Guardar.Size = new System.Drawing.Size(80, 22);
            this.button1Guardar.TabIndex = 1;
            this.button1Guardar.Text = "Guardar";
            this.button1Guardar.UseVisualStyleBackColor = true;
            this.button1Guardar.Click += new System.EventHandler(this.button1Guardar_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 18);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(213, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // textBox1Pesos
            // 
            this.textBox1Pesos.Location = new System.Drawing.Point(80, 54);
            this.textBox1Pesos.Name = "textBox1Pesos";
            this.textBox1Pesos.Size = new System.Drawing.Size(71, 20);
            this.textBox1Pesos.TabIndex = 4;
            this.textBox1Pesos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1Pesos_TextChanged);
            // 
            // label2Peso
            // 
            this.label2Peso.AutoSize = true;
            this.label2Peso.Location = new System.Drawing.Point(60, 57);
            this.label2Peso.Name = "label2Peso";
            this.label2Peso.Size = new System.Drawing.Size(13, 13);
            this.label2Peso.TabIndex = 5;
            this.label2Peso.Text = "$";
            // 
            // label3Cantidad
            // 
            this.label3Cantidad.AutoSize = true;
            this.label3Cantidad.Location = new System.Drawing.Point(9, 57);
            this.label3Cantidad.Name = "label3Cantidad";
            this.label3Cantidad.Size = new System.Drawing.Size(52, 13);
            this.label3Cantidad.TabIndex = 6;
            this.label3Cantidad.Text = "Cantidad:";
            // 
            // textBox2InVariable
            // 
            this.textBox2InVariable.Location = new System.Drawing.Point(10, 129);
            this.textBox2InVariable.Name = "textBox2InVariable";
            this.textBox2InVariable.Size = new System.Drawing.Size(230, 20);
            this.textBox2InVariable.TabIndex = 8;
            // 
            // comboBoxInsFijos
            // 
            this.comboBoxInsFijos.DataSource = this.bindingSource1InsFijos;
            this.comboBoxInsFijos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInsFijos.FormattingEnabled = true;
            this.comboBoxInsFijos.Location = new System.Drawing.Point(12, 80);
            this.comboBoxInsFijos.Name = "comboBoxInsFijos";
            this.comboBoxInsFijos.Size = new System.Drawing.Size(129, 21);
            this.comboBoxInsFijos.TabIndex = 13;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ingresosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(886, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarAExelToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // exportarAExelToolStripMenuItem
            // 
            this.exportarAExelToolStripMenuItem.Name = "exportarAExelToolStripMenuItem";
            this.exportarAExelToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.exportarAExelToolStripMenuItem.Text = "Exportar a Exel";
            this.exportarAExelToolStripMenuItem.Click += new System.EventHandler(this.exportarAExelToolStripMenuItem_Click);
            // 
            // ingresosToolStripMenuItem
            // 
            this.ingresosToolStripMenuItem.Name = "ingresosToolStripMenuItem";
            this.ingresosToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.ingresosToolStripMenuItem.Text = "Ingresos";
            this.ingresosToolStripMenuItem.Click += new System.EventHandler(this.ingresosToolStripMenuItem_Click);
            // 
            // Cargar
            // 
            this.Cargar.Controls.Add(this.ButtomModificaciones);
            this.Cargar.Controls.Add(this.label3Cantidad);
            this.Cargar.Controls.Add(this.label2Peso);
            this.Cargar.Controls.Add(this.button1Guardar);
            this.Cargar.Controls.Add(this.comboBoxInsFijos);
            this.Cargar.Controls.Add(this.label4TipodInsumo);
            this.Cargar.Controls.Add(this.dateTimePicker1);
            this.Cargar.Controls.Add(this.textBox1Pesos);
            this.Cargar.Controls.Add(this.textBox2InVariable);
            this.Cargar.Location = new System.Drawing.Point(13, 27);
            this.Cargar.Name = "Cargar";
            this.Cargar.Size = new System.Drawing.Size(249, 202);
            this.Cargar.TabIndex = 17;
            this.Cargar.TabStop = false;
            this.Cargar.Text = "Cargar Gatos";
            // 
            // ButtomModificaciones
            // 
            this.ButtomModificaciones.Location = new System.Drawing.Point(147, 80);
            this.ButtomModificaciones.Name = "ButtomModificaciones";
            this.ButtomModificaciones.Size = new System.Drawing.Size(54, 22);
            this.ButtomModificaciones.TabIndex = 14;
            this.ButtomModificaciones.Text = "Editar";
            this.ButtomModificaciones.UseVisualStyleBackColor = true;
            this.ButtomModificaciones.Click += new System.EventHandler(this.Modificaciones_Click);
            // 
            // label4TipodInsumo
            // 
            this.label4TipodInsumo.AutoSize = true;
            this.label4TipodInsumo.Location = new System.Drawing.Point(9, 114);
            this.label4TipodInsumo.Name = "label4TipodInsumo";
            this.label4TipodInsumo.Size = new System.Drawing.Size(112, 13);
            this.label4TipodInsumo.TabIndex = 11;
            this.label4TipodInsumo.Text = "Descripción (opcional)";
            // 
            // currencyCboBox
            // 
            this.currencyCboBox.FormattingEnabled = true;
            this.currencyCboBox.Location = new System.Drawing.Point(694, 30);
            this.currencyCboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.currencyCboBox.Name = "currencyCboBox";
            this.currencyCboBox.Size = new System.Drawing.Size(62, 21);
            this.currencyCboBox.TabIndex = 15;
            this.currencyCboBox.SelectedIndexChanged += new System.EventHandler(this.currencyCboBox_SelectedIndexChanged);
            // 
            // GastosdataGridView1
            // 
            this.GastosdataGridView1.AllowUserToAddRows = false;
            this.GastosdataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GastosdataGridView1.AutoGenerateColumns = false;
            this.GastosdataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GastosdataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GastosdataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaDataGridViewTextBoxColumn,
            this.insumoFijoDataGridViewTextBoxColumn,
            this.insumoVariableDataGridViewTextBoxColumn,
            this.costoDataGridViewTextBoxColumn,
            this.currencyDataGridViewTextBoxColumn,
            this.PersonId});
            this.GastosdataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GastosdataGridView1.DataSource = this.gastoBindingSource;
            this.GastosdataGridView1.GridColor = System.Drawing.Color.LightSkyBlue;
            this.GastosdataGridView1.Location = new System.Drawing.Point(268, 53);
            this.GastosdataGridView1.Name = "GastosdataGridView1";
            this.GastosdataGridView1.Size = new System.Drawing.Size(597, 458);
            this.GastosdataGridView1.TabIndex = 18;
            this.GastosdataGridView1.TabStop = false;
            this.GastosdataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GastosdataGridView1_CellContentClick);
            this.GastosdataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GastosdataGridView1_CellDoubleClick);
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.Width = 95;
            // 
            // insumoFijoDataGridViewTextBoxColumn
            // 
            this.insumoFijoDataGridViewTextBoxColumn.DataPropertyName = "InsumoFijo";
            this.insumoFijoDataGridViewTextBoxColumn.HeaderText = "InsumoFijo";
            this.insumoFijoDataGridViewTextBoxColumn.Name = "insumoFijoDataGridViewTextBoxColumn";
            // 
            // insumoVariableDataGridViewTextBoxColumn
            // 
            this.insumoVariableDataGridViewTextBoxColumn.DataPropertyName = "InsumoVariable";
            this.insumoVariableDataGridViewTextBoxColumn.HeaderText = "InsumoVariable";
            this.insumoVariableDataGridViewTextBoxColumn.Name = "insumoVariableDataGridViewTextBoxColumn";
            this.insumoVariableDataGridViewTextBoxColumn.Width = 190;
            // 
            // costoDataGridViewTextBoxColumn
            // 
            this.costoDataGridViewTextBoxColumn.DataPropertyName = "Costo";
            this.costoDataGridViewTextBoxColumn.HeaderText = "Costo";
            this.costoDataGridViewTextBoxColumn.Name = "costoDataGridViewTextBoxColumn";
            this.costoDataGridViewTextBoxColumn.Width = 45;
            // 
            // currencyDataGridViewTextBoxColumn
            // 
            this.currencyDataGridViewTextBoxColumn.DataPropertyName = "Currency";
            this.currencyDataGridViewTextBoxColumn.HeaderText = "Currency";
            this.currencyDataGridViewTextBoxColumn.Name = "currencyDataGridViewTextBoxColumn";
            this.currencyDataGridViewTextBoxColumn.Width = 45;
            // 
            // PersonId
            // 
            this.PersonId.DataPropertyName = "PersonId";
            this.PersonId.HeaderText = "Person";
            this.PersonId.Name = "PersonId";
            this.PersonId.Width = 60;
            // 
            // gastoBindingSource
            // 
            this.gastoBindingSource.DataSource = typeof(reg_monetario.Clases.Gasto);
            this.gastoBindingSource.CurrentChanged += new System.EventHandler(this.gastoBindingSource_CurrentChanged);
            // 
            // bnEliminar
            // 
            this.bnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bnEliminar.ForeColor = System.Drawing.Color.Red;
            this.bnEliminar.Location = new System.Drawing.Point(268, 517);
            this.bnEliminar.Name = "bnEliminar";
            this.bnEliminar.Size = new System.Drawing.Size(80, 22);
            this.bnEliminar.TabIndex = 19;
            this.bnEliminar.Text = "Eliminar";
            this.bnEliminar.UseVisualStyleBackColor = true;
            this.bnEliminar.Click += new System.EventHandler(this.bnEliminar_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(743, 517);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(57, 18);
            this.labelTotal.TabIndex = 20;
            this.labelTotal.Text = "Total: $";
            // 
            // groupBoxManipularLista
            // 
            this.groupBoxManipularLista.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxManipularLista.Controls.Add(this.txtBxBuscar);
            this.groupBoxManipularLista.Controls.Add(this.lblAño);
            this.groupBoxManipularLista.Controls.Add(this.comboBoxAño);
            this.groupBoxManipularLista.Controls.Add(this.lblMes);
            this.groupBoxManipularLista.Controls.Add(this.comboBoxMes);
            this.groupBoxManipularLista.Controls.Add(this.btnUltiMesCarg);
            this.groupBoxManipularLista.Controls.Add(this.btnVerTodaLista);
            this.groupBoxManipularLista.Controls.Add(this.comboBoxIFijo);
            this.groupBoxManipularLista.Controls.Add(this.checkBoxInsumoFij);
            this.groupBoxManipularLista.Location = new System.Drawing.Point(13, 238);
            this.groupBoxManipularLista.Name = "groupBoxManipularLista";
            this.groupBoxManipularLista.Size = new System.Drawing.Size(249, 302);
            this.groupBoxManipularLista.TabIndex = 21;
            this.groupBoxManipularLista.TabStop = false;
            this.groupBoxManipularLista.Text = "Manipular la Lista";
            // 
            // txtBxBuscar
            // 
            this.txtBxBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtBxBuscar.Location = new System.Drawing.Point(10, 84);
            this.txtBxBuscar.Name = "txtBxBuscar";
            this.txtBxBuscar.Size = new System.Drawing.Size(142, 20);
            this.txtBxBuscar.TabIndex = 14;
            this.txtBxBuscar.Text = "Buscar en descripción";
            this.txtBxBuscar.Click += new System.EventHandler(this.txtBxBuscar_Click);
            this.txtBxBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBxBuscar_KeyUp);
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Location = new System.Drawing.Point(106, 150);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(29, 13);
            this.lblAño.TabIndex = 13;
            this.lblAño.Text = "Año:";
            // 
            // comboBoxAño
            // 
            this.comboBoxAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAño.FormattingEnabled = true;
            this.comboBoxAño.Location = new System.Drawing.Point(143, 146);
            this.comboBoxAño.Name = "comboBoxAño";
            this.comboBoxAño.Size = new System.Drawing.Size(85, 21);
            this.comboBoxAño.TabIndex = 12;
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(13, 150);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(30, 13);
            this.lblMes.TabIndex = 11;
            this.lblMes.Text = "Mes:";
            // 
            // comboBoxMes
            // 
            this.comboBoxMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMes.FormattingEnabled = true;
            this.comboBoxMes.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBoxMes.Location = new System.Drawing.Point(47, 146);
            this.comboBoxMes.Name = "comboBoxMes";
            this.comboBoxMes.Size = new System.Drawing.Size(37, 21);
            this.comboBoxMes.TabIndex = 10;
            // 
            // btnUltiMesCarg
            // 
            this.btnUltiMesCarg.Location = new System.Drawing.Point(10, 53);
            this.btnUltiMesCarg.Name = "btnUltiMesCarg";
            this.btnUltiMesCarg.Size = new System.Drawing.Size(90, 24);
            this.btnUltiMesCarg.TabIndex = 9;
            this.btnUltiMesCarg.Text = "Ultimo mes";
            this.btnUltiMesCarg.UseVisualStyleBackColor = true;
            this.btnUltiMesCarg.Click += new System.EventHandler(this.btnMesactual_Click);
            // 
            // btnVerTodaLista
            // 
            this.btnVerTodaLista.Location = new System.Drawing.Point(10, 24);
            this.btnVerTodaLista.Name = "btnVerTodaLista";
            this.btnVerTodaLista.Size = new System.Drawing.Size(90, 24);
            this.btnVerTodaLista.TabIndex = 8;
            this.btnVerTodaLista.Text = "Ver carga total";
            this.btnVerTodaLista.UseVisualStyleBackColor = true;
            this.btnVerTodaLista.Click += new System.EventHandler(this.btnVerTodaLista_Click);
            this.btnVerTodaLista.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnVerTodaLista_MouseMove);
            // 
            // comboBoxIFijo
            // 
            this.comboBoxIFijo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIFijo.Enabled = false;
            this.comboBoxIFijo.FormattingEnabled = true;
            this.comboBoxIFijo.Location = new System.Drawing.Point(44, 218);
            this.comboBoxIFijo.Name = "comboBoxIFijo";
            this.comboBoxIFijo.Size = new System.Drawing.Size(129, 21);
            this.comboBoxIFijo.TabIndex = 7;
            // 
            // checkBoxInsumoFij
            // 
            this.checkBoxInsumoFij.AutoSize = true;
            this.checkBoxInsumoFij.Location = new System.Drawing.Point(10, 195);
            this.checkBoxInsumoFij.Name = "checkBoxInsumoFij";
            this.checkBoxInsumoFij.Size = new System.Drawing.Size(127, 17);
            this.checkBoxInsumoFij.TabIndex = 6;
            this.checkBoxInsumoFij.Text = "Gasto Fijo Específico";
            this.checkBoxInsumoFij.UseVisualStyleBackColor = true;
            this.checkBoxInsumoFij.CheckedChanged += new System.EventHandler(this.checkBoxInsumoFij_CheckedChanged);
            // 
            // btnModifGasto
            // 
            this.btnModifGasto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModifGasto.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnModifGasto.Location = new System.Drawing.Point(354, 517);
            this.btnModifGasto.Name = "btnModifGasto";
            this.btnModifGasto.Size = new System.Drawing.Size(125, 22);
            this.btnModifGasto.TabIndex = 22;
            this.btnModifGasto.Text = "Guardar Modificación";
            this.btnModifGasto.UseVisualStyleBackColor = true;
            this.btnModifGasto.Visible = false;
            this.btnModifGasto.Click += new System.EventHandler(this.btnModifGasto_Click);
            // 
            // lblPatente
            // 
            this.lblPatente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPatente.AutoSize = true;
            this.lblPatente.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPatente.Location = new System.Drawing.Point(772, 550);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(107, 13);
            this.lblPatente.TabIndex = 24;
            this.lblPatente.Text = "Por Demis Gerometta";
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEstadisticas.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.btnEstadisticas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstadisticas.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnEstadisticas.Location = new System.Drawing.Point(775, 1);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(90, 22);
            this.btnEstadisticas.TabIndex = 26;
            this.btnEstadisticas.Text = "Superávit";
            this.btnEstadisticas.UseVisualStyleBackColor = false;
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            // 
            // btnMenor
            // 
            this.btnMenor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenor.Location = new System.Drawing.Point(790, 27);
            this.btnMenor.Name = "btnMenor";
            this.btnMenor.Size = new System.Drawing.Size(29, 22);
            this.btnMenor.TabIndex = 27;
            this.btnMenor.Text = "<";
            this.btnMenor.UseVisualStyleBackColor = true;
            this.btnMenor.Click += new System.EventHandler(this.btnMenor_Click);
            // 
            // btnMayor
            // 
            this.btnMayor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMayor.Location = new System.Drawing.Point(836, 27);
            this.btnMayor.Name = "btnMayor";
            this.btnMayor.Size = new System.Drawing.Size(29, 22);
            this.btnMayor.TabIndex = 28;
            this.btnMayor.Text = ">";
            this.btnMayor.UseVisualStyleBackColor = true;
            this.btnMayor.Click += new System.EventHandler(this.btnMayor_Click);
            // 
            // textBoxSearchCost
            // 
            this.textBoxSearchCost.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxSearchCost.Location = new System.Drawing.Point(593, 31);
            this.textBoxSearchCost.Name = "textBoxSearchCost";
            this.textBoxSearchCost.Size = new System.Drawing.Size(96, 20);
            this.textBoxSearchCost.TabIndex = 29;
            this.textBoxSearchCost.Text = "Buscar costo";
            this.textBoxSearchCost.TextChanged += new System.EventHandler(this.textBoxSearchCost_TextChanged);
            // 
            // FMPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(886, 562);
            this.Controls.Add(this.textBoxSearchCost);
            this.Controls.Add(this.currencyCboBox);
            this.Controls.Add(this.btnMayor);
            this.Controls.Add(this.btnMenor);
            this.Controls.Add(this.Cargar);
            this.Controls.Add(this.groupBoxManipularLista);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.GastosdataGridView1);
            this.Controls.Add(this.btnEstadisticas);
            this.Controls.Add(this.btnModifGasto);
            this.Controls.Add(this.bnEliminar);
            this.Controls.Add(this.lblPatente);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FMPrincipal";
            this.Text = "Registro Económico Monetario v1.0";
            this.Enter += new System.EventHandler(this.button1Guardar_Click);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1InsFijos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Cargar.ResumeLayout(false);
            this.Cargar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GastosdataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gastoBindingSource)).EndInit();
            this.groupBoxManipularLista.ResumeLayout(false);
            this.groupBoxManipularLista.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1Guardar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1Pesos;
        private System.Windows.Forms.Label label2Peso;
        private System.Windows.Forms.Label label3Cantidad;
        private System.Windows.Forms.TextBox textBox2InVariable;
        private System.Windows.Forms.ComboBox comboBoxInsFijos;
        private System.Windows.Forms.BindingSource bindingSource1InsFijos;//insumo fijo//insumo variable
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.GroupBox Cargar;
        private System.Windows.Forms.Button ButtomModificaciones;
        private System.Windows.Forms.BindingSource gastoBindingSource;
        private System.Windows.Forms.Button bnEliminar;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.GroupBox groupBoxManipularLista;
        private System.Windows.Forms.ComboBox comboBoxIFijo;
        private System.Windows.Forms.CheckBox checkBoxInsumoFij;
        private System.Windows.Forms.Button btnModifGasto;
        private System.Windows.Forms.Button btnVerTodaLista;
        private System.Windows.Forms.Button btnUltiMesCarg;
        private System.Windows.Forms.ComboBox comboBoxMes;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.ComboBox comboBoxAño;
        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.DataGridView GastosdataGridView1;
        private System.Windows.Forms.Button btnEstadisticas;
        private System.Windows.Forms.TextBox txtBxBuscar;
        private System.Windows.Forms.ToolStripMenuItem ingresosToolStripMenuItem;
        private System.Windows.Forms.Button btnMenor;
        private System.Windows.Forms.Button btnMayor;
        private System.Windows.Forms.ToolStripMenuItem exportarAExelToolStripMenuItem;
        private System.Windows.Forms.Label label4TipodInsumo;
        private System.Windows.Forms.ComboBox currencyCboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn insumoFijoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn insumoVariableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn currencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonId;
        private System.Windows.Forms.TextBox textBoxSearchCost;
    }
}

