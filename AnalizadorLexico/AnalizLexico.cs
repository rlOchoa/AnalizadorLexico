using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorLexico
{
    class AnalizLexico
    {
        int token, edoActual, edoTransicion;
        string cadSigma;
        public string Lexema;
        bool pasEdoAccept;
        int iniLexema, finLexema, iChar;
        char charActual;
        Stack<int> Pila = new Stack<int>();
        AFD AutomataFD;

        public AnalizLexico()
        {
            cadSigma = "";
            pasEdoAccept = false;
            iniLexema = finLexema = -1;
            iChar = -1;
            token = -1;
            Pila.Clear();
            AutomataFD = null;
        }

        public AnalizLexico(string sigma, string archivoAFD, int idAFD)
        {
            AutomataFD = new AFD();
            cadSigma = sigma;
            pasEdoAccept = false;
            iniLexema = 0;
            finLexema = -1;
            iChar = 0;
            token = -1;
            Pila.Clear();
            AutomataFD.LeerAFDdeArchivo(archivoAFD, idAFD);
        }

        public AnalizLexico(string sigma, string archivoAFD)
        {
            AutomataFD = new AFD();
            cadSigma = sigma;
            pasEdoAccept = false;
            iniLexema = 0;
            finLexema = -1;
            iChar = 0;
            token = -1;
            Pila.Clear();
            AutomataFD.LeerAFDdeArchivo(archivoAFD, -1);
        }

        public AnalizLexico(string archivoAFD, int idAFD)
        {
            AutomataFD = new AFD();
            cadSigma = "";
            pasEdoAccept = false;
            iniLexema = 0;
            finLexema = -1;
            iChar = 0; //Index character
            token = -1;
            Pila.Clear();
            AutomataFD.LeerAFDdeArchivo(archivoAFD, idAFD);
        }

        public AnalizLexico(string sigma, AFD AutFD)
        {
            cadSigma = sigma;
            pasEdoAccept = false;
            iniLexema = 0;
            finLexema = -1;
            iChar = 0;
            token = -1;
            Pila.Clear();
            AutomataFD = AutFD;
        }

        public edoAnalizLexico GetEdoAnalizLexico()
        {
            edoAnalizLexico edoActualAnaliz = new edoAnalizLexico();
            edoActualAnaliz.charActual = charActual;
            edoActualAnaliz.edoActual = edoActual;
            edoActualAnaliz.edoTransicion = edoTransicion;
            edoActualAnaliz.finLexema = finLexema;
            edoActualAnaliz.iChar = iChar;
            edoActualAnaliz.iniLexema = iniLexema;
            edoActualAnaliz.Lexema = Lexema;
            edoActualAnaliz.pasEdoAccept = pasEdoAccept;
            edoActualAnaliz.token = token;
            edoActualAnaliz.Pila = Pila;
            return edoActualAnaliz;
        }

        public bool SetEdoAnalizLexico(edoAnalizLexico e)
        {
            charActual = e.charActual;
            edoActual = e.edoActual;
            edoTransicion = e.edoTransicion;
            finLexema = e.finLexema;
            iChar = e.iChar;
            iniLexema = e.iniLexema;
            Lexema = e.Lexema;
            pasEdoAccept = e.pasEdoAccept;
            token = e.token;
            Pila = e.Pila;
            return true;
        }

        public void setSigma(string sigma)
        {
            cadSigma = sigma;
            pasEdoAccept = false;
            iniLexema = 0;
            finLexema = -1;
            iChar = 0;
            token = -1;
            Pila.Clear();
        }

        public string cadenaXAnalizar()
        {
            return cadSigma.Substring(iChar, cadSigma.Length - iChar);
        }

        public int yylex()
        {
            while (true)
            {
                Pila.Push(iChar);
                if (iChar >= cadSigma.Length)
                {
                    Lexema = "";
                    return SimbolosEspeciales.FIN;
                }
                iniLexema = iChar;
                edoActual = 0;
                pasEdoAccept = false;
                finLexema = -1;
                token = -1;

                while (iChar < cadSigma.Length)
                {
                    charActual = cadSigma[iChar];
                    edoTransicion = AutomataFD.TablaAFD[edoActual, charActual];
                    if (edoTransicion != -1)
                    {
                        if (AutomataFD.TablaAFD[edoTransicion, 256] != -1)
                        {
                            pasEdoAccept = true;
                            token = AutomataFD.TablaAFD[edoTransicion, 256];
                            finLexema = iChar;
                        }

                        iChar++;
                        edoActual = edoTransicion;
                        continue;
                    }

                    break;
                }

                if (!pasEdoAccept)
                {
                    iChar = iniLexema + 1;
                    Lexema = cadSigma.Substring(iniLexema, 1);
                    token = SimbolosEspeciales.ERROR;
                    return token;
                }

                Lexema = cadSigma.Substring(iniLexema, finLexema - iniLexema + 1);
                iChar = finLexema + 1;
                if (token == SimbolosEspeciales.OMITIR)
                    continue;
                else
                    return token;
            }
        }

        public bool Undotoken()
        {
            if (Pila.Count == 0)
                return false;
            iChar = Pila.Pop();
            return true;
        }
    }
}
