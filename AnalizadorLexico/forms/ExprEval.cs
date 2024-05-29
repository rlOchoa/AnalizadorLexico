using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorLexico.forms
{
    class ExprEval
    {
        String Expresion;
        public float Resultado;
        public String ExprPost;
        public AnalizLexico Lexic;

        public ExprEval(string sigma, AFD afd)
        {
            Expresion = sigma;
            Lexic = new AnalizLexico(sigma, afd);
        }

        /* public ExprEval(string sigma, string FileAFD, int IdentifAFD)
        {
            Expresion = sigma;
            Lexic = new AnalizLexico(Expresion, FileAFD, IdentifAFD);
        }
            
        public ExprEval(string FileAFD, int IdentifAFD)
        {
            L = new AnalizLexico(FileAFD, IdentifAFD);
        }
        */

        public void SetExpression(string sigma)
        {
            Expresion = sigma;
            Lexic.setSigma(sigma);
        }

        public bool IniEval()
        {
            int Token;
            float v = 0;
            string postfijo = "";
            if (E(ref v, ref postfijo))
            {
                Token = Lexic.yylex();
                if (Token == 0)
                {
                    this.Resultado = v;
                    this.ExprPost = postfijo;
                    return true;
                }
            }
            return false;
        }

        bool E(ref float v, ref string post)
        {
            if (T(ref v, ref postfijo))
                if (Ep(ref v, ref postfijo))
                    return true;
            return false;
        }

        bool Ep(ref float v, ref string post)
        {
            int Token;
            float v1 = 0;
            string post1 = "";
            Token = Lexic.yylex();
            if (Token == 10 || Token == 20)
            {
                if (T(ref v1, ref post1))
                {
                    v = v + (Token == 10 ? v1 : -v1);
                    post = post + " " + post1 + " " + (Token == 10 ? "+" : "-");
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
            if (T(ref v, ref post))
                if (Tp(ref v, ref post))
                    return true;
            return false;
        }

        bool Tp(ref float v, ref string post)
        {
            int Token;
            float v1 = 0;
            string post1 = "";
            Token = Lexic.yylex();
            if (Token == 30 || Token == 40)
            {
                if (F(ref v1, ref post1))
                {
                    v = v * (Token == 30 ? v1 : 1 / v1);
                    post = post + " " + post1 + " " + (Token == 30 ? "*" : "/");
                    if (Tp(ref v, ref post))
                        return true;
                }
                return false;
            }
            Lexic.Undotoken();
            return true;
        }

        bool F(ref float v, ref string post)
        {
            int Token;
            Token = Lexic.yylex();
            switch (Token)
            {
                case 50:
                    if (E(ref v, ref post))
                    {
                        Token = Lexic.yylex();
                        if (Token == 60)
                            return true;
                    }
                    break;
                case 70:
                    v = float.Parse(Lexic.Lexema);
                    post = Lexic.Lexema;
                    return true;
            }
            return false;
        }
    }
}
