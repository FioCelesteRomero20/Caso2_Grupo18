﻿namespace Caso2_Grupo18
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPuntosTotales = new System.Windows.Forms.Label();
            this.dgvRegistroVideojuego = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.rbtnPerdió = new System.Windows.Forms.RadioButton();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.RButtGane = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.NombreVideojuego = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistroVideojuego)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPuntosTotales);
            this.groupBox1.Controls.Add(this.dgvRegistroVideojuego);
            this.groupBox1.Controls.Add(this.buttonRegistrar);
            this.groupBox1.Controls.Add(this.rbtnPerdió);
            this.groupBox1.Controls.Add(this.buttonSalir);
            this.groupBox1.Controls.Add(this.RButtGane);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.NombreVideojuego);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(32, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 507);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de videojuegos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblPuntosTotales
            // 
            this.lblPuntosTotales.AutoSize = true;
            this.lblPuntosTotales.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPuntosTotales.Location = new System.Drawing.Point(314, 456);
            this.lblPuntosTotales.Name = "lblPuntosTotales";
            this.lblPuntosTotales.Size = new System.Drawing.Size(88, 13);
            this.lblPuntosTotales.TabIndex = 15;
            this.lblPuntosTotales.Text = "Total de Puntos: ";
            this.lblPuntosTotales.Click += new System.EventHandler(this.label3_Click);
            // 
            // dgvRegistroVideojuego
            // 
            this.dgvRegistroVideojuego.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRegistroVideojuego.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRegistroVideojuego.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvRegistroVideojuego.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRegistroVideojuego.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRegistroVideojuego.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRegistroVideojuego.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRegistroVideojuego.ColumnHeadersHeight = 30;
            this.dgvRegistroVideojuego.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRegistroVideojuego.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvRegistroVideojuego.EnableHeadersVisualStyles = false;
            this.dgvRegistroVideojuego.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvRegistroVideojuego.Location = new System.Drawing.Point(66, 257);
            this.dgvRegistroVideojuego.Name = "dgvRegistroVideojuego";
            this.dgvRegistroVideojuego.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRegistroVideojuego.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvRegistroVideojuego.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvRegistroVideojuego.Size = new System.Drawing.Size(427, 176);
            this.dgvRegistroVideojuego.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "VideoJuego";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 109;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Fecha";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 70;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Gané o Perdí";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 116;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Puntos";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 74;
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonRegistrar.Location = new System.Drawing.Point(225, 193);
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
            this.rbtnPerdió.Location = new System.Drawing.Point(418, 77);
            this.rbtnPerdió.Name = "rbtnPerdió";
            this.rbtnPerdió.Size = new System.Drawing.Size(75, 17);
            this.rbtnPerdió.TabIndex = 6;
            this.rbtnPerdió.TabStop = true;
            this.rbtnPerdió.Text = "Perdí (-20)";
            this.rbtnPerdió.UseVisualStyleBackColor = true;
            this.rbtnPerdió.CheckedChanged += new System.EventHandler(this.rbtnPerdió_CheckedChanged);
            // 
            // buttonSalir
            // 
            this.buttonSalir.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonSalir.Location = new System.Drawing.Point(373, 193);
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
            this.RButtGane.Location = new System.Drawing.Point(418, 49);
            this.RButtGane.Name = "RButtGane";
            this.RButtGane.Size = new System.Drawing.Size(84, 17);
            this.RButtGane.TabIndex = 2;
            this.RButtGane.TabStop = true;
            this.RButtGane.Text = "Gané (+100)";
            this.RButtGane.UseVisualStyleBackColor = true;
            this.RButtGane.CheckedChanged += new System.EventHandler(this.RButtGane_CheckedChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(174, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(187, 20);
            this.textBox2.TabIndex = 8;
            // 
            // NombreVideojuego
            // 
            this.NombreVideojuego.AutoSize = true;
            this.NombreVideojuego.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NombreVideojuego.Location = new System.Drawing.Point(26, 53);
            this.NombreVideojuego.Name = "NombreVideojuego";
            this.NombreVideojuego.Size = new System.Drawing.Size(126, 13);
            this.NombreVideojuego.TabIndex = 5;
            this.NombreVideojuego.Text = "Nombre del Videojuego : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(35, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fecha :";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Location = new System.Drawing.Point(174, 132);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 20);
            this.textBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
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
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label NombreVideojuego;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label lblPuntosTotales;
    }
}

