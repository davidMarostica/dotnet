
using _09_REPETICAO.Models;

// for (inicialização; condição; incremento)
Console.WriteLine("-------------Tabuada do 10-------------");
 int numro = 10;
  

  for(int contador = 0; contador <= 10; contador++)
  {
    Console.WriteLine($"{numro} x {contador} = {numro * contador}");
  }
 
 Console.WriteLine("-------------Tabuada do 5-------------");

  //while (condição)
  int numero = 5;
  int contador2 = 0;
  while (contador2 <= 10)
  {
    Console.WriteLine($"{numero} x {contador2} = {numero * contador2}");
    contador2++;
  }