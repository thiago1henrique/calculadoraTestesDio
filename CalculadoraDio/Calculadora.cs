﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraDio
{
    public class Calculadora
    {
        private List<string> listaHistorico;
        public Calculadora()
        {
            listaHistorico = new List<string>();
        }
        public int Somar(int val1, int val2)
        {
            int res = val1 + val2;
            listaHistorico.Insert(0, "Resultado: " + res);
            return res;
        }

        public int Subtrair(int val1, int val2)
        {
            int res = val1 - val2;
            listaHistorico.Insert(0, "Resultado: " + res);
            return res;
        }

        public int Dividir(int val1, int val2)
        {
            int res = val1 / val2;
            listaHistorico.Insert(0, "Resultado: " + res);
            return res;
        }

        public int Multiplicar(int val1, int val2)
        {
            int res = val1 * val2;
            listaHistorico.Insert(0, "Resultado: " + res);
            return res;
        }

        public List<string> historico()
        {
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
            return listaHistorico;
        }
    }
}
