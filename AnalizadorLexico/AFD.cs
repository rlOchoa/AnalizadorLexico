using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorLexico
{
    internal class AFD
    {
        //atributos
        public static HashSet<AFD> conjDeAFDs = new HashSet<AFD>();
        Estado EdoIni; //ya
        HashSet<Estado> EdosAFD = new HashSet<Estado>(); //ya
        HashSet<Estado> EdosAccept = new HashSet<Estado>(); //ya
        HashSet<char> alfabeto = new HashSet<char>(); //ya
        public int idAFD; //ya

        public AFD() 
        {
            idAFD = 0;
            EdoIni = null;
            EdosAFD.Clear();
            EdosAccept.Clear();
            alfabeto.Clear();
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
    }
}
