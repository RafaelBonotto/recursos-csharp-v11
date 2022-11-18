﻿namespace RecursosCSharp11
{
    public class ListPatternMatching
    {
        public bool VerificaPrimeiraPosicao()
        {
            bool result = false;
            int[] numeros = { 1, 2, 3};
            result = numeros is [1, _, _];

            return result; // Resultado = true (Primeira posição número 1 encontrada)
        }

        public bool VerificaSegundaPosicao()
        {
            bool result = false;
            int[] numeros = { 1, 2, 3 };
            result = numeros is [_, 3, _];

            return result; // Resultado = false (Segunda posição para número 3 não encontrada)
        }
    }
}
