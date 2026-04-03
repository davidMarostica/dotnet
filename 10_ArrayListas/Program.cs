using System.Diagnostics.Contracts;
using _10_ArrayListas.Models;

// array é uma estrutura de dados que armazena um número fixo de valores do mesmo tipo.
 int[] arrayIinteiros = new int[5];
    arrayIinteiros[0] = 10;
    arrayIinteiros[1] = 20;
    arrayIinteiros[2] = 30;
    arrayIinteiros[3] = 40;
    arrayIinteiros[4] = 50;


    for (int contador = 0; contador < arrayIinteiros.Length; contador++)
    {
        Console.WriteLine($"Posição: N {contador} - Valor: {arrayIinteiros[contador]}");
    }