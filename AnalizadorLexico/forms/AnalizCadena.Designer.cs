﻿namespace AnalizadorLexico.forms
{
    partial class AnalizCadena
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
            this.cmbAFD = new System.Windows.Forms.ComboBox();
            this.dataGridAFD = new System.Windows.Forms.DataGridView();
            this.btnCArgarAFD = new System.Windows.Forms.Button();
            this.txtCadena = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRuta = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGuardarAFD = new System.Windows.Forms.Button();
            this.btnAnalizar = new System.Windows.Forms.Button();
            this.txtidAFD = new System.Windows.Forms.TextBox();
            this.btnCargarArchivoAFD = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAFD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elegir AFD";
            // 
            // cmbAFD
            // 
            this.cmbAFD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAFD.FormattingEnabled = true;
            this.cmbAFD.Location = new System.Drawing.Point(75, 12);
            this.cmbAFD.Name = "cmbAFD";
            this.cmbAFD.Size = new System.Drawing.Size(121, 21);
            this.cmbAFD.TabIndex = 1;
            // 
            // dataGridAFD
            // 
            this.dataGridAFD.AllowUserToAddRows = false;
            this.dataGridAFD.AllowUserToDeleteRows = false;
            this.dataGridAFD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAFD.Location = new System.Drawing.Point(15, 51);
            this.dataGridAFD.Name = "dataGridAFD";
            this.dataGridAFD.ReadOnly = true;
            this.dataGridAFD.Size = new System.Drawing.Size(789, 258);
            this.dataGridAFD.TabIndex = 2;
            // 
            // btnCArgarAFD
            // 
            this.btnCArgarAFD.Location = new System.Drawing.Point(202, 10);
            this.btnCArgarAFD.Name = "btnCArgarAFD";
            this.btnCArgarAFD.Size = new System.Drawing.Size(75, 23);
            this.btnCArgarAFD.TabIndex = 3;
            this.btnCArgarAFD.Text = "Cargar AFD";
            this.btnCArgarAFD.UseVisualStyleBackColor = true;
            this.btnCArgarAFD.Click += new System.EventHandler(this.btnCArgarAFD_Click);
            // 
            // txtCadena
            // 
            this.txtCadena.Location = new System.Drawing.Point(114, 326);
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.Size = new System.Drawing.Size(100, 20);
            this.txtCadena.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cadena a Analizar";
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Location = new System.Drawing.Point(301, 329);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(84, 13);
            this.lblRuta.TabIndex = 6;
            this.lblRuta.Text = "Ruta de Archivo";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(220, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Subir Archivo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGuardarAFD
            // 
            this.btnGuardarAFD.Location = new System.Drawing.Point(283, 10);
            this.btnGuardarAFD.Name = "btnGuardarAFD";
            this.btnGuardarAFD.Size = new System.Drawing.Size(88, 23);
            this.btnGuardarAFD.TabIndex = 9;
            this.btnGuardarAFD.Text = "Guardar AFD";
            this.btnGuardarAFD.UseVisualStyleBackColor = true;
            this.btnGuardarAFD.Click += new System.EventHandler(this.btnGuardarAFD_Click);
            // 
            // btnAnalizar
            // 
            this.btnAnalizar.Location = new System.Drawing.Point(18, 361);
            this.btnAnalizar.Name = "btnAnalizar";
            this.btnAnalizar.Size = new System.Drawing.Size(196, 23);
            this.btnAnalizar.TabIndex = 10;
            this.btnAnalizar.Text = "Analizar Cadena";
            this.btnAnalizar.UseVisualStyleBackColor = true;
            this.btnAnalizar.Click += new System.EventHandler(this.btnAnalizar_Click);
            // 
            // txtidAFD
            // 
            this.txtidAFD.Location = new System.Drawing.Point(545, 12);
            this.txtidAFD.Name = "txtidAFD";
            this.txtidAFD.Size = new System.Drawing.Size(100, 20);
            this.txtidAFD.TabIndex = 11;
            // 
            // btnCargarArchivoAFD
            // 
            this.btnCargarArchivoAFD.Location = new System.Drawing.Point(651, 9);
            this.btnCargarArchivoAFD.Name = "btnCargarArchivoAFD";
            this.btnCargarArchivoAFD.Size = new System.Drawing.Size(153, 23);
            this.btnCargarArchivoAFD.TabIndex = 12;
            this.btnCargarArchivoAFD.Text = "Cargar AFD desde Archivo";
            this.btnCargarArchivoAFD.UseVisualStyleBackColor = true;
            this.btnCargarArchivoAFD.Click += new System.EventHandler(this.btnCargarArchivoAFD_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ingrese id de AFD desde archivo";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialogAFD";
            // 
            // AnalizCadena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCargarArchivoAFD);
            this.Controls.Add(this.txtidAFD);
            this.Controls.Add(this.btnAnalizar);
            this.Controls.Add(this.btnGuardarAFD);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblRuta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCadena);
            this.Controls.Add(this.btnCArgarAFD);
            this.Controls.Add(this.dataGridAFD);
            this.Controls.Add(this.cmbAFD);
            this.Controls.Add(this.label1);
            this.Name = "AnalizCadena";
            this.Text = "AnalizCadena";
            this.Load += new System.EventHandler(this.AnalizCadena_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAFD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAFD;
        private System.Windows.Forms.DataGridView dataGridAFD;
        private System.Windows.Forms.Button btnCArgarAFD;
        private System.Windows.Forms.TextBox txtCadena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGuardarAFD;
        private System.Windows.Forms.Button btnAnalizar;
        private System.Windows.Forms.TextBox txtidAFD;
        private System.Windows.Forms.Button btnCargarArchivoAFD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}