namespace reg_monetario
{
    partial class ABMInsumoFijo
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
            this.txtBInsFijos = new System.Windows.Forms.TextBox();
            this.btnGuardarInsFij = new System.Windows.Forms.Button();
            this.InsumosFdataGridView1 = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.Button();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insumoFijoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblModificaar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.InsumosFdataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insumoFijoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBInsFijos
            // 
            this.txtBInsFijos.Location = new System.Drawing.Point(213, 34);
            this.txtBInsFijos.Name = "txtBInsFijos";
            this.txtBInsFijos.Size = new System.Drawing.Size(100, 20);
            this.txtBInsFijos.TabIndex = 17;
            // 
            // btnGuardarInsFij
            // 
            this.btnGuardarInsFij.Location = new System.Drawing.Point(213, 60);
            this.btnGuardarInsFij.Name = "btnGuardarInsFij";
            this.btnGuardarInsFij.Size = new System.Drawing.Size(100, 23);
            this.btnGuardarInsFij.TabIndex = 19;
            this.btnGuardarInsFij.Text = "Guardar";
            this.btnGuardarInsFij.UseVisualStyleBackColor = true;
            this.btnGuardarInsFij.Click += new System.EventHandler(this.GuardarInsFij_Click_1);
            // 
            // InsumosFdataGridView1
            // 
            this.InsumosFdataGridView1.AllowUserToAddRows = false;
            this.InsumosFdataGridView1.AutoGenerateColumns = false;
            this.InsumosFdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InsumosFdataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn});
            this.InsumosFdataGridView1.DataSource = this.insumoFijoBindingSource;
            this.InsumosFdataGridView1.Location = new System.Drawing.Point(12, 34);
            this.InsumosFdataGridView1.Name = "InsumosFdataGridView1";
            this.InsumosFdataGridView1.Size = new System.Drawing.Size(183, 296);
            this.InsumosFdataGridView1.TabIndex = 20;
            this.InsumosFdataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InsumosFdataGridView1_CellDoubleClick);
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(213, 89);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(100, 23);
            this.Eliminar.TabIndex = 21;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nombreDataGridViewTextBoxColumn.Width = 125;
            // 
            // insumoFijoBindingSource
            // 
            this.insumoFijoBindingSource.DataSource = typeof(reg_monetario.Clases.InsumoFijo);
            // 
            // lblModificaar
            // 
            this.lblModificaar.AutoSize = true;
            this.lblModificaar.Location = new System.Drawing.Point(13, 341);
            this.lblModificaar.Name = "lblModificaar";
            this.lblModificaar.Size = new System.Drawing.Size(171, 13);
            this.lblModificaar.TabIndex = 22;
            this.lblModificaar.Text = "Doble click para modificar un dato.";
            // 
            // ABMInsumoFijo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 366);
            this.Controls.Add(this.lblModificaar);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.InsumosFdataGridView1);
            this.Controls.Add(this.btnGuardarInsFij);
            this.Controls.Add(this.txtBInsFijos);
            this.Name = "ABMInsumoFijo";
            this.Text = "Modificaciones de Insumos Fijos";
            ((System.ComponentModel.ISupportInitialize)(this.InsumosFdataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insumoFijoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBInsFijos;
        private System.Windows.Forms.Button btnGuardarInsFij;
        private System.Windows.Forms.DataGridView InsumosFdataGridView1;
        private System.Windows.Forms.BindingSource insumoFijoBindingSource;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblModificaar;
    }
}