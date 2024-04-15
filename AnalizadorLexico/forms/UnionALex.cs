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
    public partial class UnionALex : Form
    {
        public HashSet<AFN> afns = new HashSet<AFN>();
        public HashSet<AFD> afds = new HashSet<AFD>();

        public UnionALex()
        {
            InitializeComponent();
        }

        public UnionALex(HashSet<AFN> afns1, HashSet<AFD> afds1)
        {
            InitializeComponent();
            afns = afns1;
            afds = afds1;
            llenarComboBox();
        }

        private void UnionALex_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(cerrarForm);
        }

        

        private void cerrarForm(object sender, EventArgs e)
        {
            Compilador compi = new Compilador(afns, afds);
            compi.Show();
            this.Hide();
        }

        private void llenarComboBox()
        {
            clbAFN.Items.Clear();
            foreach (AFN aux in afns)
            {
                clbAFN.Items.Add("" + aux.idAFN);
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUnionEspecial_Click(object sender, EventArgs e)
        {
            HashSet<AFN> auxiliar = new HashSet<AFN>();
            AFN nuevoAFn = new AFN();


            foreach (String afn in clbAFN.CheckedItems)
            {
                int idAFNSelected = int.Parse(afn);
                //MessageBox.Show("El elemento "+idAFNSelected+" fue selecionado");
                foreach (AFN aux in afns)
                {
                    if (aux.idAFN == idAFNSelected)
                    {
                        auxiliar.Add(aux);
                        //MessageBox.Show("Se agrego el AFN "+idAFNSelected);
                    }
                }
            }
            foreach(AFN aux in auxiliar)
            {
                afns.Remove(aux);
                //MessageBox.Show("Se elimino el AFN " + aux.idAFN);
            }

            afns.Add(nuevoAFn.unionEspecialAFNs(auxiliar));
            MessageBox.Show("Se unieron los AFN y se agregaron Tokens");
            Compilador compi = new Compilador(afns, afds);
            compi.Show();
            this.Hide();
        }
    }
}
