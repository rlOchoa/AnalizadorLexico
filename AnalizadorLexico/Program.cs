using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AnalizadorLexico.Program;

namespace AnalizadorLexico
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            public class Edo
        {
            public bool EsEdoFinal { get; set; }
            public List<Transicion> Transiciones { get; set; }

            public Edo()
            {
                Transiciones = new List<Transicion>();
            }
        }

        public class Transicion
        {
            public char Simbolo { get; set; }
            public Edo EdoSiguiente { get; set; }
        }

        public class AFN
        {
            public Edo EdoInicial { get; set; }

            public AFN()
            {
                // Crear los Edos
                Edo Edo1 = new Edo();
                Edo Edo2 = new Edo { EsEdoFinal = true };

                // Crear las transiciones
                Transicion transicion1 = new Transicion { Simbolo = 'a', EdoSiguiente = Edo2 };
                Transicion transicion2 = new Transicion { Simbolo = 'b', EdoSiguiente = Edo1 };

                // Añadir las transiciones a los Edos
                Edo1.Transiciones.Add(transicion1);
                Edo2.Transiciones.Add(transicion2);

                // Definir el Edo inicial
                EdoInicial = Edo1;
            }

            public bool ProcesarCadena(string cadena)
            {
                Edo edoActual = EdoInicial;

                foreach (char simbolo in cadena)
                {
                    Transicion transicion = edoActual.Transiciones.FirstOrDefault(t => t.Simbolo == simbolo);

                    if (transicion == null)
                    {
                        // No hay transición para este símbolo
                        return false;
                    }

                    edoActual = transicion.EdoSiguiente;
                }

                // La cadena es aceptada si terminamos en un Edo final
                return edoActual.EsEdoFinal;
            }
        }



    }
}
    class AnalizLexico
    {
        int token, edoActual, edoTransicion;
        private string cadSigma;
        public string Lexema;
        private bool pasEdoAccept;
        private int iniLexema, finLexema, iChar;
        private char charActual;
        Stack<int> Pila = new Stack<int>();
        private AFD AutomFD;

        public AnalizLexico()
        {
            cadSigma = "";
            pasEdoAccept = false;
            iniLexema = finLexema = 1;
            iChar = -1;
            token = -1;
            Pila.Clear();
            AutomFD = null;
        }

        public AnalizLexico(string cadSigma, string archivoAFD, int idAFD)
        {
            AutomFD = new AFD();
            cadSigma = "";
            pasEdoAccept = false;
            iniLexema = 0;
            finLexema = -1;
            iChar = 0;
            token = -1;
            Pila.Clear();
            AutomFD.LeerAFDdeArchivo(archivoAFD, idAFD);
        }

        public AnalizLexico(string cadSigma, string archivoAFD)
        {
            AutomFD = new AFD();
            cadSigma = "";
            pasEdoAccept = false;
            iniLexema = 0;
            finLexema = -1;
            iChar = 0;
            token = -1;
            Pila.Clear();
            AutomFD.LeerAFDdeArchivo(archivoAFD, -1);
        }

        public AnalizLexico(string cadSigma, int idADF)
        {
            AutomFD = new AFD();
            cadSigma = "";
            pasEdoAccept = false;
            iniLexema = 0;
            finLexema = -1;
            iChar = 0; //Index character
            token = -1;
            Pila.Clear();
            AutomFD.LeerAFDdeArchivo(archivoAFD, -1);
        }

        public AnalizLexico(string cadSigma, AFD AutFD)
        {
            cadSigma = "";
            pasEdoAccept = false;
            iniLexema = 0;
            finLexema = -1;
            iChar = 0;
            token = -1;
            Pila.Clear();
            AutomFD = AutFD;
        }

        public ClassEstadoAnalizLexico GetEdoAnalizLexico()
        {
            ClassEstadoAnalizLexico edoActualAnaliz = new ClassEstadoAnalizLexico();
            edoActualAnaliz.token = token;
            edoActualAnaliz.edoActual = edoActual;
            edoActualAnaliz.edoTransicion = edoTransicion;
            edoActualAnaliz.Pila = Pila;
            edoActualAnaliz.Lexema = Lexema;
            edoActualAnaliz.iniLexema = iniLexema;
            edoActualAnaliz.finLexema = finLexema;
            edoActualAnaliz.iChar = iChar;
            edoActualAnaliz.charActual = charActual;
            edoActualAnaliz.pasEdoAccept = pasEdoAccept;
            return edoActualAnaliz;
        }

        public bool SetEdoAnalizLexico(ClassEstadoAnalizLexico e)
        {
            token = e.token;
            edoActual = e.edoActual;
            edoTransicion = e.edoTransicion;
            Pila = e.Pila;
            Lexema = e.Lexema;
            iniLexema = e.iniLexema;
            finLexema = e.finLexema;
            iChar = e.iChar;
            charActual = e.charActual;
            pasEdoAccept = e.pasEdoAccept;
            return true;
        }

        public void setsigma(string sigma)
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
                    edoTransicion = AutomFD.TablaAFD[edoActual, charActual];
                    if (edoTransicion != -1)
                    {
                        if (AutomFD.TablaAFD[edoTransicion, 256] != -1)
                        {
                            pasEdoAccept = true;
                            token = AutomFD.TablaAFD[edoTransicion, 256];
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