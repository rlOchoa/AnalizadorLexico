namespace AnalizadorLexico.forms
{
    partial class Calculadora
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnAnaliz = new System.Windows.Forms.Button();
            this.txtExpresion = new System.Windows.Forms.TextBox();
            this.txtValCalc = new System.Windows.Forms.TextBox();
            this.txtPost = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSelecArch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Expresion a evaluar";
            // 
            // btnAnaliz
            // 
            this.btnAnaliz.Location = new System.Drawing.Point(47, 185);
            this.btnAnaliz.Name = "btnAnaliz";
            this.btnAnaliz.Size = new System.Drawing.Size(75, 23);
            this.btnAnaliz.TabIndex = 4;
            this.btnAnaliz.Text = "Analizar";
            this.btnAnaliz.UseVisualStyleBackColor = true;
            this.btnAnaliz.Click += new System.EventHandler(this.btnAnaliz_Click);
            // 
            // txtExpresion
            // 
            this.txtExpresion.Location = new System.Drawing.Point(150, 156);
            this.txtExpresion.Name = "txtExpresion";
            this.txtExpresion.Size = new System.Drawing.Size(214, 20);
            this.txtExpresion.TabIndex = 5;
            // 
            // txtValCalc
            // 
            this.txtValCalc.Enabled = false;
            this.txtValCalc.Location = new System.Drawing.Point(150, 188);
            this.txtValCalc.Name = "txtValCalc";
            this.txtValCalc.Size = new System.Drawing.Size(214, 20);
            this.txtValCalc.TabIndex = 5;
            // 
            // txtPost
            // 
            this.txtPost.Enabled = false;
            this.txtPost.Location = new System.Drawing.Point(150, 223);
            this.txtPost.Name = "txtPost";
            this.txtPost.Size = new System.Drawing.Size(214, 20);
            this.txtPost.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSelecArch);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(31, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 125);
            this.panel1.TabIndex = 6;
            // 
            // btnSelecArch
            // 
            this.btnSelecArch.Location = new System.Drawing.Point(106, 71);
            this.btnSelecArch.Name = "btnSelecArch";
            this.btnSelecArch.Size = new System.Drawing.Size(100, 34);
            this.btnSelecArch.TabIndex = 5;
            this.btnSelecArch.Text = "Seleccionar desde archivo";
            this.btnSelecArch.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID del AFD";
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 259);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtPost);
            this.Controls.Add(this.txtValCalc);
            this.Controls.Add(this.txtExpresion);
            this.Controls.Add(this.btnAnaliz);
            this.Controls.Add(this.label2);
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAnaliz;
        private System.Windows.Forms.TextBox txtExpresion;
        private System.Windows.Forms.TextBox txtValCalc;
        private System.Windows.Forms.TextBox txtPost;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSelecArch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}