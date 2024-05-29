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
        public float res;
        public String ExprPost;
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

        bool Asign()
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
                        this.result = v;
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
            if (MATRIX())
            {
                return true;
            }
            return false;
        }

        bool MATRIX()
        {
            int numRows;
            int token;
            token = Lexic.yylex();
            if (token == 90)
            {
                numRows = 0;
                if (ROWS(ref numRows))
                {
                    numFilas = numRows;
                    token = Lexic.yylex();
                    if (token == 100)
                        return true;
                }
            }
            return false;
        }

        bool ROWS(ref int numRows)
        {
            int numCol = 0;
            if (ROW(ref numCol))
                if (ROWSp(ref numRows))
                    return true;
            return false;
        }

        bool ROWSp(ref int numRows)
        {
            int numCol = 0;
            if (ROW(ref numCol))
            {
                if (ROWSp(ref numRows))
                    return true;
                return false;
            }
            return true;
        }

        bool ROW(ref int numCol)
        {
            int token;
            token = Lexic.yylex();
            if (token == 90)
            {
                if (LNUM(ref numCol))
                {
                    token = Lexic.yylex();
                    if (token == 100)
                        return true;
                }
            }
            return false;
        }

        bool LNUM(ref int numCol)
        {
            int token;
            token = Lexic.yylex();
            if (token == 120)
            {
                numCol++;
                if (LNUMp(ref numCol))
                    return true;
            }
            return false;
        }

        bool LNUMp(ref int numCol)
        {
            int token;
            token = Lexic.yylex();
            if (token == 110)
            {
                token = Lexic.yylex();
                if (token == 120)
                {
                    numCol++;
                    if (LNUMp(ref numCol))
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
