using Semana3.dotNET_P003;


public static class MetodosProduto{
    public static void AddProduto(List<Produto> estoque, int codigo, string nome, int quantidade, double preco){
        estoque.Add(new Produto(codigo, nome, quantidade, preco));
          
        Console.WriteLine("Produto cadastrado com sucesso!");
    }

    public static void AtualizarEstoque(List<Produto> estoque, int codigo, int novaQuantidade){
        var produto = estoque.FirstOrDefault(p=>p.Codigo == codigo);
        if(produto != null){
            if(produto.Quantidade + novaQuantidade < 0)
                throw new Exception("Quantidade insuficiente");
            produto.Quantidade += novaQuantidade;
            Console.WriteLine("Estoque atualizado com sucesso!");
        }
        else
            throw new Exception("Produto não encontrado");
    }

    public static void ConsultarProduto(List<Produto> estoque, int codigo){
        var produto = estoque.FirstOrDefault(p=>p.Codigo == codigo);
        if(produto != null){
            Console.WriteLine($"Nome: {produto.Nome}");
            Console.WriteLine($"Quantidade: {produto.Quantidade}");
            Console.WriteLine($"Preço: {produto.Preco}");
        }
        else
            throw new Exception("Produto não encontrado");
    }

}