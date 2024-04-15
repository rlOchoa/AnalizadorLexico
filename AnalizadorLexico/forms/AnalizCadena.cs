using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            int idAfdSelected = int.Parse(cmbAFD.Text);
            AFD AfdSelected = new AFD();
            dt.Rows.Clear();
            foreach (AFD aux in afds)
            {
                if (aux.idAFD == idAfdSelected)
                {
                    AfdSelected = aux;
                }
            }

            for (int i = 0; i < AfdSelected.EdosAFD.Count; i++)
            {
                row = dt.NewRow();
                row["Estado"] = i.ToString();
                for (int j = 0; j < 257; j++)
                {
                    if (j != 256)
                    {
                        row["char " + j] = AfdSelected.TablaAFD[i, j].ToString();
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
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String ruta = openFileDialog1.FileName;
                lblRuta.Text = ruta;
                String cadena = leerArchivoCadena(ruta);
                MessageBox.Show(cadena);
                txtCadena.Text = cadena;
            }
        }

        private void btnAnalizar_Click(object sender, EventArgs e)
        {
            AFD AFDSelected = new AFD();
            int idAfdSelected = int.Parse(cmbAFD.Text);
            int [] token = new int[1000];
            string cadenafinal = "";
            int i = 0;
            bool cadenaAceptada = false;

            foreach (AFD aux in afds)
            {
                if (aux.idAFD == idAfdSelected)
                {
                    AFDSelected = aux;
                }
            }

            AnalizLexico anaLex = new AnalizLexico(txtCadena.Text, AFDSelected);
            //token[i] = anaLex.yylex();
            //cadenafinal= cadenafinal + token[i].ToString()+",";
            //i++;

            while ((token[i]=anaLex.yylex()) != SimbolosEspeciales.FIN)
            {
                cadenafinal = cadenafinal + token[i].ToString() + ",";
                i++;
            }
            MessageBox.Show(cadenafinal);

            /*foreach(Estado edo in AFDSelected.EdosAccept)
            {
                if (edo.getToken()==token[i])
                {
                    cadenaAceptada=true;
                    //MessageBox.Show("La cadena es aceptada por el token " + token +" desde el caracter inicial "+anaLex.iniLexema+" hasta el caracter final "+anaLex.finLexema);
                }
            }
            if (!cadenaAceptada)
            {
                MessageBox.Show("La cadena fue rechazada con codigo de error "+token);
            }*/
        }

        public String leerArchivoCadena(String txtName)
        {
            String linea,cadena="";
            using (StreamReader file = new StreamReader(@txtName))
            {
                while ((linea = file.ReadLine())!=null)
                {
                    cadena = cadena+linea;
                }
                file.Close();
                return cadena;
            }
        }

        public void GuardarAFD(AFD afdSelected)
        {
            String datos = "";
            String nameFile = "AFD" + afdSelected.idAFD+".txt";
            using (TextWriter file = new StreamWriter(nameFile))
            {
                datos = "AFD," + afdSelected.NumEstados;
                file.WriteLine(datos);
                file.Close();

                StreamWriter agregar = File.AppendText(nameFile);
                for (int i=0; i < afdSelected.NumEstados; i++)
                {
                    for (int j = 0; j < 257; j++)
                    {
                        datos = i.ToString() +","+ j.ToString() +","+ afdSelected.TablaAFD[i, j].ToString();
                        agregar.WriteLine(datos);
                    }
                }
                agregar.Close();
                MessageBox.Show("El AFD fue guardado");
            }
        }

        private void btnGuardarAFD_Click(object sender, EventArgs e)
        {
            AFD AFDSelected = new AFD();
            int idAfdSelected = int.Parse(cmbAFD.Text);
            
            foreach (AFD aux in afds)
            {
                if (aux.idAFD == idAfdSelected)
                {
                    AFDSelected = aux;
                }
            }
            MessageBox.Show("Stop");
            GuardarAFD(AFDSelected);
        }

        private void btnCargarArchivoAFD_Click(object sender, EventArgs e)
        {
            int idAFDSelected = int.Parse(txtidAFD.Text);
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                String ruta = openFileDialog2.FileName;
                LeerAFDdeArchivo(ruta,idAFDSelected);
                
                //xtCadena.Text = cadena;
            }
        }

        public void LeerAFDdeArchivo(string nombreArchivo, int idAFD1)
        {
            AFD afdAux = new AFD();
            Estado edo;
            int idAux = 0;
            string linea;
            string[] datos;
            StreamReader file = new StreamReader(nombreArchivo);
            afdAux.idAFD = idAFD1;
            while ((linea = file.ReadLine()) != null)
            {
                
                datos = linea.Split(',');
                if (datos[0] == "AFD")
                {
                    afdAux.NumEstados = Convert.ToInt32(datos[1]);
                    afdAux.TablaAFD = new int[afdAux.NumEstados, 256];
                    for (int i = 0; i < afdAux.NumEstados; i++)
                    {
                        edo = new Estado();
                        edo.setIdEstado(i);
                        if(i ==0)
                        {
                            afdAux.EdoIni = edo;
                        }
                        afdAux.EdosAFD.Add(edo);
                    }
                }
                else
                {
                    
                    int i = Convert.ToInt32(datos[0]);
                    int j = Convert.ToInt32(datos[1]);
                    int k = Convert.ToInt32(datos[2]);
                    afdAux.TablaAFD[i, j] = k;
                    if (afdAux.TablaAFD[i, j] != -1)
                    {
                        afdAux.alfabeto.Add((char)j);
                        foreach(Estado edoAux in afdAux.EdosAFD)
                        {
                            if (edoAux.getIdEstado()==i)
                            {
                                if (j != 256)
                                {
                                    Transicion t = new Transicion((char)j,buscarEdo(afdAux.EdosAFD,k));
                                    edoAux.Trans.Add(t);
                                }else
                                {
                                    edoAux.setToken(k);
                                    if (edoAux.getToken() != 0)
                                    {
                                        edoAux.setEdoAccept(true);
                                        afdAux.EdosAccept.Add(edoAux);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            file.Close();
            afds.Add(afdAux);
            llenarComboBox();
        }

        public Estado buscarEdo(HashSet<Estado>conjEdos,int idEdo)
        {
            foreach (Estado estado in conjEdos)
            {
                if (estado.getIdEstado() == idEdo)
                {
                    return estado;
                }
            }
            return null;
        }
    }
}
