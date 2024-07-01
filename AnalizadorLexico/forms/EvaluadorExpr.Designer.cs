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
            this.label3 = new System.Windows.Forms.Label();
            this.textExprAEval = new System.Windows.Forms.TextBox();
            this.textResultado = new System.Windows.Forms.TextBox();
            this.textPostfija = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Expresion a evaluar:";
            // 
            // textExprAEval
            // 
            this.textExprAEval.Location = new System.Drawing.Point(110, 12);
            this.textExprAEval.Name = "textExprAEval";
            this.textExprAEval.Size = new System.Drawing.Size(649, 20);
            this.textExprAEval.TabIndex = 6;
            // 
            // textResultado
            // 
            this.textResultado.Enabled = false;
            this.textResultado.Location = new System.Drawing.Point(110, 57);
            this.textResultado.Name = "textResultado";
            this.textResultado.Size = new System.Drawing.Size(251, 20);
            this.textResultado.TabIndex = 7;
            // 
            // textPostfija
            // 
            this.textPostfija.Enabled = false;
            this.textPostfija.Location = new System.Drawing.Point(110, 94);
            this.textPostfija.Name = "textPostfija";
            this.textPostfija.Size = new System.Drawing.Size(649, 20);
            this.textPostfija.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 53);
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
            this.ClientSize = new System.Drawing.Size(771, 135);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textPostfija);
            this.Controls.Add(this.textResultado);
            this.Controls.Add(this.textExprAEval);
            this.Controls.Add(this.label3);
            this.Name = "EvaluadorExpr";
            this.Text = "EvaluadorExpr";
            this.Load += new System.EventHandler(this.EvaluadorExpr_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textExprAEval;
        private System.Windows.Forms.TextBox textResultado;
        private System.Windows.Forms.TextBox textPostfija;
        private System.Windows.Forms.Button button2;
    }
}