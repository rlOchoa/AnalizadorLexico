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
    public partial class MatrixForm : Form
    {
        public HashSet<AFN> afns = new HashSet<AFN>();
        public HashSet<AFN> afnsaux = new HashSet<AFN>();
        public HashSet<AFD> afds = new HashSet<AFD>();
        public MatrixForm()
        {
            InitializeComponent();
        }
        public MatrixForm(HashSet<AFN> afns1, HashSet<AFD> afds1)
        {
            InitializeComponent();
            this.afns = afns1;
            this.afds = afds1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MatrixForm_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(cerrarForm);
        }
        private void cerrarForm(object sender, EventArgs e)
        {
            Compilador compi = new Compilador(afns, afds);
            compi.Show();
            this.Hide();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            AFN aux = new AFN();
            AFN aux1 = new AFN();
            AFN aux2 = new AFN();
            afnsaux.Clear();

            aux.crearAFNBasico('a', 'z');
            aux1.crearAFNBasico('A', 'Z');
            aux.unirAFNs(aux1);
            aux1 = new AFN();
            aux1.crearAFNBasico('a', 'z');
            aux2.crearAFNBasico('A', 'Z');
            aux1.unirAFNs(aux2 );
            aux2 = new AFN();
            aux2.crearAFNBasico('0', '9');
            aux1.unirAFNs(aux2 );
            aux1.cerraduraKleene();
            aux.concatAFNs(aux1);
            afnsaux.Add(aux1);//10

            aux = new AFN();
            aux.crearAFNBasico('=');
            afnsaux.Add(aux);//20

            aux = new AFN();
            aux.crearAFNBasico('+');
            afnsaux.Add(aux);//30

            aux = new AFN();
            aux.crearAFNBasico('-');
            afnsaux.Add(aux);//40

            aux = new AFN();
            aux.crearAFNBasico('*');
            afnsaux.Add(aux);//50

            aux = new AFN();
            aux.crearAFNBasico('/');
            afnsaux.Add(aux);//60

            aux = new AFN();
            aux.crearAFNBasico('(');
            afnsaux.Add(aux);//70

            aux = new AFN();
            aux.crearAFNBasico(')');
            afnsaux.Add(aux);//80

            aux = new AFN();
            aux.crearAFNBasico('[');
            afnsaux.Add(aux);//90

            aux = new AFN();
            aux.crearAFNBasico(']');
            afnsaux.Add(aux);//100

            aux = new AFN();
            aux.crearAFNBasico(',');
            afnsaux.Add(aux);//110

            aux = new AFN();
            aux1 = new AFN();
            aux2 = new AFN();
            aux.crearAFNBasico('0', '9');
            aux.cerraduraKleene();
            aux1.crearAFNBasico('.');
            aux2.crearAFNBasico('0', '9');
            aux2.cerraduraKleene();
            aux1.concatAFNs(aux2);
            aux1.operacionOpcional();
            aux.concatAFNs(aux1);
            afnsaux.Add(aux);//NUM 120

            


            aux = new AFN();
            aux = aux.unionEspecialAFNs(afnsaux);
            Matrix matriz = new Matrix(matrizRevisar.Text, aux.convAFNaAFD());
            if (matriz.iniEval())
            {
                //textResultado.Text = evaluador.Resultado.ToString();
                Postfijo.Text = matriz.ExprPost;
                MessageBox.Show("Expresion sintacticamente correcta", "AVISO", MessageBoxButtons.OK);
            }
            else
            {
                //textResultado.Text = "ERROR MATH";
                Postfijo.Text = "ERROR SINTACTIC";
                MessageBox.Show("Expresion sintacticamente incorrecta", "ERROR", MessageBoxButtons.OK);
            }
        }
    }
}
