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


    List<string> listaString = new List<string>();
    
    listaString.Add("São Paulo");
    listaString.Add("Rio de Janeiro");
    listaString.Add("Belo Horizonte");
    listaString.Add("Curitiba");
    listaString.Add("Salvador");


    Console.WriteLine($"\nItens na minha lista: {listaString.Count} - Capacidade:{listaString.Capacity}");

    listaString.Add("Fortaleza");

    Console.WriteLine($"\nItens na minha lista: {listaString.Count} - Capacidade:{listaString.Capacity}");
    listaString.Remove("Belo Horizonte");

    Console.WriteLine($"\nItens na minha lista: {listaString.Count} - Capacidade:{listaString.Capacity}");
     
    //  A propriedade Count retorna o número de elementos atualmente armazenados na lista, enquanto a propriedade Capacity retorna a capacidade total da lista, ou seja, o número de elementos que a lista pode armazenar antes de precisar ser redimensionada.
    for (int contador = 0; contador < listaString.Count; contador++)
    {
        Console.WriteLine($"Posição: N {contador} - Valor: {listaString[contador]}");
    } 

    int contadorForeachLista = 0;
     Console.WriteLine($"\nLista de cidades com foreach:");

    //  O foreach é uma estrutura de repetição que percorre cada elemento de uma coleção, como um array ou uma lista, e executa um bloco de código para cada elemento. Ele é especialmente útil para iterar sobre coleções sem a necessidade de gerenciar índices manualmente.
    foreach (string cidade in listaString)
    {
        Console.WriteLine($"Valor: {cidade}");
    }

    Console.WriteLine($"\nItens na minha lista: {listaString.Count} - Capacidade:{listaString.Capacity}");

