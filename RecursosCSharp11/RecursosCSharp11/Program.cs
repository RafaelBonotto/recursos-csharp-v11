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
var teste4 = listPattern.VerificaUltimaPosicao();
var teste5 = listPattern.VerificaPenultimaPosicao();
var teste6 = listPattern.VerificaPrimeiraEUltimaPosicao();
var teste7 = listPattern.VerificaPenultimoEUltimoComPadraoVar();

Console.WriteLine("Teste 1 list pattern: " + teste1);
Console.WriteLine("Teste 2 list pattern: " + teste2);
Console.WriteLine("Teste 3 list pattern: " + teste3);
Console.WriteLine("Teste 4 list pattern: " + teste4);
Console.WriteLine("Teste 5 list pattern: " + teste5);
Console.WriteLine("Teste 6 list pattern: " + teste6);
Console.WriteLine("Teste 7 list pattern: " + teste7);
