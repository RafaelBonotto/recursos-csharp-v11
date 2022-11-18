using RecursosCSharp11;

var rawStringLiteralExemplo = new RawStringLiteral();

Console.WriteLine("Teste 1 raw string literal: " + rawStringLiteralExemplo.StringLiteralExemplo1);
Console.WriteLine("Teste 2 raw string literal: " + rawStringLiteralExemplo.StringLiteralExemplo2);
Console.WriteLine("Teste 3 raw string literal: " + rawStringLiteralExemplo.StringLiteralExemplo3);
Console.WriteLine("Teste 4 raw string literal: " + rawStringLiteralExemplo.StringLiteralExemplo4);
Console.WriteLine("=============================================================");
var listPattern = new ListPatternMatching();

var teste1 = listPattern.VerificaPrimeiraPosicao();
Console.WriteLine(teste1);
