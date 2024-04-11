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
    public partial class Opcional : Form
    {
        public HashSet<AFN> afns = new HashSet<AFN>();
        public HashSet<AFD> afds = new HashSet<AFD>();

        public Opcional()
        {
            InitializeComponent();
        }

        public Opcional(HashSet<AFN> afns1, HashSet<AFD> afds1)
        {
            InitializeComponent();
            afns = afns1;
            afds = afds1;
            llenarComboBox();
        }

        private void Opcional_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(cerrarForm);
        }

        private void btnCerraduraOpcional_Click(object sender, EventArgs e)
        {
            int combo = int.Parse(cmbAFN.Text);
            foreach (AFN aux in afns)
            {
                if (aux.idAFN == combo)
                {
                    aux.operacionOpcional();
                    MessageBox.Show("Se hizo cerradura opcional al AFN " + combo);
                    Compilador compi = new Compilador(afns, afds);
                    compi.Show();
                    this.Hide();
                }
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
            cmbAFN.Items.Clear();
            foreach (AFN aux in afns)
            {
                cmbAFN.Items.Add("" + aux.idAFN);
            }
        }
    }
}
