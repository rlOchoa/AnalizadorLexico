﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorLexico
{
    public class Estado
    {
        //Atributos de Estado
        static int contadorIdEstado = 0;
        private int idEstado1; // ya
        private bool edoAccept1; // ya
        private int token1; // ya
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

        public HashSet<Transicion> Trans { get => trans1; set => trans1 = value; }
    }
}
