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
    public partial class Basico : Form
    {
        public HashSet<AFN> afns = new HashSet<AFN>();
        public HashSet<AFD> afds = new HashSet<AFD>();

        public Basico(HashSet<AFN>afns1,HashSet<AFD>afds1)
        {
            
            InitializeComponent();
            this.afns = afns1;
            this.afds = afds1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCrearAFN_Click(object sender, EventArgs e)
        {
            char inf, sup;
            char[] aux;
            if(chbASCII.Checked)
            {
                inf =(char) int.Parse(txtCaracterInferior.Text);
                sup =(char) int.Parse(txtCaracterSuperior.Text);
            }
            else
            {
                aux =txtCaracterInferior.Text.ToCharArray();
                inf = aux[0];
                aux = txtCaracterSuperior.Text.ToCharArray();
                sup = aux[0];
            }
            AFN adnaux = new AFN(int.Parse(txtIdAFN.Text));
            adnaux.crearAFNBasico(inf, sup);
            if (afns.Add(adnaux))
            {
                MessageBox.Show("Se agrego el AFN " + txtIdAFN.Text);            
            }
            else
            {
                MessageBox.Show("Error: no se agrego ningun AFN");
            }
            Compilador compi = new Compilador(afns, afds);
            compi.Show();
            this.Hide();
        }

        private void Basico_Load(object sender, EventArgs e)
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
