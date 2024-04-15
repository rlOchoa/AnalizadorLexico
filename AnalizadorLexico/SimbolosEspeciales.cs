using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorLexico
{
    public class SimbolosEspeciales
    {
        public static char EPSILON = (char)5;
        public static char FIN = (char)0;
        public static int ERROR = 20000;
        public static int OMITIR = 20001;
        public static int OVERSIZED = 20002;
        public static int TODOOK = 0;
    }
}
