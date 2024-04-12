namespace AnalizadorLexico.forms
{
    partial class ConverAFNAFD
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
            this.cmbAFN = new System.Windows.Forms.ComboBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "AFN a convertir";
            // 
            // cmbAFN
            // 
            this.cmbAFN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAFN.FormattingEnabled = true;
            this.cmbAFN.Location = new System.Drawing.Point(12, 44);
            this.cmbAFN.Name = "cmbAFN";
            this.cmbAFN.Size = new System.Drawing.Size(121, 21);
            this.cmbAFN.TabIndex = 1;
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(15, 136);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(118, 23);
            this.btnConvertir.TabIndex = 2;
            this.btnConvertir.Text = "Convertir en AFD";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AnalizadorLexico.Properties.Resources.ConvertirAFNaAFD;
            this.pictureBox1.Location = new System.Drawing.Point(169, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 189);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // ConverAFNAFD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 227);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.cmbAFN);
            this.Controls.Add(this.label1);
            this.Name = "ConverAFNAFD";
            this.Text = "ConverAFNAFD";
            this.Load += new System.EventHandler(this.ConverAFNAFD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAFN;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}