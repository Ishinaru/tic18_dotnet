using System.Globalization;
using Prova.Pessoa;
using Prova.Cliente;
using Prova.Advogado;

CultureInfo.CurrentCulture = CultureInfo.CreateSpecificCulture("pt-BR");

List<Advogado> advogados = new List<Advogado>();
var ad1('João', new DateTime(1990, 1, 1), '12345678901', '12345678901');
var ad2('Maria', new DateTime(1990, 1, 1), '12345678902', '12345678902');
var ad3('José', new DateTime(1990, 1, 1), '12345678903', '12345678903');
var ad4('Ana', new DateTime(1990, 1, 1), '12345678904', '12345678904');

List<Cliente> clientes = new List<Cliente>();

 static void AdicionarAdvogado(List<Advogado> advogados, Advogado advogado){
    if(advogados.Any(a => a.Cpf == advogado.Cpf || a.CNA == advogado.CNA)){
        throw new Exception("Advogado já cadastrado");
    }
    else
        advogados.Add(advogado);
}