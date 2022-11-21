
namespace Modelo2doParcialXML
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rbAutomovil = new System.Windows.Forms.RadioButton();
            this.rbMaritima = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIDpoliza = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgridPolizas = new System.Windows.Forms.DataGridView();
            this.dgridClientes = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.rbMostrarAutomovil = new System.Windows.Forms.RadioButton();
            this.rbMostrarMaritima = new System.Windows.Forms.RadioButton();
            this.btnEliminarPoliza = new System.Windows.Forms.Button();
            this.btnModificarPoliza = new System.Windows.Forms.Button();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.numupPrima = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridPolizas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgridClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numupPrima)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(40, 348);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(173, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(40, 387);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(173, 20);
            this.txtApellido.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellido";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(40, 426);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(173, 20);
            this.txtDni.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dni";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(40, 309);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(173, 20);
            this.txtID.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Prima";
            // 
            // rbAutomovil
            // 
            this.rbAutomovil.AutoSize = true;
            this.rbAutomovil.Location = new System.Drawing.Point(40, 113);
            this.rbAutomovil.Name = "rbAutomovil";
            this.rbAutomovil.Size = new System.Drawing.Size(71, 17);
            this.rbAutomovil.TabIndex = 12;
            this.rbAutomovil.TabStop = true;
            this.rbAutomovil.Text = "Automovil";
            this.rbAutomovil.UseVisualStyleBackColor = true;
            this.rbAutomovil.CheckedChanged += new System.EventHandler(this.rbAutomovil_CheckedChanged);
            // 
            // rbMaritima
            // 
            this.rbMaritima.AutoSize = true;
            this.rbMaritima.Location = new System.Drawing.Point(117, 113);
            this.rbMaritima.Name = "rbMaritima";
            this.rbMaritima.Size = new System.Drawing.Size(64, 17);
            this.rbMaritima.TabIndex = 13;
            this.rbMaritima.TabStop = true;
            this.rbMaritima.Text = "Maritima";
            this.rbMaritima.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Tipo de Poliza";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Modelo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Marca";
            // 
            // txtIDpoliza
            // 
            this.txtIDpoliza.Location = new System.Drawing.Point(40, 25);
            this.txtIDpoliza.Name = "txtIDpoliza";
            this.txtIDpoliza.Size = new System.Drawing.Size(173, 20);
            this.txtIDpoliza.TabIndex = 17;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(13, 32);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(159, 20);
            this.txtMarca.TabIndex = 19;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(13, 71);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(159, 20);
            this.txtModelo.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtModelo);
            this.groupBox1.Controls.Add(this.txtMarca);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(34, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 102);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // dgridPolizas
            // 
            this.dgridPolizas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridPolizas.Location = new System.Drawing.Point(138, 33);
            this.dgridPolizas.Name = "dgridPolizas";
            this.dgridPolizas.Size = new System.Drawing.Size(318, 186);
            this.dgridPolizas.TabIndex = 22;
            this.dgridPolizas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgridPolizas_CellContentDoubleClick);
            // 
            // dgridClientes
            // 
            this.dgridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgridClientes.Location = new System.Drawing.Point(138, 278);
            this.dgridClientes.Name = "dgridClientes";
            this.dgridClientes.Size = new System.Drawing.Size(318, 153);
            this.dgridClientes.TabIndex = 23;
            this.dgridClientes.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgridClientes_CellContentDoubleClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(72, 250);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAgregar.Size = new System.Drawing.Size(96, 37);
            this.btnAgregar.TabIndex = 24;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // rbMostrarAutomovil
            // 
            this.rbMostrarAutomovil.AutoSize = true;
            this.rbMostrarAutomovil.Location = new System.Drawing.Point(138, 10);
            this.rbMostrarAutomovil.Name = "rbMostrarAutomovil";
            this.rbMostrarAutomovil.Size = new System.Drawing.Size(101, 17);
            this.rbMostrarAutomovil.TabIndex = 25;
            this.rbMostrarAutomovil.TabStop = true;
            this.rbMostrarAutomovil.Text = "Ver Automoviles";
            this.rbMostrarAutomovil.UseVisualStyleBackColor = true;
            this.rbMostrarAutomovil.CheckedChanged += new System.EventHandler(this.rbMostrarAutomovil_CheckedChanged);
            // 
            // rbMostrarMaritima
            // 
            this.rbMostrarMaritima.AutoSize = true;
            this.rbMostrarMaritima.Location = new System.Drawing.Point(245, 10);
            this.rbMostrarMaritima.Name = "rbMostrarMaritima";
            this.rbMostrarMaritima.Size = new System.Drawing.Size(88, 17);
            this.rbMostrarMaritima.TabIndex = 26;
            this.rbMostrarMaritima.TabStop = true;
            this.rbMostrarMaritima.Text = "Ver Maritimas";
            this.rbMostrarMaritima.UseVisualStyleBackColor = true;
            this.rbMostrarMaritima.CheckedChanged += new System.EventHandler(this.rbMostrarMaritima_CheckedChanged);
            // 
            // btnEliminarPoliza
            // 
            this.btnEliminarPoliza.Location = new System.Drawing.Point(36, 72);
            this.btnEliminarPoliza.Name = "btnEliminarPoliza";
            this.btnEliminarPoliza.Size = new System.Drawing.Size(96, 23);
            this.btnEliminarPoliza.TabIndex = 27;
            this.btnEliminarPoliza.Text = "Eliminar Poliza";
            this.btnEliminarPoliza.UseVisualStyleBackColor = true;
            this.btnEliminarPoliza.Click += new System.EventHandler(this.btnEliminarPoliza_Click);
            // 
            // btnModificarPoliza
            // 
            this.btnModificarPoliza.Location = new System.Drawing.Point(36, 33);
            this.btnModificarPoliza.Name = "btnModificarPoliza";
            this.btnModificarPoliza.Size = new System.Drawing.Size(96, 36);
            this.btnModificarPoliza.TabIndex = 28;
            this.btnModificarPoliza.Text = "Modificar Poliza";
            this.btnModificarPoliza.UseVisualStyleBackColor = true;
            this.btnModificarPoliza.Click += new System.EventHandler(this.btnModificarPoliza_Click);
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.Location = new System.Drawing.Point(36, 320);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(96, 23);
            this.btnEliminarCliente.TabIndex = 29;
            this.btnEliminarCliente.Text = "EliminarCliente";
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.Location = new System.Drawing.Point(36, 278);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(96, 36);
            this.btnModificarCliente.TabIndex = 30;
            this.btnModificarCliente.Text = "Modificar Cliente";
            this.btnModificarCliente.UseVisualStyleBackColor = true;
            // 
            // numupPrima
            // 
            this.numupPrima.DecimalPlaces = 2;
            this.numupPrima.Location = new System.Drawing.Point(40, 64);
            this.numupPrima.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.numupPrima.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numupPrima.Name = "numupPrima";
            this.numupPrima.Size = new System.Drawing.Size(173, 20);
            this.numupPrima.TabIndex = 31;
            this.numupPrima.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "Cargar Clientes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnModificarCliente);
            this.groupBox2.Controls.Add(this.btnEliminarCliente);
            this.groupBox2.Controls.Add(this.btnModificarPoliza);
            this.groupBox2.Controls.Add(this.btnEliminarPoliza);
            this.groupBox2.Controls.Add(this.rbMostrarMaritima);
            this.groupBox2.Controls.Add(this.rbMostrarAutomovil);
            this.groupBox2.Controls.Add(this.dgridClientes);
            this.groupBox2.Controls.Add(this.dgridPolizas);
            this.groupBox2.Location = new System.Drawing.Point(281, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(492, 457);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 519);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.numupPrima);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtIDpoliza);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rbMaritima);
            this.Controls.Add(this.rbAutomovil);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgridPolizas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgridClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numupPrima)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbAutomovil;
        private System.Windows.Forms.RadioButton rbMaritima;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtIDpoliza;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgridPolizas;
        private System.Windows.Forms.DataGridView dgridClientes;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.RadioButton rbMostrarAutomovil;
        private System.Windows.Forms.RadioButton rbMostrarMaritima;
        private System.Windows.Forms.Button btnEliminarPoliza;
        private System.Windows.Forms.Button btnModificarPoliza;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.NumericUpDown numupPrima;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

