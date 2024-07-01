namespace AnalizadorLexico.forms
{
    partial class MatrixForm
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
            this.matrizRevisar = new System.Windows.Forms.TextBox();
            this.Postfijo = new System.Windows.Forms.TextBox();
            this.Calcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // matrizRevisar
            // 
            this.matrizRevisar.Location = new System.Drawing.Point(12, 31);
            this.matrizRevisar.Name = "matrizRevisar";
            this.matrizRevisar.Size = new System.Drawing.Size(776, 20);
            this.matrizRevisar.TabIndex = 0;
            // 
            // Postfijo
            // 
            this.Postfijo.Enabled = false;
            this.Postfijo.Location = new System.Drawing.Point(12, 115);
            this.Postfijo.Name = "Postfijo";
            this.Postfijo.Size = new System.Drawing.Size(776, 20);
            this.Postfijo.TabIndex = 2;
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(12, 57);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(75, 23);
            this.Calcular.TabIndex = 3;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingrese Matriz a revisar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Resultado Postfijo";
            // 
            // MatrixForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 151);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.Postfijo);
            this.Controls.Add(this.matrizRevisar);
            this.Name = "MatrixForm";
            this.Text = "Resolver Matriz";
            this.Load += new System.EventHandler(this.MatrixForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox matrizRevisar;
        private System.Windows.Forms.TextBox Postfijo;
        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}