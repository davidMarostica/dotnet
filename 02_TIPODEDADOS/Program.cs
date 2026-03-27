using  _02_TIPODEDADOS.Models;

string apresentacao = "Olá, seja bem vindo ao curso de C#";

int quantidade = 1;
quantidade = 10;

double altura = 1.80;

bool condicao = true;

decimal valor = 1.80m;

Console.WriteLine(apresentacao);
Console.WriteLine("Valor da variavel: " + quantidade);
Console.WriteLine("Valor da variavel: " + altura.ToString("0.00"));
Console.WriteLine("Valor da variavel: " + altura);
Console.WriteLine("Valor da variavel: " + condicao);
Console.WriteLine("Valor da variavel: " + valor);

// Tipo data DateTime

DateTime dataAtual = DateTime.Now;
Console.WriteLine("Data atual: " + dataAtual);  
