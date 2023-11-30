#region Exercicio 1

/*
Exercício 1: Tuplas
Crie uma função que recebe um nome e uma idade como parâmetros e 
retorna uma tupla contendo o nome e a idade. Em
seguida, chame a função com diferentes valores e exiba os resultados.
*/

Func<String , int, (String, int)> retornaTupla = (nome, idade) => (nome, idade);
Console.WriteLine($"Tupla = {retornaTupla("David", 22)}");

#endregion


#region Exercicio 5
    /*

        Exercício 5: Combinação de Tuplas, Expressões Lambda e LINQ
        Crie uma lista de tuplas, onde cada tupla contém o nome de uma pessoa e a 
        sua altura em centímetros. Utilize uma expressão
        lambda e LINQ para calcular a altura média das pessoas na lista.
    */

    List<(String nome, int altura)>listaTuplas = new ();
    listaTuplas.Add (("David Vinícius", 179));
    listaTuplas.Add (("Igor Alex", 178));
    listaTuplas.Add (("Daniel Penedo", 180));
    listaTuplas.Add (("D. Arrascaeta", 175));
    listaTuplas.Add (("Giuseppe Camolis", 187));

    var mediaAltura = ;
    Console.WriteLine (mediaAltura);

#endregion