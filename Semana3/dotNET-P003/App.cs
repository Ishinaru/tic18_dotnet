using Semana3.dotNET_P003;

public class App{
    public static void Main(){
        var estoque = new List<Produto>();
        var opcao = 0;
        do{
            Console.WriteLine("1 - Cadastrar produto");
            Console.WriteLine("2 - Atualizar estoque");
            Console.WriteLine("3 - Consultar produto");
            Console.WriteLine("4 - Sair");
            Console.Write("Digite a opção desejada: ");
            opcao = int.Parse(Console.ReadLine());
            switch(opcao){
                case 1:
                    Console.Write("Digite o código do produto: ");
                    var codigo = int.Parse(Console.ReadLine());
                    Console.Write("Digite o nome do produto: ");
                    var nome = Console.ReadLine();
                    Console.Write("Digite a quantidade do produto: ");
                    var quantidade = int.Parse(Console.ReadLine());
                    Console.Write("Digite o preço do produto: ");
                    var preco = double.Parse(Console.ReadLine());
                    MetodosProduto.AddProduto(estoque, codigo, nome, quantidade, preco);
                    break;
                case 2:
                    Console.Write("Digite o código do produto: ");
                    codigo = int.Parse(Console.ReadLine());
                    Console.Write("Digite a quantidade a ser adicionada: ");
                    quantidade = int.Parse(Console.ReadLine());
                    MetodosProduto.AtualizarEstoque(estoque, codigo, quantidade);
                    break;
                case 3:
                    Console.Write("Digite o código do produto: ");
                    codigo = int.Parse(Console.ReadLine());
                    MetodosProduto.ConsultarProduto(estoque, codigo);
                    break;
                case 4:
                    Console.WriteLine("Sair");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }while(opcao != 4);
    }
}
