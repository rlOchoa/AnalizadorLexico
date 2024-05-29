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
    public partial class EvaluadorExpr : Form
    {
        ExprEval evaluador;
        public EvaluadorExpr()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e) //Boton Leer desde archivo
        {
            int IDAutom;
            IDAutom = int.Parse(textIdAFD.Text);
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "(*.txt)|*.txt";
            openFileDialog1.Title = "Abrir archivo AFD";
            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName != "")
            {
            //    evaluador = new ExprEval(openFileDialog1.FileName, -1);
            }
            else
            {
                MessageBox.Show("No se selecciono ningun archivo", "ERROR");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            evaluador.SetExpression(textExprAEval.Text);
            if (evaluador.IniEval())
            {
                MessageBox.Show("Expresion sintacticamente correcta", "AVISO", MessageBoxButtons.OK);
                textResultado.Text = evaluador.Resultado.ToString();
                textPostfija.Text = evaluador.ExprPost;
            }
            else
            {
                MessageBox.Show("Expresion sintacticamente incorrecta", "ERROR", MessageBoxButtons.OK);
                textResultado.Text = "ERROR";
            }
        }

    }
}
