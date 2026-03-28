using _05_CONDICIONAIS.Models;
{
    int quantidadeEmEstoque = 10;
    int quantidadeCompra = 4;
    bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;

    Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
    Console.WriteLine($"Quantidade desejada: {quantidadeCompra}");  
    Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

     if (possivelVenda)

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

