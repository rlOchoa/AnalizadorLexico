using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorLexico
{
    public class Transicion
    {
        //Atributos Transicion
        private char simInf1;
        private char simSup1;
        private Estado Edo1;

        //constructores
        public Transicion(char simb, Estado e)
        {
            simSup1 = simb;
            simInf1 = simb;
            Edo1 = e;
        }

        public Transicion(char simSup, char simInf, Estado e)
        {
            simInf1 = simInf;
            simSup1 = simSup;
            Edo1 = e;
        }

        public Transicion()
        {
            Edo1 = null;
        }

        public void setTransicion(char s1, char s2, Estado e)
        {
            simSup1 = s1;
            simInf1 = s2;
            Edo1 = e;
        }

        public void setTransicion(char s1, Estado e)
        {
            simSup1 = s1;
            simInf1 = s1;
            Edo1 = e;
        }

        //Getters and setters
        //public char SimbInf { get => simInf1; set => simInf1 = value; }
        //public char simbSup { get => simSup1; set => simSup1 = value; }

        //Metodos GET y SET
        public char getSimSup()
        {
            return simSup1;
        }

        public void setSimSup(char simSup)
        {
            simSup1 = simSup;
        }

        public char getSimInf()
        {
            return simInf1;
        }

        public void setSimInf(char simInf)
        {
            simInf1 = simInf;
        }

        //Needed? Probably, not gonna move for now.
        public Estado getEstado()
        {
            return Edo1;
        }

        public void setEstado(Estado e)
        {
            Edo1 = e;
        }
        //Metodos

        public Estado getEdoTrans(char s)
        {
            if (simInf1 >= s && simSup1 <= s)
            {
                return Edo1;
            }
            return null;
        }
    }
}
