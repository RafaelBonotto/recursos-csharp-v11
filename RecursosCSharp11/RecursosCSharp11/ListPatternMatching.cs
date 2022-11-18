namespace RecursosCSharp11
{
    public class ListPatternMatching
    {
        //Padrão Discard
        public bool VerificaPrimeiraPosicao()
        {
            bool result = false;
            int[] numeros = { 1, 2, 3};
            result = numeros is [1, _, _];

            return result; // Resultado = true (Primeira posição número 1 encontrada)
        }

        //Padrão Discard
        public bool VerificaSegundaPosicao()
        {
            bool result = false;
            int[] numeros = { 1, 2, 3 };
            result = numeros is [_, 3, _];

            return result; // Resultado = false (Segunda posição para número 3 não encontrada)
        }

        //Padrão Discard
        public bool VerificaPosicoesAleatorias()
        {
            bool result = false;
            int[] numeros = { 1, 2, 3, 4, 5 };
            result = numeros is [_, 3, _, 5, _];

            return result; // Resultado = false (Tamanho do array correspondente porém posições dos números não encontradas)
        }

        //Padrão Range
        public bool VerificaUltimaPosicao()
        {
            bool result = false;
            int[] numeros = { 1, 2, 3, 4, 5 };
            result = numeros is [.., 5];

            return result; // Resultado = true (Sem verificar o tamanho e as demais posições, verifica somente a ultima)
        }

        //Padrão Range e Discard
        public bool VerificaPenultimaPosicao()
        {
            bool result = false;
            int[] numeros = { 1, 2, 3, 4, 5 };
            result = numeros is [.., 4, _];

            return result; // Resultado = true (Sem verificar o tamanho e as primeiras posições, verifica somente a penultima)
        }

        //Padrão Range
        public bool VerificaPrimeiraEUltimaPosicao()
        {
            bool result = false;
            int[] numeros = { 1, 2, 3, 4, 5 };
            result = numeros is [1, .., 5];

            return result; // Resultado = true (Sem verificar o tamanho, verifica somente a primeira e a ultima posição)
        }

        //Padrão Var
        public string VerificaPenultimoEUltimoComPadraoVar()
        {
            int[] numeros = { 1, 2, 3, 4, 5 };

            if (numeros is [.., var penultimo, var ultimo])
            {
                return $"Penultimo: {penultimo} e Ultimo: {ultimo}"; // Resultado (penultimo = 4 e ultimo = 5)
            }
            else if (numeros is [var primeiro, var segundo])
            {
                return $"Primeiro: {primeiro} e Segundo: {segundo}"; // Não entra nesse bloco pois o padrão não corresponde
            }
            else
            {
                return "O padrão não corresponde";
            }
        }
    }
}
