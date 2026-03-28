using _07_LOGICO.Models;

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