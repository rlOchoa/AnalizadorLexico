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
    public partial class Unir : Form
    {
        public HashSet<AFN> afns = new HashSet<AFN>();
        public HashSet<AFD> afds = new HashSet<AFD>();

        public Unir()
        {
            InitializeComponent();
        }

        public Unir(HashSet<AFN> afns1, HashSet<AFD> afds1)
        {
            InitializeComponent();
            afns = afns1;
            afds = afds1;
            llenarComboBox();
        }

        private void btnUnir_Click(object sender, EventArgs e)
        {
            int combo1, combo2;
            combo1 = int.Parse(cbxAFN1.Text);
            combo2 = int.Parse(cbxAFN2.Text);
            if (combo1 == combo2)
            {
                MessageBox.Show("No es posible unir el AFN consigo mismo");
            }
            else
            {
                AFN aux3 = new AFN();
                foreach (AFN aux in afns)
                {
                    foreach (AFN aux2 in afns)
                    {
                        if (aux.idAFN == combo1 && aux2.idAFN == combo2)
                        {
                            aux.unirAFNs(aux2);
                            MessageBox.Show("Se unio el AFN "+combo1+" con el AFN "+combo2);
                            aux3 = aux2;
                        }
                    }
                }
                afns.Remove(aux3);
                Compilador compi = new Compilador(afns, afds);
                compi.Show();
                this.Hide(); 
            }
        }

        private void cerrarForm(object sender, EventArgs e)
        {
            Compilador compi = new Compilador(afns, afds);
            compi.Show();
            this.Hide();
        }

        private void llenarComboBox()
        {
            cbxAFN1.Items.Clear();
            cbxAFN2.Items.Clear();
            foreach (AFN aux in afns)
            {
                cbxAFN1.Items.Add("" + aux.idAFN);
                cbxAFN2.Items.Add("" + aux.idAFN);
            }
        }

        private void Unir_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(cerrarForm);
        }
    }
}
