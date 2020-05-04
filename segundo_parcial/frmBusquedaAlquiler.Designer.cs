namespace segundo_parcial
{
    partial class busqueda_alquiler
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
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnseleccionar = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.lblbuscar = new System.Windows.Forms.Label();
            this.db_sistema_peliculasDataSet6 = new segundo_parcial.db_sistema_peliculasDataSet6();
            this.alquilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alquilerTableAdapter = new segundo_parcial.db_sistema_peliculasDataSet6TableAdapters.alquilerTableAdapter();
            this.grdBusquedaAlquiler = new System.Windows.Forms.DataGridView();
            this.idAlquilerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaprestamoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechadevolucionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alquilerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.db_sistema_peliculasDataSet61 = new segundo_parcial.db_sistema_peliculasDataSet6();
            ((System.ComponentModel.ISupportInitialize)(this.db_sistema_peliculasDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alquilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdBusquedaAlquiler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alquilerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_sistema_peliculasDataSet61)).BeginInit();
            this.SuspendLayout();
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(482, 294);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 41;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.Location = new System.Drawing.Point(401, 294);
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.Size = new System.Drawing.Size(75, 23);
            this.btnseleccionar.TabIndex = 40;
            this.btnseleccionar.Text = "Seleccionar";
            this.btnseleccionar.UseVisualStyleBackColor = true;
            this.btnseleccionar.Click += new System.EventHandler(this.btnseleccionar_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(60, 12);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(255, 20);
            this.txtbuscar.TabIndex = 38;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Location = new System.Drawing.Point(11, 15);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(43, 13);
            this.lblbuscar.TabIndex = 37;
            this.lblbuscar.Text = "Buscar:";
            // 
            // db_sistema_peliculasDataSet6
            // 
            this.db_sistema_peliculasDataSet6.DataSetName = "db_sistema_peliculasDataSet6";
            this.db_sistema_peliculasDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alquilerBindingSource
            // 
            this.alquilerBindingSource.DataMember = "alquiler";
            this.alquilerBindingSource.DataSource = this.db_sistema_peliculasDataSet6;
            // 
            // alquilerTableAdapter
            // 
            this.alquilerTableAdapter.ClearBeforeFill = true;
            // 
            // grdBusquedaAlquiler
            // 
            this.grdBusquedaAlquiler.AutoGenerateColumns = false;
            this.grdBusquedaAlquiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBusquedaAlquiler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAlquilerDataGridViewTextBoxColumn,
            this.fechaprestamoDataGridViewTextBoxColumn,
            this.fechadevolucionDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn});
            this.grdBusquedaAlquiler.DataSource = this.alquilerBindingSource1;
            this.grdBusquedaAlquiler.Location = new System.Drawing.Point(12, 38);
            this.grdBusquedaAlquiler.Name = "grdBusquedaAlquiler";
            this.grdBusquedaAlquiler.Size = new System.Drawing.Size(546, 250);
            this.grdBusquedaAlquiler.TabIndex = 42;
            // 
            // idAlquilerDataGridViewTextBoxColumn
            // 
            this.idAlquilerDataGridViewTextBoxColumn.DataPropertyName = "idAlquiler";
            this.idAlquilerDataGridViewTextBoxColumn.HeaderText = "idAlquiler";
            this.idAlquilerDataGridViewTextBoxColumn.Name = "idAlquilerDataGridViewTextBoxColumn";
            // 
            // fechaprestamoDataGridViewTextBoxColumn
            // 
            this.fechaprestamoDataGridViewTextBoxColumn.DataPropertyName = "fechaprestamo";
            this.fechaprestamoDataGridViewTextBoxColumn.HeaderText = "fechaprestamo";
            this.fechaprestamoDataGridViewTextBoxColumn.Name = "fechaprestamoDataGridViewTextBoxColumn";
            // 
            // fechadevolucionDataGridViewTextBoxColumn
            // 
            this.fechadevolucionDataGridViewTextBoxColumn.DataPropertyName = "fechadevolucion";
            this.fechadevolucionDataGridViewTextBoxColumn.HeaderText = "fechadevolucion";
            this.fechadevolucionDataGridViewTextBoxColumn.Name = "fechadevolucionDataGridViewTextBoxColumn";
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            // 
            // alquilerBindingSource1
            // 
            this.alquilerBindingSource1.DataMember = "alquiler";
            this.alquilerBindingSource1.DataSource = this.db_sistema_peliculasDataSet61;
            // 
            // db_sistema_peliculasDataSet61
            // 
            this.db_sistema_peliculasDataSet61.DataSetName = "db_sistema_peliculasDataSet6";
            this.db_sistema_peliculasDataSet61.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // busqueda_alquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(569, 329);
            this.Controls.Add(this.grdBusquedaAlquiler);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnseleccionar);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.lblbuscar);
            this.Name = "busqueda_alquiler";
            this.Text = "frmBusquedaAlquiler";
            this.Load += new System.EventHandler(this.frmBusquedaAlquiler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_sistema_peliculasDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alquilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdBusquedaAlquiler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alquilerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_sistema_peliculasDataSet61)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnseleccionar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label lblbuscar;
        private db_sistema_peliculasDataSet6 db_sistema_peliculasDataSet6;
        private System.Windows.Forms.BindingSource alquilerBindingSource;
        private db_sistema_peliculasDataSet6TableAdapters.alquilerTableAdapter alquilerTableAdapter;
        private System.Windows.Forms.DataGridView grdBusquedaAlquiler;
        private db_sistema_peliculasDataSet6 db_sistema_peliculasDataSet61;
        private System.Windows.Forms.BindingSource alquilerBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAlquilerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaprestamoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechadevolucionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
    }
}