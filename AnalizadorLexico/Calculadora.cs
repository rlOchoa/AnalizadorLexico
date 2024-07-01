using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorLexico
{
    internal class Calculadora
    {
        public String expre;
        public float res;
        public String ExprPost;
        public AnalizLexico Lexic;

        public Calculadora(string sigma, AFD afd)
        {
            expre = sigma;
            Lexic = new AnalizLexico(sigma, afd);
        }

        /*
         

        */

        public void SetExpression(string sigma)
        {
            expre = sigma;
            Lexic.setSigma(sigma);
        }

        public bool Asign()
        {
            int Token;
            float v = 0;
            string Postfijo = "";
            Token = Lexic.yylex();

            if (Token == 10)
            {
                Token = Lexic.yylex();
                if (Token == 20)
                    if (E(ref v, ref Postfijo))
                    {
                        this.res = v;
                        this.ExprPost = Postfijo;
                        return true;
                    }
            }
            return false;
        }

        bool E(ref float v, ref string post)
        {
            if (T(ref v, ref post))
                if (Ep(ref v, ref post))
                    return true;
            return false;
        }

        bool Ep(ref float v, ref string post)
        {
            float v1 = 0;
            int token;
            string post1 = "";
            token = Lexic.yylex();
            if (token == 30 || token == 40)
            {
                if (T(ref v1, ref post1))
                {
                    v = v + ((token == 30) ? v1 : -v1);
                    post = post + " " + post1 + " " + (token == 30 ? "+" : "-");
                    if (Ep(ref v, ref post))
                        return true;
                }
                return false;
            }
            Lexic.Undotoken();
            return true;
        }

        bool T(ref float v, ref string post)
        {
            if (F(ref v, ref post))
                if (Tp(ref v, ref post))
                    return true;
            return false;
        }

        bool Tp(ref float v, ref string post)
        {
            float v1 = 0;
            int token;
            string post1 = "";
            token = Lexic.yylex();
            if (token == 50 || token == 60)
            {
                if (T(ref v1, ref post1))
                {
                    v = v * ((token == 50) ? v1 : 1 / v1);
                    post = post + " " + post1 + " " + (token == 50 ? "*" : "/");
                    if (Ep(ref v, ref post))
                        return true;
                }
                return false;
            }
            Lexic.Undotoken();
            return true;
        }

        bool F(ref float v, ref string post)
        {
            int token;
            token = Lexic.yylex();
            switch (token)
            {
                case 70:
                    if (E(ref v, ref post))
                    {
                        token = Lexic.yylex();
                        if (token == 80)
                            return true;
                    }
                    return false;
                case 10:
                    return true;
            }
            return false;
        }
    }
}
