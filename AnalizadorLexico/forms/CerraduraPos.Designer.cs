﻿namespace AnalizadorLexico.forms
{
    partial class CerraduraPos
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCerraduraPositiva = new System.Windows.Forms.Button();
            this.cmbAFN = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "AFN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AnalizadorLexico.Properties.Resources.Cerradura_Positiva;
            this.pictureBox1.Location = new System.Drawing.Point(173, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnCerraduraPositiva
            // 
            this.btnCerraduraPositiva.Location = new System.Drawing.Point(25, 139);
            this.btnCerraduraPositiva.Name = "btnCerraduraPositiva";
            this.btnCerraduraPositiva.Size = new System.Drawing.Size(131, 23);
            this.btnCerraduraPositiva.TabIndex = 3;
            this.btnCerraduraPositiva.Text = "Cerradura Positiva";
            this.btnCerraduraPositiva.UseVisualStyleBackColor = true;
            this.btnCerraduraPositiva.Click += new System.EventHandler(this.btnCerraduraPositiva_Click);
            // 
            // cmbAFN
            // 
            this.cmbAFN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAFN.FormattingEnabled = true;
            this.cmbAFN.Location = new System.Drawing.Point(46, 72);
            this.cmbAFN.Name = "cmbAFN";
            this.cmbAFN.Size = new System.Drawing.Size(121, 21);
            this.cmbAFN.TabIndex = 4;
            // 
            // CerraduraPos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 226);
            this.Controls.Add(this.cmbAFN);
            this.Controls.Add(this.btnCerraduraPositiva);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "CerraduraPos";
            this.Text = "Cerradura Positiva";
            this.Load += new System.EventHandler(this.CerraduraPos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCerraduraPositiva;
        private System.Windows.Forms.ComboBox cmbAFN;
    }
}