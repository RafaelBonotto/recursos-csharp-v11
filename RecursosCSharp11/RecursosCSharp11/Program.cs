using RecursosCSharp11;

var rawStringLiteralExemplo = new RawStringLiteral();

Console.WriteLine("Teste 1 raw string literal: " + rawStringLiteralExemplo.StringLiteralExemplo1);
Console.WriteLine("Teste 2 raw string literal: " + rawStringLiteralExemplo.StringLiteralExemplo2);
Console.WriteLine("Teste 3 raw string literal: " + rawStringLiteralExemplo.StringLiteralExemplo3);
Console.WriteLine("Teste 4 raw string literal: " + rawStringLiteralExemplo.StringLiteralExemplo4);
Console.WriteLine("=============================================================");
var listPattern = new ListPatternMatching();

var teste1 = listPattern.VerificaPrimeiraPosicao();
var teste2 = listPattern.VerificaSegundaPosicao();
var teste3 = listPattern.VerificaPosicoesAleatorias();

Console.WriteLine("Teste 1 list pattern: " + teste1);
Console.WriteLine("Teste 2 list pattern: " + teste2);
Console.WriteLine("Teste 3 list pattern: " + teste3);
