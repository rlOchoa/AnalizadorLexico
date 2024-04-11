namespace AnalizadorLexico.forms
{
    partial class Basico
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
            this.chbASCII = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCaracterInferior = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCaracterSuperior = new System.Windows.Forms.TextBox();
            this.btnCrearAFN = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtIdAFN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chbASCII
            // 
            this.chbASCII.AutoSize = true;
            this.chbASCII.Location = new System.Drawing.Point(15, 39);
            this.chbASCII.Name = "chbASCII";
            this.chbASCII.Size = new System.Drawing.Size(113, 17);
            this.chbASCII.TabIndex = 1;
            this.chbASCII.Text = "Usar código ASCII";
            this.chbASCII.UseVisualStyleBackColor = true;
            this.chbASCII.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Caracter INF";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtCaracterInferior
            // 
            this.txtCaracterInferior.Location = new System.Drawing.Point(97, 72);
            this.txtCaracterInferior.Name = "txtCaracterInferior";
            this.txtCaracterInferior.Size = new System.Drawing.Size(28, 20);
            this.txtCaracterInferior.TabIndex = 3;
            this.txtCaracterInferior.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Caracter SUP";
            // 
            // txtCaracterSuperior
            // 
            this.txtCaracterSuperior.Location = new System.Drawing.Point(97, 101);
            this.txtCaracterSuperior.Name = "txtCaracterSuperior";
            this.txtCaracterSuperior.Size = new System.Drawing.Size(28, 20);
            this.txtCaracterSuperior.TabIndex = 5;
            // 
            // btnCrearAFN
            // 
            this.btnCrearAFN.Location = new System.Drawing.Point(15, 184);
            this.btnCrearAFN.Name = "btnCrearAFN";
            this.btnCrearAFN.Size = new System.Drawing.Size(110, 33);
            this.btnCrearAFN.TabIndex = 8;
            this.btnCrearAFN.Text = "Crear AFN";
            this.btnCrearAFN.UseVisualStyleBackColor = true;
            this.btnCrearAFN.Click += new System.EventHandler(this.btnCrearAFN_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AnalizadorLexico.Properties.Resources.Basico;
            this.pictureBox1.Location = new System.Drawing.Point(150, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // txtIdAFN
            // 
            this.txtIdAFN.Location = new System.Drawing.Point(97, 131);
            this.txtIdAFN.Name = "txtIdAFN";
            this.txtIdAFN.Size = new System.Drawing.Size(28, 20);
            this.txtIdAFN.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Id de Automata";
            // 
            // Basico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 244);
            this.Controls.Add(this.txtIdAFN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCrearAFN);
            this.Controls.Add(this.txtCaracterSuperior);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCaracterInferior);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chbASCII);
            this.Name = "Basico";
            this.Text = "Basico";
            this.Load += new System.EventHandler(this.Basico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbASCII;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCaracterInferior;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCaracterSuperior;
        private System.Windows.Forms.Button btnCrearAFN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtIdAFN;
        private System.Windows.Forms.Label label3;
    }
}