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
    public partial class ERAFN : Form
    {

        public HashSet<AFN> afns = new HashSet<AFN>();
        public HashSet<AFN> afnsaux = new HashSet<AFN>();
        public HashSet<AFD> afds = new HashSet<AFD>();
        public ERAFN()
        {
            InitializeComponent();
        }

        public ERAFN(HashSet<AFN> afns1, HashSet<AFD> afds1)
        {
            //InitializeComponent();
            afns = afns1;
            afds = afds1;
            InitializeComponent();
        }


        private void cerrarForm(object sender, EventArgs e)
        {
            Compilador compi = new Compilador(afns, afds);
            compi.Show();
            this.Hide();
        }

        private void Convertir_Click(object sender, EventArgs e)
        {
            string expresion = ERegular.Text;
            afnsaux.Clear();
            AFN auxiliar = new AFN();
            auxiliar.crearAFNBasico('|');//10
            afnsaux.Add(auxiliar);
            auxiliar = new AFN();
            auxiliar.crearAFNBasico('&');//20
            afnsaux.Add(auxiliar);
            auxiliar = new AFN();
            auxiliar.crearAFNBasico('+');//30
            afnsaux.Add(auxiliar);
            auxiliar = new AFN();
            auxiliar.crearAFNBasico('*');//40
            afnsaux.Add(auxiliar);
            auxiliar = new AFN();
            auxiliar.crearAFNBasico('?');//50
            afnsaux.Add(auxiliar);
            auxiliar = new AFN();
            auxiliar.crearAFNBasico('(');//60
            afnsaux.Add(auxiliar);
            auxiliar = new AFN();
            auxiliar.crearAFNBasico(')');//70
            afnsaux.Add(auxiliar);
            auxiliar = new AFN();
            auxiliar.crearAFNBasico('[');//80
            afnsaux.Add(auxiliar);
            auxiliar = new AFN();
            auxiliar.crearAFNBasico(']');//90
            afnsaux.Add(auxiliar);
            auxiliar = new AFN();
            auxiliar.crearAFNBasico('-');//100
            afnsaux.Add(auxiliar);
            auxiliar = new AFN();
            AFN auxiliar1 = new AFN();
            auxiliar.crearAFNBasico('a', 'z');
            auxiliar.unirAFNs(auxiliar1.crearAFNBasico('A', 'Z'));
            auxiliar1 = new AFN();
            auxiliar.unirAFNs(auxiliar1.crearAFNBasico('0', '9'));
            afnsaux.Add(auxiliar);//110
            auxiliar = new AFN();
            auxiliar = auxiliar.unionEspecialAFNs(afnsaux);
            ER_AFN erafn = new ER_AFN(expresion, auxiliar.convAFNaAFD());
            if (erafn.iniConv())
            {
                erafn.result.idAFN = afns.Count()+1;
                foreach (AFN a in afns)
                {
                    while(erafn.result.idAFN == a.idAFN)
                    {
                        erafn.result.idAFN++;
                    }

                }
                afns.Add(erafn.result);
                MessageBox.Show("Se convirtio ER a AFN");
            }
            else
            {
                MessageBox.Show("Fallo la coonversion, asegurese de usar & para la concatenacion");
            }
        }

        private void ERAFN_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(cerrarForm);
        }
    }
}
