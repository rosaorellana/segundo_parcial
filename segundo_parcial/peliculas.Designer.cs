namespace segundo_parcial
{
    partial class peliculas
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
            this.txtduracion = new System.Windows.Forms.TextBox();
            this.txtgenero = new System.Windows.Forms.TextBox();
            this.txtsinopsis = new System.Windows.Forms.TextBox();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.lblduracion = new System.Windows.Forms.Label();
            this.lblgenero = new System.Windows.Forms.Label();
            this.lblsinopsis = new System.Windows.Forms.Label();
            this.lbldescripcion = new System.Windows.Forms.Label();
            this.lblidPelicula = new System.Windows.Forms.Label();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnultimo = new System.Windows.Forms.Button();
            this.btnsiguiente = new System.Windows.Forms.Button();
            this.btnanterior = new System.Windows.Forms.Button();
            this.btnprimero = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtduracion
            // 
            this.txtduracion.Location = new System.Drawing.Point(74, 184);
            this.txtduracion.Name = "txtduracion";
            this.txtduracion.Size = new System.Drawing.Size(162, 20);
            this.txtduracion.TabIndex = 23;
            // 
            // txtgenero
            // 
            this.txtgenero.Location = new System.Drawing.Point(74, 140);
            this.txtgenero.Name = "txtgenero";
            this.txtgenero.Size = new System.Drawing.Size(136, 20);
            this.txtgenero.TabIndex = 22;
            // 
            // txtsinopsis
            // 
            this.txtsinopsis.Location = new System.Drawing.Point(74, 74);
            this.txtsinopsis.Multiline = true;
            this.txtsinopsis.Name = "txtsinopsis";
            this.txtsinopsis.Size = new System.Drawing.Size(286, 49);
            this.txtsinopsis.TabIndex = 21;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(74, 19);
            this.txtdescripcion.Multiline = true;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(286, 49);
            this.txtdescripcion.TabIndex = 20;
            // 
            // lblduracion
            // 
            this.lblduracion.AutoSize = true;
            this.lblduracion.Location = new System.Drawing.Point(13, 184);
            this.lblduracion.Name = "lblduracion";
            this.lblduracion.Size = new System.Drawing.Size(53, 13);
            this.lblduracion.TabIndex = 19;
            this.lblduracion.Text = "Duracion:";
            // 
            // lblgenero
            // 
            this.lblgenero.AutoSize = true;
            this.lblgenero.Location = new System.Drawing.Point(13, 140);
            this.lblgenero.Name = "lblgenero";
            this.lblgenero.Size = new System.Drawing.Size(45, 13);
            this.lblgenero.TabIndex = 18;
            this.lblgenero.Text = "Genero:";
            // 
            // lblsinopsis
            // 
            this.lblsinopsis.AutoSize = true;
            this.lblsinopsis.Location = new System.Drawing.Point(13, 77);
            this.lblsinopsis.Name = "lblsinopsis";
            this.lblsinopsis.Size = new System.Drawing.Size(49, 13);
            this.lblsinopsis.TabIndex = 17;
            this.lblsinopsis.Text = "Sinopsis:";
            // 
            // lbldescripcion
            // 
            this.lbldescripcion.AutoSize = true;
            this.lbldescripcion.Location = new System.Drawing.Point(2, 31);
            this.lbldescripcion.Name = "lbldescripcion";
            this.lbldescripcion.Size = new System.Drawing.Size(66, 13);
            this.lbldescripcion.TabIndex = 16;
            this.lbldescripcion.Text = "Descripcion:";
            // 
            // lblidPelicula
            // 
            this.lblidPelicula.AutoSize = true;
            this.lblidPelicula.Location = new System.Drawing.Point(363, 22);
            this.lblidPelicula.Name = "lblidPelicula";
            this.lblidPelicula.Size = new System.Drawing.Size(18, 13);
            this.lblidPelicula.TabIndex = 28;
            this.lblidPelicula.Text = "ID";
            this.lblidPelicula.Click += new System.EventHandler(this.lblidPelicula_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(366, 253);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 33;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(285, 253);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(75, 23);
            this.btnmodificar.TabIndex = 32;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(204, 253);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 31;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(447, 253);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 34;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnultimo
            // 
            this.btnultimo.Location = new System.Drawing.Point(149, 253);
            this.btnultimo.Name = "btnultimo";
            this.btnultimo.Size = new System.Drawing.Size(41, 23);
            this.btnultimo.TabIndex = 38;
            this.btnultimo.Text = ">l";
            this.btnultimo.UseVisualStyleBackColor = true;
            this.btnultimo.Click += new System.EventHandler(this.btnultimo_Click);
            // 
            // btnsiguiente
            // 
            this.btnsiguiente.Location = new System.Drawing.Point(102, 253);
            this.btnsiguiente.Name = "btnsiguiente";
            this.btnsiguiente.Size = new System.Drawing.Size(41, 23);
            this.btnsiguiente.TabIndex = 37;
            this.btnsiguiente.Text = ">";
            this.btnsiguiente.UseVisualStyleBackColor = true;
            this.btnsiguiente.Click += new System.EventHandler(this.btnsiguiente_Click);
            // 
            // btnanterior
            // 
            this.btnanterior.Location = new System.Drawing.Point(55, 253);
            this.btnanterior.Name = "btnanterior";
            this.btnanterior.Size = new System.Drawing.Size(41, 23);
            this.btnanterior.TabIndex = 36;
            this.btnanterior.Text = "<";
            this.btnanterior.UseVisualStyleBackColor = true;
            this.btnanterior.Click += new System.EventHandler(this.btnanterior_Click);
            // 
            // btnprimero
            // 
            this.btnprimero.Location = new System.Drawing.Point(8, 253);
            this.btnprimero.Name = "btnprimero";
            this.btnprimero.Size = new System.Drawing.Size(41, 23);
            this.btnprimero.TabIndex = 35;
            this.btnprimero.Text = "l<";
            this.btnprimero.UseVisualStyleBackColor = true;
            this.btnprimero.Click += new System.EventHandler(this.btnprimero_Click);
            // 
            // peliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(530, 290);
            this.Controls.Add(this.btnultimo);
            this.Controls.Add(this.btnsiguiente);
            this.Controls.Add(this.btnanterior);
            this.Controls.Add(this.btnprimero);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.lblidPelicula);
            this.Controls.Add(this.txtduracion);
            this.Controls.Add(this.txtgenero);
            this.Controls.Add(this.txtsinopsis);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.lblduracion);
            this.Controls.Add(this.lblgenero);
            this.Controls.Add(this.lblsinopsis);
            this.Controls.Add(this.lbldescripcion);
            this.Name = "peliculas";
            this.Text = "peliculas";
            this.Load += new System.EventHandler(this.peliculas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtduracion;
        private System.Windows.Forms.TextBox txtgenero;
        private System.Windows.Forms.TextBox txtsinopsis;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label lblduracion;
        private System.Windows.Forms.Label lblgenero;
        private System.Windows.Forms.Label lblsinopsis;
        private System.Windows.Forms.Label lbldescripcion;
        private System.Windows.Forms.Label lblidPelicula;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnultimo;
        private System.Windows.Forms.Button btnsiguiente;
        private System.Windows.Forms.Button btnanterior;
        private System.Windows.Forms.Button btnprimero;
    }
}