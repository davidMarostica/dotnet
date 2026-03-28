using _08_ARITIMETICO.Models;

Calculadora calc = new Calculadora();


calc.Somar(10, 5);
calc.Subtrair(10, 5);   
calc.Multiplicar(10, 5);
calc.Dividir(10, 5);
calc.Dividir(10, 0);    
calc.Potencia(2, 3);
calc.RaizQuadrada(16);
calc.RaizQuadrada(-4);  
calc.Seno(30);
calc.Coseno(60);
calc.Tangente(45);


int numero = 10;
Console.WriteLine(numero);

Console.WriteLine("Incrementando o número 10");
//numero = numero + 1 ;  
numero ++; 

Console.WriteLine(numero);

int numeroDecremento = 20;
Console.WriteLine(numeroDecremento);

Console.WriteLine("Decrementando o número 20");
//numero = numero - 1 ;  
numeroDecremento --; 

Console.WriteLine(numeroDecremento);