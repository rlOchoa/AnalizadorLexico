namespace AnalizadorLexico.forms
{
    partial class Concatenar
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
            this.cmbAFN1 = new System.Windows.Forms.ComboBox();
            this.cmbAFN2 = new System.Windows.Forms.ComboBox();
            this.btnConcatenar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "AFN 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "AFN 2";
            // 
            // cmbAFN1
            // 
            this.cmbAFN1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAFN1.FormattingEnabled = true;
            this.cmbAFN1.Location = new System.Drawing.Point(55, 21);
            this.cmbAFN1.Name = "cmbAFN1";
            this.cmbAFN1.Size = new System.Drawing.Size(121, 21);
            this.cmbAFN1.TabIndex = 2;
            // 
            // cmbAFN2
            // 
            this.cmbAFN2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAFN2.FormattingEnabled = true;
            this.cmbAFN2.Location = new System.Drawing.Point(55, 82);
            this.cmbAFN2.Name = "cmbAFN2";
            this.cmbAFN2.Size = new System.Drawing.Size(121, 21);
            this.cmbAFN2.TabIndex = 3;
            // 
            // btnConcatenar
            // 
            this.btnConcatenar.Location = new System.Drawing.Point(55, 153);
            this.btnConcatenar.Name = "btnConcatenar";
            this.btnConcatenar.Size = new System.Drawing.Size(75, 23);
            this.btnConcatenar.TabIndex = 4;
            this.btnConcatenar.Text = "Concatenar";
            this.btnConcatenar.UseVisualStyleBackColor = true;
            this.btnConcatenar.Click += new System.EventHandler(this.btnConcatenar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AnalizadorLexico.Properties.Resources.Concatenar;
            this.pictureBox1.Location = new System.Drawing.Point(194, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Concatenar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 210);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnConcatenar);
            this.Controls.Add(this.cmbAFN2);
            this.Controls.Add(this.cmbAFN1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Concatenar";
            this.Text = "Concatenar";
            this.Load += new System.EventHandler(this.Concatenar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAFN1;
        private System.Windows.Forms.ComboBox cmbAFN2;
        private System.Windows.Forms.Button btnConcatenar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}