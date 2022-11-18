namespace RecursosCSharp11
{
    public class RawStringLiteral
    {
        public string StringLiteralExemplo1 = """ Isto é uma "String literal" """;

        public string StringLiteralExemplo2 = $$""" {10 + 20} = {{10 + 20}} """;

        public string StringLiteralExemplo3 = $$""" Isto é uma "String literal" """;

        public string StringLiteralExemplo4 = """
                                                 {
                                                    "id" : 1,
                                                    "nome" : "Rafael",
                                                    "pais" : "Brasil"
                                                 }
                                              """;
    }
}
