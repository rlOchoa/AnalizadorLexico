using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorLexico
{
    class ExprEval
    {
        String Expresion;
        public double Resultado;
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
            double v = 0;
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

        bool E(ref double v, ref string post)
        {
            if (T(ref v, ref post))
                if (Ep(ref v, ref post))
                    return true;
            return false;
        }

        bool Ep(ref double v, ref string post)
        {
            int Token;
            double v1 = 0;
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

        bool T(ref double v, ref string post)
        {
            if (P(ref v, ref post))
                if (Tp(ref v, ref post))
                    return true;
            return false;
        }

        bool Tp(ref double v, ref string post)
        {
            int Token;
            double v1 = 0;
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

        bool P(ref double v, ref string post)
        {
            if(F(ref v, ref post))
                if(Pp(ref v, ref post))
                    return true;
            return false;
        }

        bool Pp(ref double v, ref string post)
        {
            int Token;
            double v1 = 0;
            string post1 = "";
            Token = Lexic.yylex();
            if(Token == 50)
            {
                if (F(ref v1, ref post1)){
                    v = Math.Pow(v, v1);
                    post = post + " " + post1 + " " + "^";
                    if (Pp(ref v , ref post))
                        return true;
                }
            }
            Lexic.Undotoken();
            return true;
        }

        bool F(ref double v, ref string post)
        {
            int Token;
            Token = Lexic.yylex();
            switch (Token)
            {
                case 60: //SIN(E)
                    Token = Lexic.yylex();
                    if(Token == 120)
                    {
                        if (E(ref v, ref post))
                        {
                            Token = Lexic.yylex();
                            if (Token == 130)
                            {
                                v = Math.Sin(v);
                                post = post + " " + "SIN";
                                return true;
                            }
                        }
                    }
                    break;
                case 70: //COS(E)
                    Token = Lexic.yylex();
                    if (Token == 120)
                    {
                        if (E(ref v, ref post))
                        {
                            Token = Lexic.yylex();
                            if (Token == 130)
                            {
                                v = Math.Cos(v);
                                post = post + " " + "COS";
                                return true;
                            }
                        }
                    }
                    break;
                case 80: //SIN(E)
                    Token = Lexic.yylex();
                    if (Token == 120)
                    {
                        if (E(ref v, ref post))
                        {
                            Token = Lexic.yylex();
                            if (Token == 130)
                            {
                                v = Math.Tan(v);
                                post = post + " " + "TAN";
                                return true;
                            }
                        }
                    }
                    break;
                case 90: //LOG(E)
                    Token = Lexic.yylex();
                    if (Token == 120)
                    {
                        if (E(ref v, ref post))
                        {
                            Token = Lexic.yylex();
                            if (Token == 130)
                            {
                                v = Math.Log10(v);
                                post = post + " " + "LOG";
                                return true;
                            }
                        }
                    }
                    break;
                case 100: //LN(E)
                    Token = Lexic.yylex();
                    if (Token == 120)
                    {
                        if (E(ref v, ref post))
                        {
                            Token = Lexic.yylex();
                            if (Token == 130)
                            {
                                v = Math.Log(v);
                                post = post + " " + "SIN";
                                return true;
                            }
                        }
                    }
                    break;
                case 120://(E)
                    if (E(ref v, ref post))
                    {
                        Token = Lexic.yylex();
                        if (Token == 130)
                            return true;
                    }
                    break;
                case 110://NUM
                    v = double.Parse(Lexic.Lexema);
                    post = Lexic.Lexema;
                    return true;
            }
            return false;
        }
    }
}
