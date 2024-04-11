using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorLexico
{
    internal class edoAnalizLexico
    {
        public int token, edoActual, edoTransicion, iniLexema, finLexema, iCharAct;
        public string cadSigma;
        public char charActual;
        public string Lexema;
        public bool pasEdoAccept;
        public Stack<int> Pila = new Stack<int>();
        public AFD AutomataFD;

        
    }
}