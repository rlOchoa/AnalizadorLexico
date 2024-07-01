namespace AnalizadorLexico.forms
{
    partial class ERAFN
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
            this.Convertir = new System.Windows.Forms.Button();
            this.ERegular = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Convertir
            // 
            this.Convertir.Location = new System.Drawing.Point(78, 82);
            this.Convertir.Name = "Convertir";
            this.Convertir.Size = new System.Drawing.Size(122, 23);
            this.Convertir.TabIndex = 0;
            this.Convertir.Text = "Convertir ER a AFD";
            this.Convertir.UseVisualStyleBackColor = true;
            this.Convertir.Click += new System.EventHandler(this.Convertir_Click);
            // 
            // ERegular
            // 
            this.ERegular.Location = new System.Drawing.Point(12, 40);
            this.ERegular.Name = "ERegular";
            this.ERegular.Size = new System.Drawing.Size(257, 20);
            this.ERegular.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Escriba la Expresio regular";
            // 
            // ERAFN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 117);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ERegular);
            this.Controls.Add(this.Convertir);
            this.DoubleBuffered = true;
            this.Name = "ERAFN";
            this.Text = "EFAFN";
            this.Load += new System.EventHandler(this.ERAFN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Convertir;
        private System.Windows.Forms.TextBox ERegular;
        private System.Windows.Forms.Label label1;
    }
}