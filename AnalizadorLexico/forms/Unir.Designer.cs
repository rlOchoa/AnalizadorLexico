namespace AnalizadorLexico.forms
{
    partial class Unir
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxAFN1 = new System.Windows.Forms.ComboBox();
            this.cbxAFN2 = new System.Windows.Forms.ComboBox();
            this.btnUnir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AnalizadorLexico.Properties.Resources.Union;
            this.pictureBox1.Location = new System.Drawing.Point(195, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "AFN 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "AFN 2";
            // 
            // cbxAFN1
            // 
            this.cbxAFN1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAFN1.FormattingEnabled = true;
            this.cbxAFN1.Location = new System.Drawing.Point(52, 32);
            this.cbxAFN1.Name = "cbxAFN1";
            this.cbxAFN1.Size = new System.Drawing.Size(121, 21);
            this.cbxAFN1.TabIndex = 3;
            // 
            // cbxAFN2
            // 
            this.cbxAFN2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAFN2.FormattingEnabled = true;
            this.cbxAFN2.Location = new System.Drawing.Point(52, 96);
            this.cbxAFN2.Name = "cbxAFN2";
            this.cbxAFN2.Size = new System.Drawing.Size(121, 21);
            this.cbxAFN2.TabIndex = 4;
            // 
            // btnUnir
            // 
            this.btnUnir.Location = new System.Drawing.Point(70, 156);
            this.btnUnir.Name = "btnUnir";
            this.btnUnir.Size = new System.Drawing.Size(75, 23);
            this.btnUnir.TabIndex = 5;
            this.btnUnir.Text = "Unir AFNs";
            this.btnUnir.UseVisualStyleBackColor = true;
            this.btnUnir.Click += new System.EventHandler(this.btnUnir_Click);
            // 
            // Unir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 242);
            this.Controls.Add(this.btnUnir);
            this.Controls.Add(this.cbxAFN2);
            this.Controls.Add(this.cbxAFN1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Unir";
            this.Text = "Unir";
            this.Load += new System.EventHandler(this.Unir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxAFN1;
        private System.Windows.Forms.ComboBox cbxAFN2;
        private System.Windows.Forms.Button btnUnir;
    }
}