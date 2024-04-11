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
        Estado EdoIni; //ya
        HashSet<Estado> EdosAFD = new HashSet<Estado>(); //ya
        HashSet<Estado> EdosAccept = new HashSet<Estado>(); //ya
        HashSet<char> alfabeto = new HashSet<char>(); //ya
        public int NumEstados;
        public int[,] TablaAFD;
        public int idAFD; //ya

        public AFD()
        {
            this.TablaAFD = new int[0, 0];
            idAFD = 0;
            EdoIni = null;
            EdosAFD.Clear();
            EdosAccept.Clear();
            alfabeto.Clear();
        }

        public AFD(int numeroEstados, int idAutFD) 
        {
            TablaAFD = new int[numeroEstados, 257];
            for (int i = 0; i < numeroEstados; i++)
                
        }
        
        public AFD crearAFD(HashSet<EstadoIdj> EdosAFDdeAFN, int numEdoAFD, HashSet<char>alfabe)
        {
            int i = 0,k = 0;
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
                    }
                    if (conjIj.transicionesAFD[k] != -1 && k==256)
                    {
                        aux = buscarEdo(conjIj.j);
                        aux.setToken(conjIj.transicionesAFD[k]);
                        aux.setEdoAccept(true);
                        _ = nuevoAFD.EdosAccept.Add(aux);
                    }
                }
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

        public void LeerAFDdeArchivo(string nombreArchivo, int idAFD)
        {
            string linea;
            string[] datos;
            System.IO.StreamReader file = new System.IO.StreamReader(nombreArchivo);
            idAFD = idAFD;
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
