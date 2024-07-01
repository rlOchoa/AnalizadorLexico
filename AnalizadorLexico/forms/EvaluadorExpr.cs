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
        
        public HashSet<AFN> afns = new HashSet<AFN>();
        public HashSet<AFN> afnsaux = new HashSet<AFN>();
        public HashSet<AFD> afds = new HashSet<AFD>();
        public EvaluadorExpr()
        {
            InitializeComponent();
        }
        public EvaluadorExpr(HashSet<AFN> afns1, HashSet<AFD> afds1)
        {
            InitializeComponent();
            this.afns = afns1;
            this.afds = afds1;
        }        

        private void button2_Click(object sender, EventArgs e)
        {
            string expresion = textExprAEval.Text;
            afnsaux.Clear();
            AFN auxiliar = new AFN();
            AFN auxiliar1 = new AFN();
            AFN auxiliar2 = new AFN();
            auxiliar.crearAFNBasico('+');//10
            afnsaux.Add(auxiliar);
            auxiliar = new AFN();
            auxiliar.crearAFNBasico('-');//20
            afnsaux.Add(auxiliar);
            auxiliar = new AFN();
            auxiliar.crearAFNBasico('*');//30
            afnsaux.Add(auxiliar);
            auxiliar = new AFN();
            auxiliar.crearAFNBasico('/');//40
            afnsaux.Add(auxiliar);
            auxiliar = new AFN();
            auxiliar.crearAFNBasico('^');//50
            afnsaux.Add(auxiliar);

            auxiliar = new AFN();
            auxiliar1 = new AFN();
            auxiliar.crearAFNBasico('S');
            auxiliar1.crearAFNBasico('I');
            auxiliar.concatAFNs(auxiliar1);
            auxiliar1 = new AFN();
            auxiliar1.crearAFNBasico('N');
            auxiliar.concatAFNs(auxiliar1);
            afnsaux.Add(auxiliar);//60

            auxiliar = new AFN();
            auxiliar1 = new AFN();
            auxiliar.crearAFNBasico('C');
            auxiliar1.crearAFNBasico('O');
            auxiliar.concatAFNs(auxiliar1);
            auxiliar1 = new AFN();
            auxiliar1.crearAFNBasico('S');
            auxiliar.concatAFNs(auxiliar1);
            afnsaux.Add(auxiliar);//70

            auxiliar = new AFN();
            auxiliar1 = new AFN();
            auxiliar.crearAFNBasico('T');
            auxiliar1.crearAFNBasico('A');
            auxiliar.concatAFNs(auxiliar1);
            auxiliar1 = new AFN();
            auxiliar1.crearAFNBasico('N');
            auxiliar.concatAFNs(auxiliar1);
            afnsaux.Add(auxiliar);//80

            auxiliar = new AFN();
            auxiliar1 = new AFN();
            auxiliar.crearAFNBasico('L');
            auxiliar1.crearAFNBasico('O');
            auxiliar.concatAFNs(auxiliar1);
            auxiliar1 = new AFN();
            auxiliar1.crearAFNBasico('G');
            auxiliar.concatAFNs(auxiliar1);
            afnsaux.Add(auxiliar);//90

            auxiliar = new AFN();
            auxiliar1 = new AFN();
            auxiliar.crearAFNBasico('L');
            auxiliar1.crearAFNBasico('N');
            auxiliar.concatAFNs(auxiliar1);
            afnsaux.Add(auxiliar);//100

            auxiliar = new AFN();
            auxiliar1 = new AFN();
            auxiliar2 = new AFN();
            auxiliar.crearAFNBasico('0', '9');
            auxiliar.cerraduraKleene();
            auxiliar1.crearAFNBasico('.');
            auxiliar2.crearAFNBasico('0', '9');
            auxiliar2.cerraduraKleene();
            auxiliar1.concatAFNs(auxiliar2);
            auxiliar1.operacionOpcional();
            auxiliar.concatAFNs(auxiliar1);
            afnsaux.Add(auxiliar);//NUM 110

            auxiliar = new AFN();
            auxiliar.crearAFNBasico('(');//120
            afnsaux.Add(auxiliar);
            auxiliar = new AFN();
            auxiliar.crearAFNBasico(')');//130
            afnsaux.Add(auxiliar);
            auxiliar = new AFN();
            auxiliar = auxiliar.unionEspecialAFNs(afnsaux);
            ExprEval evaluador = new ExprEval(textExprAEval.Text, auxiliar.convAFNaAFD());
            if (evaluador.IniEval())
            {
                textResultado.Text = evaluador.Resultado.ToString();
                textPostfija.Text = evaluador.ExprPost;
                MessageBox.Show("Expresion sintacticamente correcta", "AVISO", MessageBoxButtons.OK);
            }
            else
            {
                textResultado.Text = "ERROR MATH";
                textPostfija.Text = "ERROR SINTACTIC";
                MessageBox.Show("Expresion sintacticamente incorrecta", "ERROR", MessageBoxButtons.OK);
            }
        }

        private void EvaluadorExpr_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(cerrarForm);
        }

        private void cerrarForm(object sender, EventArgs e)
        {
            Compilador compi = new Compilador(afns, afds);
            compi.Show();
            this.Hide();
        }
    }
}
