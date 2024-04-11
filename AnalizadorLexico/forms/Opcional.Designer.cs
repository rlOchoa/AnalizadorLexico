namespace AnalizadorLexico.forms
{
    partial class Opcional
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
            this.cmbAFN = new System.Windows.Forms.ComboBox();
            this.btnCerraduraOpcional = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbAFN
            // 
            this.cmbAFN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAFN.FormattingEnabled = true;
            this.cmbAFN.Location = new System.Drawing.Point(41, 72);
            this.cmbAFN.Name = "cmbAFN";
            this.cmbAFN.Size = new System.Drawing.Size(121, 21);
            this.cmbAFN.TabIndex = 12;
            // 
            // btnCerraduraOpcional
            // 
            this.btnCerraduraOpcional.Location = new System.Drawing.Point(20, 139);
            this.btnCerraduraOpcional.Name = "btnCerraduraOpcional";
            this.btnCerraduraOpcional.Size = new System.Drawing.Size(131, 23);
            this.btnCerraduraOpcional.TabIndex = 11;
            this.btnCerraduraOpcional.Text = "Cerradura Opcional";
            this.btnCerraduraOpcional.UseVisualStyleBackColor = true;
            this.btnCerraduraOpcional.Click += new System.EventHandler(this.btnCerraduraOpcional_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "AFN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AnalizadorLexico.Properties.Resources.Opcional;
            this.pictureBox1.Location = new System.Drawing.Point(168, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Opcional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 228);
            this.Controls.Add(this.cmbAFN);
            this.Controls.Add(this.btnCerraduraOpcional);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Opcional";
            this.Text = "Opcional";
            this.Load += new System.EventHandler(this.Opcional_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAFN;
        private System.Windows.Forms.Button btnCerraduraOpcional;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}