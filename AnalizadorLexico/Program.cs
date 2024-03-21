using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                Edo EdoActual = EdoInicial;

                foreach (char simbolo in cadena)
                {
                    Transicion transicion = EdoActual.Transiciones.FirstOrDefault(t => t.Simbolo == simbolo);

                    if (transicion == null)
                    {
                        // No hay transición para este símbolo
                        return false;
                    }

                    EdoActual = transicion.EdoSiguiente;
                }

                // La cadena es aceptada si terminamos en un Edo final
                return EdoActual.EsEdoFinal;
            }
        }


    }
}
}
