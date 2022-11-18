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

        public bool VerificaPosicoesAleatorias()
        {
            bool result = false;
            int[] numeros = { 1, 2, 3, 4, 5 };
            result = numeros is [_, 3, _, 5, _];

            return result; // Resultado = false (Tamanho do array correspondente porém posições dos números não encontradas)
        }

        public bool VerificaUltimaPosicao()
        {
            bool result = false;
            int[] numeros = { 1, 2, 3, 4, 5 };
            result = numeros is [.., 5];

            return result; // Resultado = true (Sem verificar o tamanho e as demais posições, verifica somente a ultima)
        }

        public bool VerificaPenultimaPosicao()
        {
            bool result = false;
            int[] numeros = { 1, 2, 3, 4, 5 };
            result = numeros is [.., 4, _];

            return result; // Resultado = true (Sem verificar o tamanho e as primeiras posições, verifica somente a penultima)
        }

        public bool VerificaPrimeiraEUltimaPosicao()
        {
            bool result = false;
            int[] numeros = { 1, 2, 3, 4, 5 };
            result = numeros is [1, .., 5];

            return result; // Resultado = true (Sem verificar o tamanho, verifica somente a primeira e a ultima posição)
        }
    }
}
