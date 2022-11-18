namespace RecursosCSharp11
{
    public class ListPatternMatching
    {
        public bool VerificaPrimeiraPosicao()
        {
            bool result = false;
            int[] numeros = { 1, 2, 3};
            result = numeros is [1, _, _];

            return result; // Resultado = true (Primeira posição numero 1)
        }
    }
}
