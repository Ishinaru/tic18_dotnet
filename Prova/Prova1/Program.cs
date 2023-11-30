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
Console.WriteLine($"Texto: {string.Join(", ", relatorio1)}");
    
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
