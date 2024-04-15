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
    public partial class AnalizCadena : Form
    {
        DataTable dt;
        public HashSet<AFN> afns = new HashSet<AFN>();
        public HashSet<AFD> afds = new HashSet<AFD>();

        public AnalizCadena()
        {
            InitializeComponent();
        }

        public AnalizCadena(HashSet<AFN> afns1, HashSet<AFD> afds1)
        {
            InitializeComponent();
            dt = new DataTable();
            dt.Columns.Add("Estado");
            for (int i = 0; i < 256; i++)
            {
                dt.Columns.Add("char " + i);
            }
            dt.Columns.Add("Token");

            dataGridAFD.DataSource = dt;
            afns = afns1;
            afds = afds1;
            llenarComboBox();
        }

        private void AnalizCadena_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(cerrarForm);
        }

        private void btnCArgarAFD_Click(object sender, EventArgs e)
        {
            DataRow row;
            int  idAfdSelected = int.Parse(cmbAFD.Text);
            AFD AfdSelected = new AFD();
            dt.Rows.Clear();
            foreach (AFD aux in afds)
            {
                if( aux.idAFD == idAfdSelected )
                {
                    AfdSelected = aux;
                }
            }

            for(int i = 0; i < AfdSelected.EdosAFD.Count; i++)
            {
                row = dt.NewRow();
                row["Estado"] = i.ToString();
                for (int j=0; j < 257; j++)
                {
                    if (j!=256)
                    {
                        row["char "+j] = AfdSelected.TablaAFD[i,j].ToString();
                    }
                    else
                    {
                        row["Token"] = AfdSelected.TablaAFD[i, j].ToString();
                    }
                }
                dt.Rows.Add(row);
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
            cmbAFD.Items.Clear();
            foreach (AFD aux in afds)
            {
                cmbAFD.Items.Add("" + aux.idAFD);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtCadena.Text = openFileDialog1.FileName;   
            }
        }

        private void analizarcad_Click(object sender, EventArgs e)
        {
            AnalizLexico al = new AnalizLexico();
            al = new AnalizLexico(txtCadena.Text, afds.ElementAt(0));
            al.yylex();
        }
    }
}
