namespace Advogado;
using Pessoa;
public class Advogado : Pessoa
{
    public Advogado(string nome, DateTime dataNascimento, string cpf, string cna) : base(nome, dataNascimento, cpf){
        CNA = cna;
    }
    public string CNA { get; set; }
}
