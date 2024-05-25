namespace LaboratorioFinal
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCargarDatos = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelIdConsola = new System.Windows.Forms.Label();
            this.labelNombreConsola = new System.Windows.Forms.Label();
            this.labelCompania = new System.Windows.Forms.Label();
            this.labelAnioLanzamiento = new System.Windows.Forms.Label();
            this.labelGeneracion = new System.Windows.Forms.Label();
            this.textBoxIdConsola = new System.Windows.Forms.TextBox();
            this.textBoxNombreConsola = new System.Windows.Forms.TextBox();
            this.textBoxCompania = new System.Windows.Forms.TextBox();
            this.textBoxGeneracion = new System.Windows.Forms.TextBox();
            this.dateTimePickerAnioLanzamiento = new System.Windows.Forms.DateTimePicker();
            this.buttonIngresarDatos = new System.Windows.Forms.Button();
            this.comboBoxCompanias = new System.Windows.Forms.ComboBox();
            this.buttonSiguiente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(633, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oliver Isaac Godoy Salguero 0905-23-10816";
            // 
            // buttonCargarDatos
            // 
            this.buttonCargarDatos.Location = new System.Drawing.Point(312, 258);
            this.buttonCargarDatos.Name = "buttonCargarDatos";
            this.buttonCargarDatos.Size = new System.Drawing.Size(171, 58);
            this.buttonCargarDatos.TabIndex = 1;
            this.buttonCargarDatos.Text = "Cargar Datos";
            this.buttonCargarDatos.UseVisualStyleBackColor = true;
            this.buttonCargarDatos.Click += new System.EventHandler(this.buttonCargarDatos_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 335);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(922, 203);
            this.dataGridView1.TabIndex = 2;
            // 
            // labelIdConsola
            // 
            this.labelIdConsola.AutoSize = true;
            this.labelIdConsola.Location = new System.Drawing.Point(40, 67);
            this.labelIdConsola.Name = "labelIdConsola";
            this.labelIdConsola.Size = new System.Drawing.Size(69, 16);
            this.labelIdConsola.TabIndex = 3;
            this.labelIdConsola.Text = "Id consola";
            // 
            // labelNombreConsola
            // 
            this.labelNombreConsola.AutoSize = true;
            this.labelNombreConsola.Location = new System.Drawing.Point(43, 104);
            this.labelNombreConsola.Name = "labelNombreConsola";
            this.labelNombreConsola.Size = new System.Drawing.Size(109, 16);
            this.labelNombreConsola.TabIndex = 4;
            this.labelNombreConsola.Text = "Nombre Consola";
            // 
            // labelCompania
            // 
            this.labelCompania.AutoSize = true;
            this.labelCompania.Location = new System.Drawing.Point(43, 133);
            this.labelCompania.Name = "labelCompania";
            this.labelCompania.Size = new System.Drawing.Size(69, 16);
            this.labelCompania.TabIndex = 5;
            this.labelCompania.Text = "Compañia";
            // 
            // labelAnioLanzamiento
            // 
            this.labelAnioLanzamiento.AutoSize = true;
            this.labelAnioLanzamiento.Location = new System.Drawing.Point(43, 174);
            this.labelAnioLanzamiento.Name = "labelAnioLanzamiento";
            this.labelAnioLanzamiento.Size = new System.Drawing.Size(129, 16);
            this.labelAnioLanzamiento.TabIndex = 6;
            this.labelAnioLanzamiento.Text = "Año de Lanzamiento";
            // 
            // labelGeneracion
            // 
            this.labelGeneracion.AutoSize = true;
            this.labelGeneracion.Location = new System.Drawing.Point(43, 211);
            this.labelGeneracion.Name = "labelGeneracion";
            this.labelGeneracion.Size = new System.Drawing.Size(77, 16);
            this.labelGeneracion.TabIndex = 7;
            this.labelGeneracion.Text = "Generación";
            // 
            // textBoxIdConsola
            // 
            this.textBoxIdConsola.Location = new System.Drawing.Point(217, 67);
            this.textBoxIdConsola.Name = "textBoxIdConsola";
            this.textBoxIdConsola.Size = new System.Drawing.Size(200, 22);
            this.textBoxIdConsola.TabIndex = 8;
            // 
            // textBoxNombreConsola
            // 
            this.textBoxNombreConsola.Location = new System.Drawing.Point(217, 104);
            this.textBoxNombreConsola.Name = "textBoxNombreConsola";
            this.textBoxNombreConsola.Size = new System.Drawing.Size(200, 22);
            this.textBoxNombreConsola.TabIndex = 9;
            // 
            // textBoxCompania
            // 
            this.textBoxCompania.Location = new System.Drawing.Point(217, 133);
            this.textBoxCompania.Name = "textBoxCompania";
            this.textBoxCompania.Size = new System.Drawing.Size(200, 22);
            this.textBoxCompania.TabIndex = 10;
            // 
            // textBoxGeneracion
            // 
            this.textBoxGeneracion.Location = new System.Drawing.Point(217, 211);
            this.textBoxGeneracion.Name = "textBoxGeneracion";
            this.textBoxGeneracion.Size = new System.Drawing.Size(200, 22);
            this.textBoxGeneracion.TabIndex = 12;
            // 
            // dateTimePickerAnioLanzamiento
            // 
            this.dateTimePickerAnioLanzamiento.Location = new System.Drawing.Point(217, 174);
            this.dateTimePickerAnioLanzamiento.Name = "dateTimePickerAnioLanzamiento";
            this.dateTimePickerAnioLanzamiento.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerAnioLanzamiento.TabIndex = 13;
            // 
            // buttonIngresarDatos
            // 
            this.buttonIngresarDatos.Location = new System.Drawing.Point(88, 258);
            this.buttonIngresarDatos.Name = "buttonIngresarDatos";
            this.buttonIngresarDatos.Size = new System.Drawing.Size(166, 58);
            this.buttonIngresarDatos.TabIndex = 14;
            this.buttonIngresarDatos.Text = "Ingresar Datos";
            this.buttonIngresarDatos.UseVisualStyleBackColor = true;
            this.buttonIngresarDatos.Click += new System.EventHandler(this.buttonIngresarDatos_Click);
            // 
            // comboBoxCompanias
            // 
            this.comboBoxCompanias.FormattingEnabled = true;
            this.comboBoxCompanias.Items.AddRange(new object[] {
            "Atari",
            "Coleco",
            "Mattel",
            "Microsoft",
            "Nintendo",
            "Ouya Inc.",
            "Sega",
            "Sony"});
            this.comboBoxCompanias.Location = new System.Drawing.Point(434, 133);
            this.comboBoxCompanias.Name = "comboBoxCompanias";
            this.comboBoxCompanias.Size = new System.Drawing.Size(166, 24);
            this.comboBoxCompanias.TabIndex = 15;
            // 
            // buttonSiguiente
            // 
            this.buttonSiguiente.Location = new System.Drawing.Point(541, 258);
            this.buttonSiguiente.Name = "buttonSiguiente";
            this.buttonSiguiente.Size = new System.Drawing.Size(125, 58);
            this.buttonSiguiente.TabIndex = 16;
            this.buttonSiguiente.Text = "Siguiente -->";
            this.buttonSiguiente.UseVisualStyleBackColor = true;
            this.buttonSiguiente.Click += new System.EventHandler(this.buttonSiguiente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 593);
            this.Controls.Add(this.buttonSiguiente);
            this.Controls.Add(this.comboBoxCompanias);
            this.Controls.Add(this.buttonIngresarDatos);
            this.Controls.Add(this.dateTimePickerAnioLanzamiento);
            this.Controls.Add(this.textBoxGeneracion);
            this.Controls.Add(this.textBoxCompania);
            this.Controls.Add(this.textBoxNombreConsola);
            this.Controls.Add(this.textBoxIdConsola);
            this.Controls.Add(this.labelGeneracion);
            this.Controls.Add(this.labelAnioLanzamiento);
            this.Controls.Add(this.labelCompania);
            this.Controls.Add(this.labelNombreConsola);
            this.Controls.Add(this.labelIdConsola);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonCargarDatos);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCargarDatos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelIdConsola;
        private System.Windows.Forms.Label labelNombreConsola;
        private System.Windows.Forms.Label labelCompania;
        private System.Windows.Forms.Label labelAnioLanzamiento;
        private System.Windows.Forms.Label labelGeneracion;
        private System.Windows.Forms.TextBox textBoxIdConsola;
        private System.Windows.Forms.TextBox textBoxNombreConsola;
        private System.Windows.Forms.TextBox textBoxCompania;
        private System.Windows.Forms.TextBox textBoxGeneracion;
        private System.Windows.Forms.DateTimePicker dateTimePickerAnioLanzamiento;
        private System.Windows.Forms.Button buttonIngresarDatos;
        private System.Windows.Forms.ComboBox comboBoxCompanias;
        private System.Windows.Forms.Button buttonSiguiente;
    }
}

