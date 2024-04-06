﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AnalizadorLexico.Program;

namespace AnalizadorLexico
{
    internal class AFN
    {
        //Atributos
        public static HashSet<AFN> conjDeAFNs = new HashSet<AFN>();
        Estado EdoIni;
        HashSet<Estado> EdosAFN = new HashSet<Estado>();
        HashSet<Estado> EdosAccept = new HashSet<Estado>();
        HashSet<char> alfabeto = new HashSet<char>();
        public int idAFN;

        //constructores
        public AFN()
        {
            idAFN = 0;
            EdoIni = null;
            EdosAFN.Clear();
            EdosAccept.Clear();
            alfabeto.Clear();
        }

        //Metodos
        public AFN crearAFNBascio(char s)
        {
            Transicion t;
            Estado e1, e2;
            e1 = new Estado();
            e2 = new Estado();
            t = new Transicion(s,e2);
            _ = e1.Trans.Add(t);
            e2.setEdoAccept(true);
            _ = alfabeto.Add(s);
            EdoIni = e1;
            _ = EdosAFN.Add(e1);
            _ = EdosAFN.Add(e2);
            _ = EdosAccept.Add(e2);
            return this;
        }
        public AFN crearAFNBascio(char s1, char s2)
        {
            char i;
            if (s1 > s2)
            {
                char aux = s1;
                s1 = s2;
                s2 = aux;
            } 
            Transicion t;
            Estado e1, e2;
            e1 = new Estado();
            e2 = new Estado();
            t = new Transicion(s1, s2, e2);
            e1.Trans.Add(t);
            e2.setEdoAccept(true);
            for (i = s1 ; i <= s2 ; i++)
            {
                _ = alfabeto.Add(i);
            }
            EdoIni = e1;
            _ = EdosAFN.Add(e1);
            _ = EdosAFN.Add(e2);
            _ = EdosAccept.Add(e2);
            return this;
        }
        public AFN unirAFNs(AFN afn)
        {
            Estado e1 = new Estado();
            Estado e2 = new Estado();

            Transicion t1 = new Transicion(SimbolosEspeciales.EPSILON, this.EdoIni);
            Transicion t2 = new Transicion(SimbolosEspeciales.EPSILON,afn.EdoIni);
            _ = e1.Trans.Add(t1);
            _ = e1.Trans.Add(t2);

            foreach(Estado e in this.EdosAccept)
            {
                _ = e.Trans.Add(new Transicion(SimbolosEspeciales.EPSILON,e2));
                e.setEdoAccept(false);
            }
            foreach (Estado e in afn.EdosAccept)
            {
                _ = e.Trans.Add(new Transicion(SimbolosEspeciales.EPSILON, e2));
                e.setEdoAccept(false);
            }

            this.EdosAccept.Clear();
            afn.EdosAccept.Clear();
            this.EdoIni = e1;
            e2.setEdoAccept(true);
            _ = this.EdosAccept.Add(e2);
            this.EdosAFN.UnionWith(afn.EdosAFN);
            _ = this.EdosAFN.Add(e1);
            _ = this.EdosAFN.Add(e2);
            this.alfabeto.UnionWith(afn.alfabeto);
            return this;
        }

        public AFN concatAFNs(AFN afn)
        {
            foreach (Transicion t in afn.EdoIni.Trans)
            {
                foreach (Estado e in this.EdosAccept)
                {
                    _ = e.Trans.Add(t);
                    e.setEdoAccept(false);
                }
            }
            afn.EdosAFN.Remove(afn.EdoIni);

            this.EdosAccept = afn.EdosAccept;
            this.EdosAFN.UnionWith(afn.EdosAFN);
            this.alfabeto.UnionWith(afn.alfabeto);

            return this;
        }

        public AFN cerraduraPos()
        {
            Estado eInicial = new Estado();
            Estado eFinal = new Estado();

            _ = eInicial.Trans.Add(new Transicion(SimbolosEspeciales.EPSILON, this.EdoIni));
            foreach (Estado e in this.EdosAccept)
            {
                _ = e.Trans.Add(new Transicion(SimbolosEspeciales.EPSILON, eFinal));
            }
            _ = eFinal.Trans.Add(new Transicion(SimbolosEspeciales.EPSILON, eInicial));

            _ = this.EdosAFN.Add(eInicial);
            _ = this.EdosAFN.Add(eFinal);
            this.EdosAccept.Clear();
            _ = this.EdosAccept.Add(eFinal);
            this.EdoIni = eInicial;
           

            return this;
        }

        public AFN cerraduraKleene()
        {
            Estado eInicial = new Estado();
            Estado eFinal = new Estado();

            _ = eInicial.Trans.Add(new Transicion(SimbolosEspeciales.EPSILON, this.EdoIni));
            foreach (Estado e in this.EdosAccept)
            {
                _ = e.Trans.Add(new Transicion(SimbolosEspeciales.EPSILON, eFinal));
            }
            _ = eFinal.Trans.Add(new Transicion(SimbolosEspeciales.EPSILON, eInicial));
            _ = eInicial.Trans.Add(new Transicion(SimbolosEspeciales.EPSILON,eFinal));

            _ = this.EdosAFN.Add(eInicial);
            _ = this.EdosAFN.Add(eFinal);
            this.EdosAccept.Clear();
            _ = this.EdosAccept.Add(eFinal);
            this.EdoIni = eInicial;


            return this;
        }

        public AFN operacionOpcional()
        {
            Estado eInicial = new Estado();
            Estado eFinal = new Estado();

            _ = eInicial.Trans.Add(new Transicion(SimbolosEspeciales.EPSILON, this.EdoIni));
            foreach (Estado e in this.EdosAccept)
            {
                _ = e.Trans.Add(new Transicion(SimbolosEspeciales.EPSILON, eFinal));
            }
            _ = eInicial.Trans.Add(new Transicion(SimbolosEspeciales.EPSILON, eFinal));

            _ = this.EdosAFN.Add(eInicial);
            _ = this.EdosAFN.Add(eFinal);
            this.EdosAccept.Clear();
            _ = this.EdosAccept.Add(eFinal);
            this.EdoIni = eInicial;


            return this;
        }

        public HashSet<Estado> operacionEpsilon(Estado e)
        {
            HashSet<Estado> conjEstados = new HashSet<Estado>();
            Stack<Estado> pilaEstados = new Stack<Estado>();
            Estado aux, edo;
            conjEstados.Clear();
            pilaEstados.Clear();

            pilaEstados.Push(e);
            while(pilaEstados.Count != 0)
            {
                aux = pilaEstados.Pop();
                _ = conjEstados.Add(aux);
                foreach(Transicion t in aux.Trans)
                {
                    if((edo = t.getEdoTrans(SimbolosEspeciales.EPSILON)) != null)
                    {
                        if (!conjEstados.Contains(edo))
                        {
                            pilaEstados.Push(edo);
                        }
                    }
                }
            }
           
            return conjEstados;
        }

        public HashSet<Estado> operacionEpsilon(HashSet<Estado> e)
        {
            HashSet<Estado> conjEstados = new HashSet<Estado>();
            Stack<Estado> pilaEstados = new Stack<Estado>();
            Estado aux, edo;
            conjEstados.Clear();
            pilaEstados.Clear();
            foreach(Estado ed in e)
            {
                pilaEstados.Push(ed);
            }
            while (pilaEstados.Count != 0)
            {
                aux = pilaEstados.Pop();
                _ = conjEstados.Add(aux);
                foreach (Transicion t in aux.Trans)
                {
                    if ((edo = t.getEdoTrans(SimbolosEspeciales.EPSILON)) != null)
                    {
                        if (!conjEstados.Contains(edo))
                        {
                            pilaEstados.Push(edo);
                        }
                    }
                }
            }

            return conjEstados;
        }

        public HashSet<Estado> mover(Estado e, char a)
        {
            HashSet<Estado> conjEstados = new HashSet<Estado>();
            foreach (Transicion t in e.Trans)
            {
                if (t.getSimInf() == a)
                {
                    _ = conjEstados.Add(e);
                }
            }
            return conjEstados;
        }

        public HashSet<Estado> mover(HashSet<Estado> edos, char a)
        {
            HashSet<Estado> conjEstados = new HashSet<Estado>();
            foreach (Estado e in edos)
            {
                foreach (Transicion t in e.Trans)
                {
                    if (t.getSimInf() == a)
                    {
                        _ = conjEstados.Add(e);
                    }
                }
            }
            return conjEstados;
        }

        public HashSet<Estado> irA(HashSet<Estado> e,char a)
        {         
            return operacionEpsilon(mover(e, a));
        }

        

        public AFD convAFNaAFD()
        {
            int cardinAlfabeto, numEdoAFD;
            int i, j, r;
            char[] arralfabeto;
            EstadoIdj Ij, Ik;
            bool existe;

            HashSet<Estado> conjAux = new HashSet<Estado> ();
            HashSet<EstadoIdj> EdosAFD = new HashSet<EstadoIdj> ();
            Queue<EstadoIdj> EdosSinAnalizar = new Queue<EstadoIdj> (); 

            EdosAFD.Clear ();
            EdosSinAnalizar.Clear();

            cardinAlfabeto = alfabeto.Count;
            arralfabeto = new char[cardinAlfabeto];
            i = 0;
            foreach(char c in arralfabeto)
            {
                arralfabeto[i++] = c;
            }
            j = 0;
            Ij = new EstadoIdj()
            {
                j = j,
                conIj = operacionEpsilon(this.EdoIni)
            };

            EdosAFD.Add (Ij);
            EdosSinAnalizar.Enqueue(Ij);
            j++;
            while(EdosSinAnalizar.Count != 0)
            {
                Ij = EdosSinAnalizar.Dequeue();

                foreach(char c in alfabeto)
                {
                    Ik = new EstadoIdj()
                    {
                        conIj = irA(Ij.conIj,c)
                    };

                    if (Ik.conIj.Count() == 0)
                        continue;
                    existe = false;
                    foreach(EstadoIdj I in EdosAFD)
                    {
                        if (I.conIj.SetEquals(Ik.conIj))
                        {
                            existe = true;
                            r = indiceCaracter(arralfabeto,c);
                            Ij.transicionesAFD[r] = I.j;
                        }
                    }
                    if (!existe)
                    {
                        Ik.j = j;
                        r = indiceCaracter(arralfabeto, c);
                        Ij.transicionesAFD[r] = Ik.j;
                        _ = EdosAFD.Add(Ik);
                        EdosSinAnalizar.Enqueue(Ik);
                        j++;
                    }
                }
            }
            numEdoAFD = j;
            foreach(EstadoIdj eafd in EdosAFD)
            {
                HashSet<Estado> aux = eafd.conIj;
                aux.IntersectWith(this.EdosAccept);
                if (aux != null)
                {
                    foreach (Estado e in this.EdosAccept)
                    {
                        eafd.transicionesAFD[256]=e.getToken();
                    }
                }
            }
            AFD nuevoAFD = new AFD();
            nuevoAFD.crearAFD(EdosAFD,numEdoAFD,this.alfabeto);
            return nuevoAFD;
        }

        public int indiceCaracter(char[] arregloAlfabeto,char c)
        {
            int aux=0;
            for (int i = 0; i < arregloAlfabeto.Length; i++)
            {
                if (arregloAlfabeto[i]==c)
                {
                    aux= i;
                }
            }
            return aux;
        }
    }
}
