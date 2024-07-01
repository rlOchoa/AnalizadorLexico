namespace AnalizadorLexico.forms
{
    partial class EvaluadorExpr
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
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textIdAFD = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textExprAEval = new System.Windows.Forms.TextBox();
            this.textResultado = new System.Windows.Forms.TextBox();
            this.textPostfija = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Analizador Lexico";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id del AFD";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Seleccionar AFD desde Archivo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textIdAFD
            // 
            this.textIdAFD.Location = new System.Drawing.Point(77, 48);
            this.textIdAFD.Name = "textIdAFD";
            this.textIdAFD.Size = new System.Drawing.Size(100, 20);
            this.textIdAFD.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textIdAFD);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(53, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 134);
            this.panel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Expresion a evaluar:";
            // 
            // textExprAEval
            // 
            this.textExprAEval.Location = new System.Drawing.Point(163, 194);
            this.textExprAEval.Name = "textExprAEval";
            this.textExprAEval.Size = new System.Drawing.Size(251, 20);
            this.textExprAEval.TabIndex = 6;
            // 
            // textResultado
            // 
            this.textResultado.Enabled = false;
            this.textResultado.Location = new System.Drawing.Point(163, 239);
            this.textResultado.Name = "textResultado";
            this.textResultado.Size = new System.Drawing.Size(100, 20);
            this.textResultado.TabIndex = 7;
            // 
            // textPostfija
            // 
            this.textPostfija.Enabled = false;
            this.textPostfija.Location = new System.Drawing.Point(163, 276);
            this.textPostfija.Name = "textPostfija";
            this.textPostfija.Size = new System.Drawing.Size(100, 20);
            this.textPostfija.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(66, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 27);
            this.button2.TabIndex = 9;
            this.button2.Text = "Evaluar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EvaluadorExpr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textPostfija);
            this.Controls.Add(this.textResultado);
            this.Controls.Add(this.textExprAEval);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "EvaluadorExpr";
            this.Text = "EvaluadorExpr";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textIdAFD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textExprAEval;
        private System.Windows.Forms.TextBox textResultado;
        private System.Windows.Forms.TextBox textPostfija;
        private System.Windows.Forms.Button button2;
    }
}