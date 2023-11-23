bool condicao = true;
List<string> listaTarefas = new List<string>();

do{
    Console.WriteLine("Menu: ");
    Console.WriteLine("1 - Criar Tarefa");
    Console.WriteLine("2 - Visualizar Tarefas");
    Console.WriteLine("3 - Marcar Tarefa como Concluída");
    Console.WriteLine("4 - Listar Tarefas Concluídas");
    Console.WriteLine("5 - Listar Tarefas Pendentes");
    Console.WriteLine("6 - Excluir Tarefa");    
    Console.WriteLine("7 - Pesquisar Tarefa");
    Console.WriteLine("8 - Quantidade de Tarefas Concluídas");
    Console.WriteLine("9 - Quantidade de Tarefas Pendentes");
    Console.WriteLine("10 - Tarefa mais antiga");
    Console.WriteLine("11 - Tarefa mais recente");
    Console.WriteLine("0 - Sair");

    int opc = Convert.ToInt32(Console.ReadLine()); 

    switch(opc){
        case 1:
            Console.WriteLine("-----------------");
            Console.WriteLine("Criar Tarefa");
            Console.WriteLine("-----------------");
            Console.Write("Título da Tarefa: ");
            string titulo = Console.ReadLine() ?? "";
            Console.Write("Descrição da Tarefa: ");
            string descricao = Console.ReadLine();
            Console.WriteLine("Data de Vencimento: ");
            Console.Write("Dia:");
            var dia = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mês:");
            var mes = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ano:");
            var ano = Convert.ToInt32(Console.ReadLine());
            Console.Write("Hora:");
            var hora = Convert.ToInt32(Console.ReadLine());
            Console.Write("Minuto:");
            var minuto = Convert.ToInt32(Console.ReadLine());
            Console.Write("Segundo:");
            var segundo = Convert.ToInt32(Console.ReadLine());
            var dataVencimento = new DateTime(ano, mes, dia, hora, minuto, segundo);
            string tarefa = $"Título: {titulo} - Descrição: {descricao} - Data de Vencimento: {dataVencimento}";
            listaTarefas.Add(tarefa);
            break;
        case 2:
            Console.WriteLine("-----------------");
            Console.WriteLine("Lista de Tarefas");
            Console.WriteLine("-----------------");
            foreach(string t in listaTarefas){
                Console.WriteLine(t);
            }
            break;
            
        case 3:
            Console.WriteLine("-----------------");
            Console.WriteLine("Marcar Tarefa como Concluída");
            Console.WriteLine("-----------------");
            Console.WriteLine("Informe o índice da tarefa que deseja marcar como concluída:");
            int indice = Convert.ToInt32(Console.ReadLine());
            if(!listaTarefas[indice].Contains("Concluída")){
                listaTarefas[indice] = listaTarefas[indice] + " - Concluída";
                Console.WriteLine("Tarefa marcada com sucesso!!!");
                break;
            }
            else
                Console.WriteLine("Tarefa já está concluída!!!");

            break;

        case 4:
            Console.WriteLine("-----------------");
            Console.WriteLine("Lista de Tarefas Concluídas");
            Console.WriteLine("-----------------");
            foreach(string t in listaTarefas){
                if(t.Contains("Concluída"))
                    Console.WriteLine(t);
            }
            break;

        case 5:
            Console.WriteLine("-----------------");
            Console.WriteLine("Lista de Tarefas Pendentes");
            Console.WriteLine("-----------------");
            foreach(string t in listaTarefas){
                if(!t.Contains("Concluída"))
                    Console.WriteLine(t);
            }
            break;

        case 6:
            Console.WriteLine("-----------------");
            Console.WriteLine("Excluir Tarefa");
            Console.WriteLine("-----------------");
            Console.WriteLine("Informe o índice da tarefa que deseja excluir:");
            indice = Convert.ToInt32(Console.ReadLine());
            listaTarefas.RemoveAt(indice);
            Console.WriteLine("Tarefa excluída com sucesso!!!");
            break;

        case 7:
            Console.WriteLine("-----------------");
            Console.WriteLine("Pesquisar Tarefa");
            Console.WriteLine("-----------------");
            Console.WriteLine("Informe a palavra-chave:");
            string palavra = Console.ReadLine();
            foreach(string t in listaTarefas){
                if(t.Contains(palavra))
                    Console.WriteLine(t);
            }
            break;

        case 8:
            Console.WriteLine("-----------------");
            Console.WriteLine("Quantidade de Tarefas Concluídas");
            Console.WriteLine("-----------------");
            int cont = 0;
            foreach(string t in listaTarefas){
                if(t.Contains("Concluída"))
                    cont++;
            }
            Console.WriteLine($"Quantidade de Tarefas Concluídas: {cont}");
            break;

        case 9:
            Console.WriteLine("-----------------");
            Console.WriteLine("Quantidade de Tarefas Pendentes");
            Console.WriteLine("-----------------");
            cont = 0;
            foreach(string t in listaTarefas){
                if(!t.Contains("Concluída"))
                    cont++;
            }
            Console.WriteLine($"Quantidade de Tarefas Pendentes: {cont}");
            break;
        
        case 10:
            Console.WriteLine("-----------------");
            Console.WriteLine("Tarefa mais antiga");
            Console.WriteLine("-----------------");
            Console.WriteLine(listaTarefas[0]);
            break;
        
        case 11:
            Console.WriteLine("-----------------");
            Console.WriteLine("Tarefa mais recente");
            Console.WriteLine("-----------------");
            Console.WriteLine(listaTarefas[listaTarefas.Count - 1]);
            break;
            
        case 0:
            Console.WriteLine("Sair");
            condicao = false;
            break;
        default:
            Console.WriteLine("Opção Inválida");
            break;
    }

}while(condicao);