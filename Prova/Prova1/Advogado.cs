using Prova1.Pessoa;
public class Advogado : Pessoa
{
    public Advogado(string cna) : base(nome, dataNascimento, cpf){
        CNA = cna;
    }
    public string CNA { get; set; }
}
