namespace segundo_parcial
{
    partial class alquiler
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
            this.txtfechadevolucion = new System.Windows.Forms.TextBox();
            this.txtfechaprestamo = new System.Windows.Forms.TextBox();
            this.lblduracion = new System.Windows.Forms.Label();
            this.lblgenero = new System.Windows.Forms.Label();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.btnultimo = new System.Windows.Forms.Button();
            this.btnsiguiente = new System.Windows.Forms.Button();
            this.btnanterior = new System.Windows.Forms.Button();
            this.btnprimero = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.lblidAlquiler = new System.Windows.Forms.Label();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblcliente = new System.Windows.Forms.Label();
            this.lblpeliculas = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.db_sistema_peliculasDataSet7 = new segundo_parcial.db_sistema_peliculasDataSet7();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new segundo_parcial.db_sistema_peliculasDataSet7TableAdapters.clientesTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.db_sistema_peliculasDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtfechadevolucion
            // 
            this.txtfechadevolucion.Location = new System.Drawing.Point(115, 70);
            this.txtfechadevolucion.Name = "txtfechadevolucion";
            this.txtfechadevolucion.Size = new System.Drawing.Size(136, 20);
            this.txtfechadevolucion.TabIndex = 27;
            // 
            // txtfechaprestamo
            // 
            this.txtfechaprestamo.Location = new System.Drawing.Point(115, 33);
            this.txtfechaprestamo.Name = "txtfechaprestamo";
            this.txtfechaprestamo.Size = new System.Drawing.Size(136, 20);
            this.txtfechaprestamo.TabIndex = 26;
            // 
            // lblduracion
            // 
            this.lblduracion.AutoSize = true;
            this.lblduracion.Location = new System.Drawing.Point(12, 77);
            this.lblduracion.Name = "lblduracion";
            this.lblduracion.Size = new System.Drawing.Size(97, 13);
            this.lblduracion.TabIndex = 25;
            this.lblduracion.Text = "Fecha Devolucion:";
            // 
            // lblgenero
            // 
            this.lblgenero.AutoSize = true;
            this.lblgenero.Location = new System.Drawing.Point(12, 33);
            this.lblgenero.Name = "lblgenero";
            this.lblgenero.Size = new System.Drawing.Size(87, 13);
            this.lblgenero.TabIndex = 24;
            this.lblgenero.Text = "Fecha Prestamo:";
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(115, 117);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(136, 20);
            this.txtvalor.TabIndex = 50;
            // 
            // btnultimo
            // 
            this.btnultimo.Location = new System.Drawing.Point(152, 234);
            this.btnultimo.Name = "btnultimo";
            this.btnultimo.Size = new System.Drawing.Size(41, 23);
            this.btnultimo.TabIndex = 49;
            this.btnultimo.Text = ">l";
            this.btnultimo.UseVisualStyleBackColor = true;
            this.btnultimo.Click += new System.EventHandler(this.btnultimo_Click);
            // 
            // btnsiguiente
            // 
            this.btnsiguiente.Location = new System.Drawing.Point(105, 234);
            this.btnsiguiente.Name = "btnsiguiente";
            this.btnsiguiente.Size = new System.Drawing.Size(41, 23);
            this.btnsiguiente.TabIndex = 48;
            this.btnsiguiente.Text = ">";
            this.btnsiguiente.UseVisualStyleBackColor = true;
            this.btnsiguiente.Click += new System.EventHandler(this.btnsiguiente_Click);
            // 
            // btnanterior
            // 
            this.btnanterior.Location = new System.Drawing.Point(58, 234);
            this.btnanterior.Name = "btnanterior";
            this.btnanterior.Size = new System.Drawing.Size(41, 23);
            this.btnanterior.TabIndex = 47;
            this.btnanterior.Text = "<";
            this.btnanterior.UseVisualStyleBackColor = true;
            this.btnanterior.Click += new System.EventHandler(this.btnanterior_Click);
            // 
            // btnprimero
            // 
            this.btnprimero.Location = new System.Drawing.Point(11, 234);
            this.btnprimero.Name = "btnprimero";
            this.btnprimero.Size = new System.Drawing.Size(41, 23);
            this.btnprimero.TabIndex = 46;
            this.btnprimero.Text = "l<";
            this.btnprimero.UseVisualStyleBackColor = true;
            this.btnprimero.Click += new System.EventHandler(this.btnprimero_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(457, 232);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 45;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // lblidAlquiler
            // 
            this.lblidAlquiler.AutoSize = true;
            this.lblidAlquiler.Location = new System.Drawing.Point(267, 33);
            this.lblidAlquiler.Name = "lblidAlquiler";
            this.lblidAlquiler.Size = new System.Drawing.Size(18, 13);
            this.lblidAlquiler.TabIndex = 44;
            this.lblidAlquiler.Text = "ID";
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(376, 232);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 43;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(295, 232);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(75, 23);
            this.btnmodificar.TabIndex = 42;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(214, 232);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 41;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(12, 124);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(34, 13);
            this.lblnombre.TabIndex = 34;
            this.lblnombre.Text = "Valor:";
            // 
            // lblcliente
            // 
            this.lblcliente.AutoSize = true;
            this.lblcliente.Location = new System.Drawing.Point(310, 36);
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Size = new System.Drawing.Size(42, 13);
            this.lblcliente.TabIndex = 51;
            this.lblcliente.Text = "Cliente:";
            // 
            // lblpeliculas
            // 
            this.lblpeliculas.AutoSize = true;
            this.lblpeliculas.Location = new System.Drawing.Point(310, 85);
            this.lblpeliculas.Name = "lblpeliculas";
            this.lblpeliculas.Size = new System.Drawing.Size(47, 13);
            this.lblpeliculas.TabIndex = 52;
            this.lblpeliculas.Text = "Pelicula:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(376, 82);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 54;
            // 
            // db_sistema_peliculasDataSet7
            // 
            this.db_sistema_peliculasDataSet7.DataSetName = "db_sistema_peliculasDataSet7";
            this.db_sistema_peliculasDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "clientes";
            this.clientesBindingSource.DataSource = this.db_sistema_peliculasDataSet7;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(376, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 56;
            // 
            // alquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(566, 269);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.lblpeliculas);
            this.Controls.Add(this.lblcliente);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.btnultimo);
            this.Controls.Add(this.btnsiguiente);
            this.Controls.Add(this.btnanterior);
            this.Controls.Add(this.btnprimero);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.lblidAlquiler);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.txtfechadevolucion);
            this.Controls.Add(this.txtfechaprestamo);
            this.Controls.Add(this.lblduracion);
            this.Controls.Add(this.lblgenero);
            this.Name = "alquiler";
            this.Text = "alquiler";
            this.Load += new System.EventHandler(this.alquiler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_sistema_peliculasDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtfechadevolucion;
        private System.Windows.Forms.TextBox txtfechaprestamo;
        private System.Windows.Forms.Label lblduracion;
        private System.Windows.Forms.Label lblgenero;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Button btnultimo;
        private System.Windows.Forms.Button btnsiguiente;
        private System.Windows.Forms.Button btnanterior;
        private System.Windows.Forms.Button btnprimero;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label lblidAlquiler;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblcliente;
        private System.Windows.Forms.Label lblpeliculas;
        private System.Windows.Forms.ComboBox comboBox2;
        private db_sistema_peliculasDataSet7 db_sistema_peliculasDataSet7;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private db_sistema_peliculasDataSet7TableAdapters.clientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}