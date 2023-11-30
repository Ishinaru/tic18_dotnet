using System.Globalization;
using Prova.Pessoa;
using Prova.Cliente;
using Prova.Advogado;
 
//CultureInfo.CurrentCulture = CultureInfo.CreateSpecificCulture("pt-BR");

List<Advogado> advogados = new List<Advogado>();
App.AdicionarAdvogado(advogados, new Advogado("João", new DateTime(2001, 1, 1), "12345678901", "123456789"));
App.AdicionarAdvogado(advogados, new Advogado("Maria", new DateTime(1972, 2, 2), "12345678902", "000000000"));
App.AdicionarAdvogado(advogados, new Advogado("José", new DateTime(2001, 3, 3), "12345678903", "000000001"));
App.AdicionarAdvogado(advogados, new Advogado("Ana", new DateTime(1945, 12, 4), "12345678904", "000000002"));
App.AdicionarAdvogado(advogados, new Advogado("Pedro", new DateTime(1988, 5, 25), "12345678905", "000000003"));

List<Cliente> clientes = new List<Cliente>();
App.AdicionarCliente(clientes, new Cliente("João", new DateTime(1992, 2 ,1), "12345678901", "Solteiro", "Programador"));
App.AdicionarCliente(clientes, new Cliente("Maria", new DateTime(1972, 12, 5), "12345678902", "Casada", "Professora"));
App.AdicionarCliente(clientes, new Cliente("José", new DateTime(1991, 7, 13), "12345678903", "Solteiro", "Médico"));
App.AdicionarCliente(clientes, new Cliente("Ana", new DateTime(2004, 4, 4), "12345678904", "Solteira", "Estudante"));
App.AdicionarCliente(clientes, new Cliente("Pedro", new DateTime(2001, 8 ,1), "12345678905", "Solteiro", "Estudante"));

var relatorio1 = advogados.Where(a => a.Idade() > 20 && a.Idade()<30).Select(a => new {a.Nome, a.CNA});
Console.WriteLine($"Relatorio 1:\n {string.Join(", \n", relatorio1)}");

var relatorio2 = clientes.Where(c => c.Idade() > 18 && c.Idade()<40).Select(c => new {c.Nome});
Console.WriteLine($"Relatorio 2:\n {string.Join(", \n", relatorio2)}");

Console.WriteLine("Escolha o Estado Civil:");
string ?estadoCivil = Console.ReadLine();
var relatorio3 = clientes.Where(c => c.EstadoCivil == estadoCivil).Select(c => new {c.Nome, c.EstadoCivil, c.Profissao});

Console.WriteLine($"Relatorio 3:\n {string.Join(", \n", relatorio3)}");    
var relatorio4 = clientes.OrderBy(c => c.Nome).Select(c => new {c.Nome, c.EstadoCivil, c.Profissao});

Console.WriteLine($"Relatorio 4:\n {string.Join(", \n", relatorio4)}");
Console.WriteLine("Escolha a Profissão:");
string ?profissao = Console.ReadLine();
var relatorio5 = clientes.Where(c => c.Profissao == profissao).Select(c => new {c.Nome, c.EstadoCivil, c.Profissao});
Console.WriteLine($"Relatorio 5:\n {string.Join(", \n", relatorio5)}"); 

Console.WriteLine("Escolha o Mês de Aniversário:");
string ?mes = Console.ReadLine();

var relatorio6 = Pessoa.Where((c,a) => a.DataNascimento.Month == c.DataNascimento.Month).Select(c => new {c.Nome, c.EstadoCivil, c.Profissao});
Console.WriteLine($"Relatorio 6:\n {string.Join(", \n", relatorio6)}"); 

public class App{
    public static void AdicionarAdvogado(List<Advogado> advogados, Advogado advogado){
        if(advogados.Any(a => a.Cpf == advogado.Cpf || a.CNA == advogado.CNA)){
            throw new Exception("Advogado já cadastrado");
        }
        else
            advogados.Add(advogado);
    }

    public static void AdicionarCliente(List<Cliente> clientes, Cliente cliente){
        if(clientes.Any(c => c.Cpf == cliente.Cpf)){
            throw new Exception("Cliente já cadastrado");
        }
        else
            clientes.Add(cliente);
    }

}
