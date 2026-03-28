using System;

namespace _08_ARITIMETICO.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($" {x} + {y} = {x + y}"); 
        }

        public void Subtrair(int x, int y)
        {
            Console.WriteLine($" {x} - {y} = {x - y}"); 
        }

        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($" {x} * {y} = {x * y}"); 
        }

        public void Dividir(int x, int y)
        {
            if (y != 0)
                Console.WriteLine($" {x} / {y} = {(double)x / y}");
            else
                Console.WriteLine("Erro: Divisão por zero não é permitida.");
        }

        public void Potencia(int x, int y)
        {
            double pot = Math.Pow(x, y);
            Console.WriteLine($" {x} ^ {y} = {pot}");
        }

        public void RaizQuadrada(int x)
        {
            if (x >= 0)
            {
                double raiz = Math.Sqrt(x);
                Console.WriteLine($" √{x} = {raiz}");
            }
            else
            {
                Console.WriteLine("Erro: Não é possível calcular a raiz quadrada de um número negativo.");
            }
        }

        public void Seno(double angulo)
        {
            double radianos = angulo * (Math.PI / 180);
            double seno = Math.Sin(radianos);
            Console.WriteLine($"Seno de {angulo}° = {seno}");
        }

        public void Coseno(double angulo)
        {
            double radianos = angulo * (Math.PI / 180);
            double coseno = Math.Cos(radianos);
            Console.WriteLine($"Cosseno de {angulo}° = {coseno}");
        }

        public void Tangente(double angulo)
        {
            double radianos = angulo * (Math.PI / 180);
            double tangente = Math.Tan(radianos);
            Console.WriteLine($"Tangente de {angulo}° = {tangente}");
        }
    }
}
