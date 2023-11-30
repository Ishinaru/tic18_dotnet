namespace Prova.Advogado;
using Prova.Pessoa;
public class Advogado : Pessoa
{
    public Advogado(string nome, DateTime dataNascimento, string cpf, string cna) : base(nome, dataNascimento, cpf){
        CNA = cna;
    }
    public string CNA { get; set; }

    public static void AdicionarAdvogado(List<Advogado> advogados, Advogado advogado){
        if(advogados.Any(a => a.Cpf == advogado.Cpf || a.CNA == advogado.CNA)){
            throw new Exception("Advogado já cadastrado");
        }
        else
            advogados.Add(advogado);
    }
}
