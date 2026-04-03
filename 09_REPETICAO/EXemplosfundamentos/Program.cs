
using System.Globalization;
using _09_REPETICAO.Common.Models;

// for (inicialização; condição; incremento)
// Console.WriteLine("-------------Tabuada do 10-------------");
//  int numro = 10;
  

//   for(int contador = 0; contador <= 10; contador++)
//   {
//     Console.WriteLine($"{numro} x {contador} = {numro * contador}");
//   }
 
//  Console.WriteLine("-------------Tabuada do 5-------------");

//   //while (condição)
//   int numero = 5;
//   int contador2 = 1;
//   while (contador2 <= 10)
//   {
//     Console.WriteLine($"{contador2 }º Execução: {numero} x {contador2} = {numero * contador2}");
//     contador2++;

//     if (contador2 == 6)
//   {
//     break; // Interrompe o loop quando contador2 for igual a 6
//   }
//   }

 // Do-While (condição)
  //  int soma = 0, numero = 0;
  // do
  // {
  //   Console.WriteLine("Digite um número (0 para sair): ");
  //   numero = Convert.ToInt32(Console.ReadLine());
  //   soma += numero;
  // } while (numero != 0);

  // Console.WriteLine($"A soma dos números digitados é: {soma}");


String opcao;

while(true)
{
  Console.WriteLine("Digite sua opção:");
  Console.WriteLine("1 - Cadastrar cliente");
  Console.WriteLine("2 - Buscar clientes"); 
  Console.WriteLine("3 - Apagar cliente");
  Console.WriteLine("4 - Sair"); 

  

  opcao = Console.ReadLine() ?? "";

  switch (opcao)
  {
    case "1":
      Console.WriteLine("Cadastro de cliente selecionado.");
      break;
    case "2":
      Console.WriteLine("Busca de clientes selecionada.");
      break;
    case "3":
      Console.WriteLine("Apagar cliente selecionado.");
      break;
    case "4":
      Console.WriteLine("Saindo do programa...");
      return; // Encerra o programa
    default:
      Console.WriteLine("Opção inválida. Por favor, tente novamente.");
      break;
  }
 
}

