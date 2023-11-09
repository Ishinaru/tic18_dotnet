#region Teste de tipos de dados

    
    int tipoInt;
    double tipoDouble;
    string tipoString;
    long tipoLong;
    
    tipoInt = int.MaxValue;
    tipoLong = tipoInt;
    //Console.WriteLine("O máximo inteiro é: "+tipoInt);
    Console.WriteLine(tipoLong);
    tipoLong = long.MaxValue;
    Console.WriteLine("O máximo long é: "+tipoLong);

    tipoDouble = double.MaxValue;
    Console.WriteLine("O máximo double é: "+tipoDouble);

    tipoString = "100";
    tipoInt = int.Parse(tipoString);
    Console.WriteLine("Tipo string = "+tipoString+" convertido para int com parse = "+tipoInt);


#endregion

#region Operadores
    tipoDouble = tipoInt + tipoLong;
    //erro pq um double + um long nao cabem no inteiro
    //tipoInt = tipoDouble + tipoLong;
    //erro pq um double + um int nao cabem no long
    //tipoLong = tipoDouble + tipoInt;
    tipoInt = 10>5?1:0;
    Console.WriteLine(tipoInt);
#endregion