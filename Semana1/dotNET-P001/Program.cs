#region 3. Conversão de Tipos de Dados
    double varDouble = 853.1245;
    int varInt = (int)varDouble;
    Console.WriteLine("Valor double: " + varDouble);
    Console.WriteLine("Conversão de double para int: " + varInt);

    int varArredondado = (int)Math.Round(varDouble);
    Console.WriteLine("Conversão de double para int com arredondamento: " + varArredondado);

    varArredondado = (int)Math.Floor(varDouble);
    Console.WriteLine("Conversão de double para int com arredondamento para baixo: " + varArredondado);
    
    varArredondado = (int)Math.Ceiling(varDouble);
    Console.WriteLine("Conversão de double para int com arredondamento para cima: " + varArredondado);

#endregion

#region 4. Operadores Aritméticos
    int x = 10 , y = 3;
    Console.WriteLine($"Adição = {x} + {y} = {x+y}");
    Console.WriteLine($"Subtração = {x} - {y} = {x-y}");
    Console.WriteLine($"Multiplicação = {x} * {y} = {x*y}");
    Console.WriteLine($"Divisão = {x} / {y} = {(double)x/y}");  
    Console.WriteLine($"Divisão convertendo para double)= {x} / {y} = {(double)x/y}");    

#endregion

#region 5. Operadores de Comparação
    int a = 5, b = 8;
    if(a > b)
        Console.WriteLine($"a = {a} é maior que b = {b}");
    else
        Console.WriteLine($"a = {a} é menor que b = {b}");
#endregion

#region 6. Operadores de Igualdade
    string str1 = "Hello", str2 = "World";
    if(str1 == str2)
        Console.WriteLine($"str1 = {str1} é igual a str2 = {str2}");
    else
        Console.WriteLine($"str1 = {str1} é diferente de str2 = {str2}");
#endregion

#region  7. Operadores Lógicos
    bool condicao1 = true, condicao2 = true;
    if(condicao1 && condicao2)
        Console.WriteLine("condicao1 e condicao2 são verdadeiras");
    else if(condicao1 == false && condicao2 == true)
        Console.WriteLine("condicao1 é falsa");
    else if(condicao1 == true && condicao2 == false)
        Console.WriteLine("condicao2 é falsa");
    else
        Console.WriteLine("ambas as condições são falsas");
#endregion

#region 8. Desafio de Mistura de Operadores
    int num1 = 7, num2 = 3, num3 = 10;
    if(num1 > num2 && num3 == num1 + num2)
        Console.WriteLine("num1 é maior que num2 e num3 é igual a soma de num1 e num2");
    else
        Console.WriteLine("num1 não é maior que num2 ou num3 não é igual a soma de num1 e num2");
#endregion