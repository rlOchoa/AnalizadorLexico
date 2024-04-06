using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorLexico
{
    internal class Estado
    {
        //Atributos de Estado
        static int contadorIdEstado = 0;
        private int idEstado1;
        private bool edoAccept1;
        private int token1;
        private HashSet<Transicion> trans1 = new HashSet<Transicion>();

        //Constructor de Estado
        public Estado()
        {
            edoAccept1 = false;
            token1 = -1;
            idEstado1 = contadorIdEstado++;
            trans1.Clear();
        }

        //Metodos GET y SET
        public int getIdEstado()
        {
            return idEstado1;
        }

        public void setIdEstado(int idEstado)
        {
            idEstado1 = idEstado;
        }

        public bool getEdoAccept() 
        {
            return edoAccept1;
        }

        public void setEdoAccept(bool edoAccept)
        {
            edoAccept1 = edoAccept;
        }

        public int getToken()
        {
            return token1;
        }

        public void setToken(int token)
        {
            token1 = token;
        }

        public HashSet<Transicion> getTrans()
        {
            return trans1;
        }

        public void setTrans(HashSet<Transicion> trans)
        {
            trans1 = trans;
        }
    }
}
