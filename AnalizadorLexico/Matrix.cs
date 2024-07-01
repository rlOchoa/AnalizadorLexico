using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorLexico
{
    internal class Matrix
    {
        String Matriz;
        public double res;
        public string ExprPost;
        public AnalizLexico Lexic;

        public Matrix(string sigma, AFD afd)
        {
            Matriz = sigma;
            Lexic = new AnalizLexico(sigma, afd);
        }

        public void SetExpression(string sigma)
        {
            Matriz = sigma;
            Lexic.setSigma(sigma);
        }
        public bool iniEval()
        {
            return Asign(ref res, ref ExprPost);
        }
        public bool Asign(ref double v,ref string Postfijo)
        {
            int Token;
            Token = Lexic.yylex();

            if (Token == 10)
            {
                Postfijo = Postfijo + Lexic.Lexema + " = ";
                Token = Lexic.yylex();
                if (Token == 20)
                    if (E(ref v, ref Postfijo))
                    {
                        return true;
                    }
            }
            return false;
        }

        bool E(ref double v, ref string post)
        {
            if (T(ref v, ref post))
                if (Ep(ref v, ref post))
                    return true;
            return false;
        }

        bool Ep(ref double v, ref string post)
        {
            double v1 = 0;
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

        bool T(ref double v, ref string post)
        {
            if (F(ref v, ref post))
                if (Tp(ref v, ref post))
                    return true;
            return false;
        }

        bool Tp(ref double v, ref string post)
        {
            double v1 = 0;
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

        bool F(ref double v, ref string post)
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
                    post = post + " " + Lexic.Lexema;
                    return true;
                case 90:
                    string post1 = "";
                    if(ROWS(ref v,ref post1))
                    {
                        token= Lexic.yylex();
                        if (token == 100)
                        {
                            post = post + " " + post1 + " Matriz ";
                            return true;
                        }
                    }
                    break;
                case 120:
                    v = double.Parse(Lexic.Lexema);
                    post = Lexic.Lexema;
                    return true;
            }
            return false;
        }

        bool ROWS(ref double v, ref string post)
        {
            
            if (ROW(ref v,ref post))
                if (ROWSp(ref v,ref post))
                    return true;
            return false;
        }

        bool ROWSp(ref double v, ref string post)
        {
            int token = Lexic.yylex();
            if(token == 110)
            {
                if (ROW(ref v, ref post))
                {
                    if (ROWSp(ref v, ref post))
                    {
                        return true;
                    }
                    return false;
                }
            }
            Lexic.Undotoken();
            return true;
        }

        bool ROW(ref double v, ref string post)
        {
            int token;
            string post1 = "";
            token = Lexic.yylex();
            if (token == 90)
            {
                if (LNUM(ref v, ref post1))
                {
                    token = Lexic.yylex();
                    if (token == 100)
                    {
                        post = post + " " + post1 + " Renglon ";
                        return true;
                    }
                }
            }
            return false;
        }

        bool LNUM(ref double v, ref string post)
        {
            int token;
            token = Lexic.yylex();
            if (token == 120)
            {
                post = post + " " + Lexic.Lexema + " , ";
                if (LNUMp(ref v, ref post))
                    return true;
            }
            return false;
        }

        bool LNUMp(ref double v, ref string post)
        {
            int token;
            token = Lexic.yylex();
            if (token == 110)
            {
                token = Lexic.yylex();
                if (token == 120)
                {
                    post = post + " " + Lexic.Lexema + " , ";
                    if (LNUMp(ref v, ref post))
                    {
                        
                        return true;
                    }
                }
                return false;
            }
            Lexic.Undotoken();
            return true;
        }
    }
}
