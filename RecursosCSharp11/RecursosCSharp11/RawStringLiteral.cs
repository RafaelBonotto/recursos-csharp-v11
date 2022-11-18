namespace RecursosCSharp11
{
    public class RawStringLiteral
    {
        public RawStringLiteral()
        {
            this.StringLiteralExemplo3 = $$"""
                                                 {
                                                    "id" : "{{Id}}",
                                                    "nome" : "{{Nome}}",
                                                    "pais" : "{{Pais}}"
                                                 }
                                              """;
        }

        public int Id = 10;

        public string Nome = "Rafael";

        public string Pais = "Brasil";
        
        public string StringLiteralExemplo1 = """ Isto é uma "String literal" """;

        public string StringLiteralExemplo2 = $$""" {10 + 20} = {{10 + 20}} """;

        public string StringLiteralExemplo3 = string.Empty;

        public string StringLiteralExemplo4 = """
                                                 {
                                                    "id" : 1,
                                                    "nome" : "Rafael",
                                                    "pais" : "Brasil"
                                                 }
                                              """;

        public string Exemplo1()
            => this.StringLiteralExemplo1; // Resultado: Isto é uma "String literal"

        public string Exemplo2()
            => this.StringLiteralExemplo2; // Resultado: {10 + 20} = 30

        public string Exemplo3()
            => this.StringLiteralExemplo3; /* Resultado: {
                                                    "id" : 10,
                                                    "nome" : "Rafael",
                                                    "pais" : "Brasil"
                                                 } */
        public string Exemplo4()
            => this.StringLiteralExemplo4; /* Resultado: {
                                                    "id" : 1,
                                                    "nome" : "Rafael",
                                                    "pais" : "Brasil"
                                                 } */

    }
}
