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
            /* Resultado: {
                            "id" : 10,
                            "nome" : "Rafael",
                            "pais" : "Brasil"
                          } */
        }

        public int Id { get; set; } = 10;

        public string Nome { get; set; } = "Rafael";

        public string Pais { get; set; } = "Brasil";
        
        public string StringLiteralExemplo1 { get; set; } = """ Isto é uma "String literal" """; // Resultado: Isto é uma "String literal"

        public string StringLiteralExemplo2 { get; set; } = $$""" {10 + 20} = {{10 + 20}} """; // Resultado: {10 + 20} = 30

        public string StringLiteralExemplo3 { get; set; } = string.Empty;

        public string StringLiteralExemplo4 { get; set; } = """
                                                                {
                                                                    "id" : 1,
                                                                    "nome" : "Rafael",
                                                                    "pais" : "Brasil"
                                                                }
                                                            """;
        /* Resultado: {
                           "id" : 1,
                           "nome" : "Rafael",
                           "pais" : "Brasil"
                      } */
    }
}
