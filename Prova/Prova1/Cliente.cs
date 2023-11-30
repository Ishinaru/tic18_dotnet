namespace Cliente;
using Pessoa;
public class Cliente : Pessoa{
    public Cliente(string nome, DateTime dataNascimento, string cpf, string estadoCivil, string profissao) : base(nome, dataNascimento, cpf){
        EstadoCivil = estadoCivil;
        Profissao = profissao;  
    }

    public string EstadoCivil { get; set; }
    public string Profissao { get; set; }
}
