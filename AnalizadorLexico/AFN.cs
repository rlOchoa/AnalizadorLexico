using System;
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
            _ = conjEstados.Add(e);
            foreach (Transicion t in e.Trans)
            {
                if (t.getSimInf() == SimbolosEspeciales.EPSILON)
                {
                    conjEstados.UnionWith(operacionEpsilon(e));
                }
            }

            return conjEstados;
        }

        public HashSet<Estado> operacionEpsilon(HashSet<Estado> e)
        {
            HashSet<Estado> conjEstados = new HashSet<Estado>();
            _ = conjEstados.Add(e);
            foreach(Estado edo in e)
            {
                foreach (Transicion t in edo.Trans)
                {
                    if (t.getSimInf() == SimbolosEspeciales.EPSILON)
                    {
                        conjEstados.UnionWith(operacionEpsilon(e));
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

        

        public Estado irA(HashSet<Estado> e,char a)
        {
            foreach(Estado edo in e)
            {
                operacionEpsilon(mover(edo, a));
            }
            return operacionEpsilon(mover(e, a));
        }
    }
}
