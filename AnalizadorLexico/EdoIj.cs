using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorLexico
{
    public class EdoIj
    {
        //atributos
        public int j;
        public HashSet<Estado> conIj;
        public int[] transicionesAFD = new int[257];

        public EdoIj()
        {
            j = -1;
            conIj = new HashSet<Estado>();
            conIj.Clear();
            for (int k = 0; k < 257; k++)
            {
                transicionesAFD[k] = -1;
            }
        }
    }
}
