namespace Semana3.dotNET_P003;

public class Produto(int cod_prod, string nome, int quantidade, double preco)
{
    private static int ProdutoID {get; set;} = 2023000;
    public int Id { get; } = ++ProdutoID;
    public string Nome { get; set; } = nome;
    public int Codigo { get; set; } = cod_prod;
    public int Quantidade { get; set; } = quantidade;
    public double Preco { get; set; } = preco;
}
