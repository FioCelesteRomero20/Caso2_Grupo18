namespace Caso2_Grupo18
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvRegistroVideojuego = new System.Windows.Forms.DataGridView();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.rbtnPerdió = new System.Windows.Forms.RadioButton();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.RButtGane = new System.Windows.Forms.RadioButton();
            this.textNewEliminar = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblPuntosTotales = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonQuitar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroVideojuego)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonQuitar);
            this.groupBox1.Controls.Add(this.dgvRegistroVideojuego);
            this.groupBox1.Controls.Add(this.buttonRegistrar);
            this.groupBox1.Controls.Add(this.rbtnPerdió);
            this.groupBox1.Controls.Add(this.buttonSalir);
            this.groupBox1.Controls.Add(this.RButtGane);
            this.groupBox1.Controls.Add(this.textNewEliminar);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.lblPuntosTotales);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(32, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 469);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de videojuegos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dgvRegistroVideojuego
            // 
            this.dgvRegistroVideojuego.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvRegistroVideojuego.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistroVideojuego.Location = new System.Drawing.Point(17, 257);
            this.dgvRegistroVideojuego.Name = "dgvRegistroVideojuego";
            this.dgvRegistroVideojuego.Size = new System.Drawing.Size(240, 150);
            this.dgvRegistroVideojuego.TabIndex = 13;
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonRegistrar.Location = new System.Drawing.Point(217, 110);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(83, 27);
            this.buttonRegistrar.TabIndex = 3;
            this.buttonRegistrar.Text = "Registrar";
            this.buttonRegistrar.UseVisualStyleBackColor = false;
            this.buttonRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click);
            // 
            // rbtnPerdió
            // 
            this.rbtnPerdió.AutoSize = true;
            this.rbtnPerdió.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbtnPerdió.Location = new System.Drawing.Point(419, 73);
            this.rbtnPerdió.Name = "rbtnPerdió";
            this.rbtnPerdió.Size = new System.Drawing.Size(75, 17);
            this.rbtnPerdió.TabIndex = 6;
            this.rbtnPerdió.TabStop = true;
            this.rbtnPerdió.Text = "Perdí (-20)";
            this.rbtnPerdió.UseVisualStyleBackColor = true;
            // 
            // buttonSalir
            // 
            this.buttonSalir.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonSalir.Location = new System.Drawing.Point(419, 193);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(83, 27);
            this.buttonSalir.TabIndex = 10;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = false;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // RButtGane
            // 
            this.RButtGane.AutoSize = true;
            this.RButtGane.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RButtGane.Location = new System.Drawing.Point(419, 28);
            this.RButtGane.Name = "RButtGane";
            this.RButtGane.Size = new System.Drawing.Size(84, 17);
            this.RButtGane.TabIndex = 2;
            this.RButtGane.TabStop = true;
            this.RButtGane.Text = "Gané (+100)";
            this.RButtGane.UseVisualStyleBackColor = true;
            this.RButtGane.CheckedChanged += new System.EventHandler(this.RButtGane_CheckedChanged);
            // 
            // textNewEliminar
            // 
            this.textNewEliminar.Location = new System.Drawing.Point(252, 154);
            this.textNewEliminar.Name = "textNewEliminar";
            this.textNewEliminar.Size = new System.Drawing.Size(250, 20);
            this.textNewEliminar.TabIndex = 12;
            this.textNewEliminar.TextChanged += new System.EventHandler(this.textNewEliminar_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(174, 27);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(187, 20);
            this.textBox2.TabIndex = 8;
            // 
            // lblPuntosTotales
            // 
            this.lblPuntosTotales.AutoSize = true;
            this.lblPuntosTotales.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPuntosTotales.Location = new System.Drawing.Point(26, 30);
            this.lblPuntosTotales.Name = "lblPuntosTotales";
            this.lblPuntosTotales.Size = new System.Drawing.Size(126, 13);
            this.lblPuntosTotales.TabIndex = 5;
            this.lblPuntosTotales.Text = "Nombre del Videojuego : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(26, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ingrese Videojuego a Eliminar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(26, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fecha :";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Location = new System.Drawing.Point(174, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 20);
            this.textBox1.TabIndex = 6;
            // 
            // buttonQuitar
            // 
            this.buttonQuitar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonQuitar.Location = new System.Drawing.Point(278, 193);
            this.buttonQuitar.Name = "buttonQuitar";
            this.buttonQuitar.Size = new System.Drawing.Size(83, 27);
            this.buttonQuitar.TabIndex = 14;
            this.buttonQuitar.Text = "Quitar";
            this.buttonQuitar.UseVisualStyleBackColor = false;
            this.buttonQuitar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 531);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroVideojuego)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvRegistroVideojuego;
        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.RadioButton rbtnPerdió;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.RadioButton RButtGane;
        private System.Windows.Forms.TextBox textNewEliminar;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblPuntosTotales;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonQuitar;
    }
}

