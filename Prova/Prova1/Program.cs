using System.Globalization;
using Prova.Pessoa;
using Prova.Cliente;
using Prova.Advogado;

CultureInfo.CurrentCulture = CultureInfo.CreateSpecificCulture("pt-BR");

List<Advogado> advogados = new List<Advogado>();
AdicionarAdvogado(advogados, new Advogado("João", new DateTime(1, 2, 1992), "12345678901", "123456789"));
AdicionarAdvogado(advogados, new Advogado("Maria", new DateTime(5, 12, 1972), "12345678902", "123456789"));
AdicionarAdvogado(advogados, new Advogado("José", new DateTime(13, 7, 1991), "12345678903", "123456789"));
AdicionarAdvogado(advogados, new Advogado("Ana", new DateTime(4, 4, 2004), "12345678904", "123456789"));
AdicionarAdvogado(advogados, new Advogado("Pedro", new DateTime(8, 1, 2001), "12345678905", "123456789"));


List<Cliente> clientes = new List<Cliente>();
AdicionarCliente(clientes, new Cliente("João", new DateTime(1, 2, 1992), "12345678901", "Solteiro", "Programador"));
AdicionarCliente(clientes, new Cliente("Maria", new DateTime(5, 12, 1972), "12345678902", "Casada", "Professora"));
AdicionarCliente(clientes, new Cliente("José", new DateTime(13, 7, 1991), "12345678903", "Solteiro", "Médico"));
AdicionarCliente(clientes, new Cliente("Ana", new DateTime(4, 4, 2004), "12345678904", "Solteira", "Estudante"));
AdicionarCliente(clientes, new Cliente("Pedro", new DateTime(8, 1, 2001), "12345678905", "Solteiro", "Estudante"));





static void AdicionarAdvogado(List<Advogado> advogados, Advogado advogado){
    if(advogados.Any(a => a.Cpf == advogado.Cpf || a.CNA == advogado.CNA)){
        throw new Exception("Advogado já cadastrado");
    }
    else
        advogados.Add(advogado);
}

static void AdicionarCliente(List<Cliente> clientes, Cliente cliente){
    if(clientes.Any(c => c.Cpf == cliente.Cpf)){
        throw new Exception("Cliente já cadastrado");
    }
    else
        clientes.Add(cliente);
}