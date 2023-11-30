using System.Globalization;
using Prova.Pessoa;
using Prova.Cliente;
using Prova.Advogado;
 
//CultureInfo.CurrentCulture = CultureInfo.CreateSpecificCulture("pt-BR");

List<Advogado> advogados = new List<Advogado>();
App.AdicionarAdvogado(advogados, new Advogado("João", new DateTime(2001, 1, 1), "12345678901", "123456789"));
App.AdicionarAdvogado(advogados, new Advogado("Maria", new DateTime(1972, 2, 2), "12345678902", "123456789"));
App.AdicionarAdvogado(advogados, new Advogado("José", new DateTime(2003, 3, 3), "12345678903", "123456789"));
App.AdicionarAdvogado(advogados, new Advogado("Ana", new DateTime(1945, 12, 4), "12345678904", "123456789"));
App.AdicionarAdvogado(advogados, new Advogado("Pedro", new DateTime(1988, 5, 25), "12345678905", "123456789"));

List<Cliente> clientes = new List<Cliente>();
App.AdicionarCliente(clientes, new Cliente("João", new DateTime(1, 2, 1992), "12345678901", "Solteiro", "Programador"));
App.AdicionarCliente(clientes, new Cliente("Maria", new DateTime(5, 12, 1972), "12345678902", "Casada", "Professora"));
App.AdicionarCliente(clientes, new Cliente("José", new DateTime(13, 7, 1991), "12345678903", "Solteiro", "Médico"));
App.AdicionarCliente(clientes, new Cliente("Ana", new DateTime(4, 4, 2004), "12345678904", "Solteira", "Estudante"));
App.AdicionarCliente(clientes, new Cliente("Pedro", new DateTime(8, 1, 2001), "12345678905", "Solteiro", "Estudante"));

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
