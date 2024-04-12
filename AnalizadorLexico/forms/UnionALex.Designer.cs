namespace AnalizadorLexico.forms
{
    partial class UnionALex
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
            this.clbAFN = new System.Windows.Forms.CheckedListBox();
            this.btnUnionEspecial = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AnalizadorLexico.Properties.Resources.UnionEspecial;
            this.pictureBox1.Location = new System.Drawing.Point(197, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // clbAFN
            // 
            this.clbAFN.CheckOnClick = true;
            this.clbAFN.FormattingEnabled = true;
            this.clbAFN.Location = new System.Drawing.Point(12, 12);
            this.clbAFN.Name = "clbAFN";
            this.clbAFN.Size = new System.Drawing.Size(167, 289);
            this.clbAFN.TabIndex = 16;
            // 
            // btnUnionEspecial
            // 
            this.btnUnionEspecial.Location = new System.Drawing.Point(239, 245);
            this.btnUnionEspecial.Name = "btnUnionEspecial";
            this.btnUnionEspecial.Size = new System.Drawing.Size(120, 23);
            this.btnUnionEspecial.TabIndex = 17;
            this.btnUnionEspecial.Text = "Union Especial";
            this.btnUnionEspecial.UseVisualStyleBackColor = true;
            this.btnUnionEspecial.Click += new System.EventHandler(this.btnUnionEspecial_Click);
            // 
            // UnionALex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 311);
            this.Controls.Add(this.btnUnionEspecial);
            this.Controls.Add(this.clbAFN);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UnionALex";
            this.Text = "UnionALex";
            this.Load += new System.EventHandler(this.UnionALex_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckedListBox clbAFN;
        private System.Windows.Forms.Button btnUnionEspecial;
    }
}