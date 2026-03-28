using _07_LOGICO.Models;

// Operador Lógico OR (||) qualquer uma das condições ser verdadeira, o resultado é verdadeiro
bool ehMaiorDeIdade = true;
bool possuiAutorizacaoDoResponsavel = false;

if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
{
    Console.WriteLine("Acesso permitido.");
}
else
{
    Console.WriteLine("Acesso negado.");
}

//Operador Lógico && (AND) tem que cumprir todas as condições para ser verdadeiro

bool possuiPresencaMinima = true;
double media = 7.5;

if (possuiPresencaMinima && media >= 7)
{
    Console.WriteLine("Aluno aprovado.");
}
else
{
    Console.WriteLine("Aluno reprovado.");
}
