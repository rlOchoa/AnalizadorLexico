using AnalizadorLexico.forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorLexico
{
    internal class ER_AFN
    {
        string regex;
        public AFN result;
        public AnalizLexico Lexic;

        public ER_AFN(string sigma, AFD autAFD)
        {
            regex = sigma;
            Lexic = new AnalizLexico(regex, autAFD);
        }

        public void setExpresion(string sigma)
        {
            regex = sigma;
            Lexic.setSigma(sigma);
        }

        public bool iniConv()
        {
            int token;
            AFN f = new AFN();
            if (E(ref f))
            {
                token = Lexic.yylex();
                if (token == SimbolosEspeciales.FIN)
                {
                    result = f;
                    return true;
                }
            }
            return false;
        }

        private bool E(ref AFN f)
        {
            if (T(ref f))
                if (Ep(ref f))
                    return true;
            return false;
        }

        private bool Ep(ref AFN f)
        {
            int token = Lexic.yylex();
            AFN f2 = new AFN();

            if (token == 10)
            {
                if (T(ref f2))
                {
                    f.unirAFNs(f2);
                    if (Ep(ref f))
                        return true;
                }
                return false;
            }
            Lexic.Undotoken();
            return true;
        }

        private bool T(ref AFN f)
        {
            if (C(ref f))
                if (Tp(ref f))
                    return true;
            return false;
        }
        private bool Tp(ref AFN f)
        {
            int token = Lexic.yylex();
            AFN f2 = new AFN();

            if (token == 20)
            {
                if (C(ref f2))
                {
                    f.concatAFNs(f2);
                    if (Tp(ref f))
                        return true;
                }
                return false;
            }
            Lexic.Undotoken();
            return true;
        }

        private bool C(ref AFN f)
        {
            if (F(ref f))
                if (Cp(ref f))
                    return true;
            return false;
        }
        private bool Cp(ref AFN f)
        {
            int token = Lexic.yylex();

            switch (token)
            {
                case 30:
                    f.cerraduraPos();
                    if (Cp(ref f))
                        return true;
                    return false;
                case 40:
                    f.cerraduraKleene();
                    if (Cp(ref f))
                        return true;
                    return false;
                case 50:
                    f.operacionOpcional();
                    if (Cp(ref f))
                        return true;
                    return false;
            }
            Lexic.Undotoken();
            return true;
        }

        private bool F(ref AFN f)
        {
            int token = Lexic.yylex();
            char simb1, simb2;
            switch (token)
            {
                case 60:
                    if (E(ref f))
                    {
                        token = Lexic.yylex();
                        if (token == 70)
                            return true;
                    }
                    return false;
                case 80:
                    token = Lexic.yylex();

                    if (token == 110)
                    {
                        simb1 = Lexic.Lexema[0];
                        token = Lexic.yylex();
                        if (token == 100)
                        {
                            token = Lexic.yylex();
                            if (token == 110)
                            {
                                simb2 = Lexic.Lexema[0];
                                token = Lexic.yylex();
                                if (token == 90)
                                {
                                    f.crearAFNBasico(simb1, simb2);
                                    return true;
                                }
                            }
                        }
                    }
                    return false;
                case 110:
                    simb1 = Lexic.Lexema[0];
                    f.crearAFNBasico(simb1);
                    return true;
            }
            return false;
        }
    }
}