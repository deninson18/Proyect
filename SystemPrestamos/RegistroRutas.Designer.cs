﻿namespace SystemPrestamos
{
    partial class RegistroRutas
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
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Registrolabel = new System.Windows.Forms.Label();
            this.RutaIdlabel = new System.Windows.Forms.Label();
            this.RutaIdtextBox = new System.Windows.Forms.TextBox();
            this.NombreRutalabel = new System.Windows.Forms.Label();
            this.RutaNombretextBox = new System.Windows.Forms.TextBox();
            this.RutaDetallelabel = new System.Windows.Forms.Label();
            this.RutaDetalletextBox = new System.Windows.Forms.TextBox();
            this.CobradorIdlabel = new System.Windows.Forms.Label();
            this.CobradorIdcomboBox = new System.Windows.Forms.ComboBox();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.CobradorlistBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Location = new System.Drawing.Point(85, 380);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 23);
            this.Nuevobutton.TabIndex = 15;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(191, 380);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 23);
            this.Guardarbutton.TabIndex = 17;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Location = new System.Drawing.Point(291, 380);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 23);
            this.Eliminarbutton.TabIndex = 2;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Registrolabel
            // 
            this.Registrolabel.AutoSize = true;
            this.Registrolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registrolabel.Location = new System.Drawing.Point(99, 9);
            this.Registrolabel.Name = "Registrolabel";
            this.Registrolabel.Size = new System.Drawing.Size(232, 31);
            this.Registrolabel.TabIndex = 24;
            this.Registrolabel.Text = "Registro de Rutas";
            // 
            // RutaIdlabel
            // 
            this.RutaIdlabel.AutoSize = true;
            this.RutaIdlabel.Location = new System.Drawing.Point(31, 65);
            this.RutaIdlabel.Name = "RutaIdlabel";
            this.RutaIdlabel.Size = new System.Drawing.Size(39, 13);
            this.RutaIdlabel.TabIndex = 25;
            this.RutaIdlabel.Text = "RutaId";
            // 
            // RutaIdtextBox
            // 
            this.RutaIdtextBox.Location = new System.Drawing.Point(34, 81);
            this.RutaIdtextBox.Name = "RutaIdtextBox";
            this.RutaIdtextBox.Size = new System.Drawing.Size(234, 20);
            this.RutaIdtextBox.TabIndex = 0;
            this.RutaIdtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RutaIdtextBox_KeyPress);
            // 
            // NombreRutalabel
            // 
            this.NombreRutalabel.AutoSize = true;
            this.NombreRutalabel.Location = new System.Drawing.Point(31, 122);
            this.NombreRutalabel.Name = "NombreRutalabel";
            this.NombreRutalabel.Size = new System.Drawing.Size(85, 13);
            this.NombreRutalabel.TabIndex = 27;
            this.NombreRutalabel.Text = "Nombre de Ruta";
            // 
            // RutaNombretextBox
            // 
            this.RutaNombretextBox.Location = new System.Drawing.Point(34, 138);
            this.RutaNombretextBox.Name = "RutaNombretextBox";
            this.RutaNombretextBox.Size = new System.Drawing.Size(234, 20);
            this.RutaNombretextBox.TabIndex = 8;
            // 
            // RutaDetallelabel
            // 
            this.RutaDetallelabel.AutoSize = true;
            this.RutaDetallelabel.Location = new System.Drawing.Point(31, 180);
            this.RutaDetallelabel.Name = "RutaDetallelabel";
            this.RutaDetallelabel.Size = new System.Drawing.Size(81, 13);
            this.RutaDetallelabel.TabIndex = 29;
            this.RutaDetallelabel.Text = "Detalle de Ruta";
            // 
            // RutaDetalletextBox
            // 
            this.RutaDetalletextBox.Location = new System.Drawing.Point(34, 196);
            this.RutaDetalletextBox.Name = "RutaDetalletextBox";
            this.RutaDetalletextBox.Size = new System.Drawing.Size(234, 20);
            this.RutaDetalletextBox.TabIndex = 10;
            // 
            // CobradorIdlabel
            // 
            this.CobradorIdlabel.AutoSize = true;
            this.CobradorIdlabel.Location = new System.Drawing.Point(31, 233);
            this.CobradorIdlabel.Name = "CobradorIdlabel";
            this.CobradorIdlabel.Size = new System.Drawing.Size(79, 13);
            this.CobradorIdlabel.TabIndex = 31;
            this.CobradorIdlabel.Text = "ID de Cobrador";
            // 
            // CobradorIdcomboBox
            // 
            this.CobradorIdcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CobradorIdcomboBox.FormattingEnabled = true;
            this.CobradorIdcomboBox.Location = new System.Drawing.Point(34, 249);
            this.CobradorIdcomboBox.Name = "CobradorIdcomboBox";
            this.CobradorIdcomboBox.Size = new System.Drawing.Size(234, 21);
            this.CobradorIdcomboBox.TabIndex = 12;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(293, 79);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 22);
            this.Buscarbutton.TabIndex = 5;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Location = new System.Drawing.Point(291, 248);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(75, 21);
            this.Agregarbutton.TabIndex = 33;
            this.Agregarbutton.Text = "Agregar";
            this.Agregarbutton.UseVisualStyleBackColor = true;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
            // 
            // CobradorlistBox
            // 
            this.CobradorlistBox.FormattingEnabled = true;
            this.CobradorlistBox.Location = new System.Drawing.Point(34, 276);
            this.CobradorlistBox.Name = "CobradorlistBox";
            this.CobradorlistBox.Size = new System.Drawing.Size(232, 69);
            this.CobradorlistBox.TabIndex = 34;
            // 
            // RegistroRutas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 415);
            this.Controls.Add(this.CobradorlistBox);
            this.Controls.Add(this.Agregarbutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.CobradorIdcomboBox);
            this.Controls.Add(this.CobradorIdlabel);
            this.Controls.Add(this.RutaDetalletextBox);
            this.Controls.Add(this.RutaDetallelabel);
            this.Controls.Add(this.RutaNombretextBox);
            this.Controls.Add(this.NombreRutalabel);
            this.Controls.Add(this.RutaIdtextBox);
            this.Controls.Add(this.RutaIdlabel);
            this.Controls.Add(this.Registrolabel);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Name = "RegistroRutas";
            this.Text = "RegistroRutas";
            this.Load += new System.EventHandler(this.RegistroRutas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Label Registrolabel;
        private System.Windows.Forms.Label RutaIdlabel;
        private System.Windows.Forms.TextBox RutaIdtextBox;
        private System.Windows.Forms.Label NombreRutalabel;
        private System.Windows.Forms.TextBox RutaNombretextBox;
        private System.Windows.Forms.Label RutaDetallelabel;
        private System.Windows.Forms.TextBox RutaDetalletextBox;
        private System.Windows.Forms.Label CobradorIdlabel;
        private System.Windows.Forms.ComboBox CobradorIdcomboBox;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.ListBox CobradorlistBox;
    }
}