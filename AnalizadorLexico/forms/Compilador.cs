using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalizadorLexico
{
    public partial class Compilador : Form
    {
        public HashSet<AFN> afns = new HashSet<AFN>();
        public HashSet<AFD> afds = new HashSet<AFD>();

        public Compilador()
        {
            InitializeComponent();
        }

        public Compilador(HashSet<AFN> afns1, HashSet<AFD> afds1)
        {
            InitializeComponent();
            this.afns = afns1;
            this.afds = afds1;
        }

        private void basicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forms.Basico basic = new forms.Basico(afns,afds);
            basic.Show();
            this.Hide();
        }

        private void unirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forms.Unir unir = new forms.Unir(afns,afds);
            unir.Show();
            this.Hide();
        }

        private void cocatenarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forms.Concatenar concatenar = new forms.Concatenar(afns,afds);
            concatenar.Show();
            this.Hide();
        }

        private void cerraduraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forms.CerraduraPos cerradurapos = new forms.CerraduraPos(afns,afds);
            cerradurapos.Show();
            this.Hide();
        }

        private void cerradurakleeneToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            forms.CerraduraKleene cerradurakleene = new forms.CerraduraKleene(afns,afds);
            cerradurakleene.Show();
            this.Hide();
        }

        private void opcionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forms.Opcional opcional = new forms.Opcional(afns,afds);
            opcional.Show();
            this.Hide();
        }

        private void eRAFNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forms.ERAFN erafn = new forms.ERAFN();
            erafn.Show();
        }

        private void unionParaAnalizadorLexicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forms.UnionALex unionALex = new forms.UnionALex(afns,afds);
            unionALex.Show();
            this.Hide();
        }

        private void convertirAFNAFDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forms.ConverAFNAFD converAFNAFD = new forms.ConverAFNAFD(afns,afds);
            converAFNAFD.Show();
            this.Hide();
        }

        private void analizarUnaCadenaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forms.AnalizCadena analizarCadena = new forms.AnalizCadena();
            analizarCadena.Show();
        }

        private void probarAnalizadorLéxicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forms.ProbarALex probarALex = new forms.ProbarALex();
            probarALex.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(cerrarForm);
        }

        private void aFNsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cerrarForm(object sender, EventArgs e)
        {
             Application.Exit();
        }
    }
}
