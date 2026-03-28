using _05_CONDICIONAIS.Models;
{
    int quantidadeEmEstoque = 3;
    int quantidadeCompra = 4;
    bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;

    {
        if (possivelVenda)
        {
            Console.WriteLine("Venda realizada com sucesso!");
        }
        else
        {
            Console.WriteLine("Desculpe, não temos a quantidade desejada em estoque.");

        }
    }

}

