using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorLexico
{
    internal class Transicion
    {
        //Atributos Transicion
        private char simSup1;
        private char simInf1;
        private Estado Edo1;

        //constructores
        public Transicion(char simSup, char simInf, Estado e)
        {
            simSup1 = simSup;
            simInf1 = simInf;
            Edo1 = e;
        }
        public Transicion(char simb, Estado e)
        {
            simSup1 = simb;
            simInf1 = simb;
            Edo1 = e;
        }
        public Transicion()
        {
            Edo1 = null;
        }

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

        public Estado getEstado()
        {
            return Edo1;
        }

        public void setEstado(Estado e)
        {
            Edo1 = e;
        }
        //Metodos
        public void setTransicion(char s1,char s2,Estado e)
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

        public Estado getEdoTrans(char s)
        {
            if (simInf1 <= s && simSup1 >= s)
            {
                return Edo1;
            }
            return null;
        }
    }
}
