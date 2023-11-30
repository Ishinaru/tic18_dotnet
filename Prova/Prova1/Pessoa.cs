namespace Prova.Pessoa;
public abstract class Pessoa{
    
    public Pessoa(string nome, DateTime dataNascimento, string cpf){
        Nome = nome;
        DataNascimento = dataNascimento;
        Cpf = cpf;
    }

    public string? Nome { get; set; }
    public DateTime DataNascimento { get; set; }
    public string? Cpf {
        get{return Cpf;}
        
        set {
            if (Cpf?.Length == 11 && Cpf.All(char.IsDigit))
                Cpf = value;
            else{
                throw new Exception("CPF inválido");
            }
        }
    }

    public int Idade(){
        DateTime dataAtual = DateTime.Now;
        int idade = dataAtual.Year - DataNascimento.Year;

        if (dataAtual.Month < DataNascimento.Month || (dataAtual.Month == DataNascimento.Month && dataAtual.Day < DataNascimento.Day))
        {
            idade--;
        }

        return idade;
    }

}
