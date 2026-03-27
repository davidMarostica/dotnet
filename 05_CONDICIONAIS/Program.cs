using _05_CONDICIONAIS.Models;
{
    int quantidadeEmEstoque = 10;
    int quantidadeCompra = 4;

    if (quantidadeCompra <= quantidadeEmEstoque)
    {
        Console.WriteLine("Venda realizada com sucesso");
    }
    else
    {
        Console.WriteLine("Desculpe, não temos a quantidade desejada em estoque");
    }
}