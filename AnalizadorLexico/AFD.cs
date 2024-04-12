using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorLexico
{
    public class AFD
    {
        //atributos
        public static HashSet<AFD> conjDeAFDs = new HashSet<AFD>();
        public Estado EdoIni; //ya
        public HashSet<Estado> EdosAFD = new HashSet<Estado>(); //ya
        public HashSet<Estado> EdosAccept = new HashSet<Estado>(); // Ya
        public HashSet<char> alfabeto = new HashSet<char>(); // ya
        public int NumEstados;
        public int[,] TablaAFD; //ya
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

        

        public AFD crearAFD(HashSet<EstadoIdj> EdosAFDdeAFN, int numEdoAFD, HashSet<char>alfabe,Estado edoinicioAFN)
        {
            int i = 0,k = 0,l = 0;
            Estado aux;
            AFD nuevoAFD = new AFD();
            nuevoAFD.TablaAFD = new int[NumEstados+1, 257];
            nuevoAFD.alfabeto = alfabe; // pasa alfabeto
            foreach (EstadoIdj conjedos in EdosAFDdeAFN)
            {
                Estado e = new Estado();
                e.setIdEstado(conjedos.j);
                foreach(Estado estado in conjedos.conIj)
                {
                    if (estado.getEdoAccept())
                    {
                        e.setEdoAccept(true);
                        e.setToken(estado.getToken());
                        nuevoAFD.TablaAFD[l, 256] = estado.getToken();
                        _ = nuevoAFD.EdosAccept.Add(e);
                    }
                    if (estado.Equals(edoinicioAFN))
                    {
                        nuevoAFD.EdoIni = estado;
                    }
                }
                for (k = 0; k < 257; k++)
                {
                    nuevoAFD.TablaAFD[l, k] = conjedos.transicionesAFD[k];
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
        }



        public void LeerAFDdeArchivo(string nombreArchivo, int idAFD1)
        {
            string linea;
            string[] datos;
            System.IO.StreamReader file = new System.IO.StreamReader(nombreArchivo);
            idAFD = idAFD1;
            while ((linea = file.ReadLine()) != null)
            {
                datos = linea.Split(',');
                if (datos[0] == "AFD")
                {
                    NumEstados = Convert.ToInt32(datos[1]);
                    TablaAFD = new int[NumEstados, 256];
                }
                else
                {
                    int i = Convert.ToInt32(datos[0]);
                    int j = Convert.ToInt32(datos[1]);
                    int k = Convert.ToInt32(datos[2]);
                    TablaAFD[i, j] = k;
                }
            }
            file.Close();
        }
    }
}
