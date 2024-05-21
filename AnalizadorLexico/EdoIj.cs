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
        public int j { get; set; };
        public HashSet<Estado> conIj { get; set; };
        public int[] transicionesAFD { get; set; };

        public EdoIj()
        {
            j = -1;
            conIj = new HashSet<Estado>();
            conIj.Clear();
            transicionesAFD = new int[257];
            for (int k = 0; k < 257; k++)
            {
                transicionesAFD[k] = -1;
            }
        }
    }
}
