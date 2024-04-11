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
        public HashSet<Estado> EdosAccept = new HashSet<Estado>(); //ya
        public HashSet<char> alfabeto = new HashSet<char>(); //ya
        public int NumEstados;
        public int[,] TablaAFD;
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

        public AFD crearAFD(HashSet<EstadoIdj> EdosAFDdeAFN, int numEdoAFD, HashSet<char>alfabe)
        {
            int i = 0,k = 0,l = 0;
            Estado aux;
            AFD nuevoAFD = new AFD();
            nuevoAFD.alfabeto = alfabe; ////////////////
            for (i = 0; i <= numEdoAFD; i++)
            {
                Estado e = new Estado();
                if (i == 0)
                {
                    nuevoAFD.EdoIni = e; ////////////////
                }
                _ = nuevoAFD.EdosAFD.Add(e); ////////////////////
            }
            foreach (EstadoIdj conjIj in EdosAFDdeAFN)
            {   
                for (k = 0; k < 257; k++)
                {
                    if (conjIj.transicionesAFD[k] != -1)
                    {
                        Transicion tra = new Transicion();
                        tra.setTransicion((char)k, buscarEdo(conjIj.transicionesAFD[k]));
                        aux = buscarEdo(conjIj.j);
                        aux.Trans.Add(tra); ////////////////////////
                        TablaAFD[l,k]= aux.getIdEstado();
                        if (k == 256)
                        {
                            aux = buscarEdo(conjIj.j);
                            aux.setToken(conjIj.transicionesAFD[k]);
                            aux.setEdoAccept(true);
                            _ = nuevoAFD.EdosAccept.Add(aux);
                        }
                    }
                }
                l++;
            }

            return nuevoAFD;
        }

        public Estado buscarEdo(int k)
        {
            foreach (Estado Edo in EdosAFD)
            {
                if (Edo.getIdEstado() == k)
                {
                    return Edo;
                }
            }
            return null;
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
                    TablaAFD = new int[NumEstados, 257];
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
