using ProcessadorDeTexto.Processors;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        string texto = "Vai dar o 10 pro pai né?";

        TextoProcessor processadorMaiuscula = new TudoMaiuscula();
        string resultadoMaiuscula = processadorMaiuscula.ProcessarTexto(texto);
        Console.WriteLine($"Texto em maiúsculas: {resultadoMaiuscula}");

        TextoProcessor processadorMinuscula = new TudoMinuscula();
        string resultadoMinuscula = processadorMinuscula.ProcessarTexto(texto);
        Console.WriteLine($"Texto em minúsculas: {resultadoMinuscula}");
    }
}
