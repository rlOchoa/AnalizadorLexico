using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalizadorLexico
{
    class AnalizLexico
    {
        public int token, edoActual, edoTransicion, iniLexema, finLexema, iCharAct;
        public string cadSigma;
        public char charActual;
        public string Lexema;
        public bool pasEdoAccept;
        public Stack<int> Pila = new Stack<int>();
        public AFD AutomataFD;

        public AnalizLexico()
        {
            cadSigma = "";
            pasEdoAccept = false;
            iniLexema = finLexema = -1;
            iCharAct = -1;
            token = -1;
            Pila.Clear();
            AutomataFD = null;
        }

        /*public AnalizLexico(string sigma, string archivoAFD, int idAFD)
        {
            AutomataFD = new AFD();
            cadSigma = sigma;
            pasEdoAccept = false;
            iniLexema = 0;
            finLexema = -1;
            iCharAct = 0;
            token = -1;
            Pila.Clear();
            AutomataFD.LeerAFDdeArchivo(archivoAFD, idAFD);
        }*/

        /*public AnalizLexico(string sigma, AFD AFDNoArchivo)
        {
            AutomataFD = new AFD();
            cadSigma = sigma;
            pasEdoAccept = false;
            iniLexema = 0;
            finLexema = -1;
            iCharAct = 0;
            token = -1;
            Pila.Clear();
            AutomataFD = AFDNoArchivo;
        }*/

        
        /*public AnalizLexico(string archivoAFD, int idAFD)
        {
            AutomataFD = new AFD();
            cadSigma = "";
            pasEdoAccept = false;
            iniLexema = 0;
            finLexema = -1;
            iCharAct = 0; //Index character
            token = -1;
            Pila.Clear();
            AutomataFD.LeerAFDdeArchivo(archivoAFD, idAFD);
        }*/
        public void setSigma(string sigma)
        {
            cadSigma = sigma;
            pasEdoAccept = false;
            iniLexema = 0;
            finLexema = -1;
            iCharAct = 0;
            token = -1;
            Pila.Clear();
        }

        public AnalizLexico(string sigma, AFD AutFD)
        {
            setSigma(sigma);
            AutomataFD = AutFD;
        }

        public AnalizLexico GetAnalizLexico()
        {
            AnalizLexico edoActualAnaliz = new AnalizLexico();
            edoActualAnaliz.charActual = charActual;
            edoActualAnaliz.edoActual = edoActual;
            edoActualAnaliz.edoTransicion = edoTransicion;
            edoActualAnaliz.finLexema = finLexema;
            edoActualAnaliz.iCharAct = iCharAct;
            edoActualAnaliz.iniLexema = iniLexema;
            edoActualAnaliz.Lexema = Lexema;
            edoActualAnaliz.pasEdoAccept = pasEdoAccept;
            edoActualAnaliz.token = token;
            edoActualAnaliz.Pila = Pila;
            return edoActualAnaliz;
        }

        public bool SetAnalizLexico(AnalizLexico e)
        {
            charActual = e.charActual;
            edoActual = e.edoActual;
            edoTransicion = e.edoTransicion;
            finLexema = e.finLexema;
            iCharAct = e.iCharAct;
            iniLexema = e.iniLexema;
            Lexema = e.Lexema;
            pasEdoAccept = e.pasEdoAccept;
            token = e.token;
            Pila = e.Pila;
            return true;
        }


        public string cadenaXAnalizar()
        {
            return cadSigma.Substring(iCharAct, cadSigma.Length - iCharAct);
        }

        public int yylex()
        {
            while (true)
            {
                Pila.Push(iCharAct);
                if (iCharAct >= cadSigma.Length)
                {
                    Lexema = "";
                    return SimbolosEspeciales.OVERSIZED;
                }
                iniLexema = iCharAct;
                edoActual = 0;
                pasEdoAccept = false;
                finLexema = -1;
                token = -1;

                while (iCharAct < cadSigma.Length)
                {
                    //MessageBox.Show("iCharAct es "+iCharAct+" y longitud es "+cadSigma.Length);
                    charActual = cadSigma[iCharAct];
                    edoTransicion = AutomataFD.TablaAFD[edoActual, charActual];
                    if (edoTransicion != -1)
                    {
                        if (AutomataFD.TablaAFD[edoTransicion, 256] != -1)
                        {
                            pasEdoAccept = true;
                            token = AutomataFD.TablaAFD[edoTransicion, 256];
                            finLexema = iCharAct;
                        }
                        iCharAct++;
                        edoActual = edoTransicion;
                        continue;
                    }
                    break;
                }

                if (!pasEdoAccept)
                {
                    iCharAct = iniLexema + 1;
                    Lexema = cadSigma.Substring(iniLexema, 1);
                    token = SimbolosEspeciales.ERROR;
                    return token;
                }

                Lexema = cadSigma.Substring(iniLexema, finLexema - iniLexema + 1);
                iCharAct = finLexema + 1;
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
            iCharAct = Pila.Pop();
            return true;
        }
    }
}
