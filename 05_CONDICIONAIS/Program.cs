using _05_CONDICIONAIS.Models;
{
    int quantidadeEmEstoque = 10;
    int quantidadeCompra = 0;
    bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

    Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
    Console.WriteLine($"Quantidade desejada: {quantidadeCompra}");  
    Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

     if (quantidadeCompra == 0)
        {
            Console.WriteLine("Venda inválida.");
        }
        
    
     else if (possivelVenda)
        {
            Console.WriteLine("Venda realizada com sucesso!");
        }
     else
        {
            Console.WriteLine("Desculpe, não temos a quantidade desejada em estoque.");
        }
       

}
