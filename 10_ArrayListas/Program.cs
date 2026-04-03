using System.ComponentModel;
using System.Diagnostics.Contracts;
using _10_ArrayListas.Models;

 int[] arrayIinteiros = new int[5];
    arrayIinteiros[0] = 10;
    arrayIinteiros[1] = 20;
    arrayIinteiros[2] = 30;
    arrayIinteiros[3] = 40;
    arrayIinteiros[4] = 50;

// array é uma estrutura de dados que armazena um número fixo de valores do mesmo tipo.
Console.WriteLine("Array com for:");
for (int contador = 0; contador < arrayIinteiros.Length; contador++)
    
    {
        Console.WriteLine($"Posição: N {contador} - Valor: {arrayIinteiros[contador]}");
    }

Console.WriteLine("\nArray com foreach:");
// foreach é uma estrutura de repetição que percorre cada elemento de uma coleção, como um array ou uma lista, e executa um bloco de código para cada elemento.
    
    int contadorForeach = 0;
    foreach (int valor in arrayIinteiros)
    {
        Console.WriteLine("Posição: N {0} - Valor: {1}", contadorForeach, valor);
        contadorForeach++;
    }