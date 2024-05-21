using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalizadorLexico
{
    public class AFD
    {
        //atributos
        public static HashSet<AFD> conjDeAFDs = new HashSet<AFD>();
        public Estado EdoIni { get; set; }; //ya
        public HashSet<Estado> EdosAFD = new HashSet<Estado>(); //ya
        public HashSet<Estado> EdosAccept = new HashSet<Estado>(); // ya
        public HashSet<char> alfabeto = new HashSet<char>(); // ya
        public int NumEstados { get; set; }; //ya
        public int[,] TablaAFD { get; set; }; //ya
        public int idAFD=0; //ya

        public AFD()
        {
            EdoIni = null;
            EdosAFD.Clear();
            EdosAccept.Clear();
            alfabeto.Clear();
            NumEstados = 0;
            idAFD++;
        }

        

        /* AFD crearAFD(HashSet<EdoIj> EdosAFD, int numEdoAFD, HashSet<char>alfabe,Estado edoinicioAFN)
        {
            int i = 0,k = 0,l = 0;
            Estado aux;
            AFD nuevoAFD = new AFD();
            nuevoAFD.TablaAFD = new int[numEdoAFD, 257];
            nuevoAFD.alfabeto = alfabe; // pasa alfabeto
            foreach (EdoIj conjEdos in EdosAFD)
            {
                Estado e = new Estado();
                e.setIdEstado(conjEdos.j);
                foreach(Estado estado in conjEdos.conIj)
                {
                        
                    if (estado.getEdoAccept())
                    {

                        e.setEdoAccept(true);
                        e.setToken(estado.getToken());
                        int tokenAuxiliar = estado.getToken();
                        nuevoAFD.TablaAFD[l, 256] = tokenAuxiliar;
                        MessageBox.Show("Parar Token "+tokenAuxiliar+" en la fila "+l);
                        _ = nuevoAFD.EdosAccept.Add(e);
                    }
                    if (estado.Equals(edoinicioAFN))
                    {
                        nuevoAFD.EdoIni = estado;
                    }
                }
                for (k = 0; k < 257; k++)
                {
                    nuevoAFD.TablaAFD[l, k] = conjEdos.transicionesAFD[k];
                }
                l++;
                _ = nuevoAFD.EdosAFD.Add(e);
            }
            i = 0;
            foreach(Estado e in nuevoAFD.EdosAFD)
            {
                for(k = 0; k < 257; k++)
                {
                    if (nuevoAFD.TablaAFD[i, k] != -1)
                    {
                        foreach (Estado edo in nuevoAFD.EdosAFD)
                        {
                            if (edo.getIdEstado() == nuevoAFD.TablaAFD[i, k])
                            {
                                Transicion t = new Transicion((char)k,edo);
                                e.Trans.Add(t);
                            }

                        }
                    }
                }
                i++;
            }
            return nuevoAFD;
        }*/



        
    }
}
