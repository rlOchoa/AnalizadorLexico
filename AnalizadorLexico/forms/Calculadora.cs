using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalizadorLexico.forms
{
    public partial class Calculadora : Form
    {
        
        AnalizadorLexico.Calculadora evaluador = null;

        public Calculadora()
        {
            InitializeComponent();
        }

        private void btnAnaliz_Click(object sender, EventArgs e)
        {
            if (this.evaluador == null)
            {
                MessageBox.Show("No se ha cargado un AFD, Carge su archivo e intentelo de nuevo");
            }
            else
            {
                this.evaluador.SetExpression(this.txtExpresion.Text);
                if (evaluador.Asign())
                {
                    MessageBox.Show("Su expresion es sintacticamente correcta");
                    this.txtValCalc.Text = this.evaluador.res.ToString();
                    this.txtPost.Text = this.evaluador.ExprPost;
                }
                else
                {
                    MessageBox.Show("Su expresion es sintacticamente incorrecta");
                    this.txtValCalc.Text = "ERROR";
                }
            }
        }
    }
}
