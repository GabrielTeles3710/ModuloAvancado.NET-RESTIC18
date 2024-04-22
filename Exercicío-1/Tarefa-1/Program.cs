using Tarefa_1;

static void Main(string[] args)
{
    /*
    int confirm = 0;
    var lampada = new Lampada();

    Console.WriteLine(" 1.Ligar \n 2. Desligar \n 3.Imprimir ");
    while (confirm != 1)
    {
        
        var escolha = Int32.Parse(Console.ReadLine());
        Console.WriteLine(" 1.Ligar \n 2.Desligar \n 3.Imprimir ");
        Console.WriteLine();
        switch (escolha)
        {
            case 1:
                Console.WriteLine("Você ligou a lampada");
                lampada.Ligar();
                Console.WriteLine();
                break;
            case 2:
                Console.WriteLine("Você desligou a lampada");
                lampada.Desligar();
                Console.WriteLine();
                break;
            case 3:
                lampada.Imprimir();
                Console.WriteLine();
                break;
        }
        Console.Write("Deseja continuar S/0 N/1: ");
        confirm = Int32.Parse(Console.ReadLine());
        Console.WriteLine();
    }
    Console.WriteLine("Tenha um bom dia");
    */
    int formato = 0;
    
    Console.WriteLine("Informe a data: \n");
        
        Console.Write("Dia: ");
        var dia = Int32.Parse(Console.ReadLine());
        
        Console.Write("Mes: ");
        var mes = Int32.Parse(Console.ReadLine());
        
        Console.Write("Ano: ");
        var ano = Int32.Parse(Console.ReadLine());

        Console.Write("Deseja informar a hora? S/N: ");
        var horaConfirmacao  = Console.ReadLine().ToLower();
        
        if(horaConfirmacao == "s"){
        Console.Write("Qual o formato desejado? 1/24H 2/12H: ");
        formato = Int32.Parse(Console.ReadLine());
        
        Console.Write("Hora: ");
        var hora = Int32.Parse(Console.ReadLine());

        Console.Write("Minuto: ");
        var minuto = Int32.Parse(Console.ReadLine());
        
        Console.Write("segundo: ");
        var segundo = Int32.Parse(Console.ReadLine());
        Console.WriteLine();
        var data = new Data(dia,mes,ano,hora,minuto,segundo);
        Console.WriteLine("Data de execução: ");
        data.imprimir(formato);
        }else{
        Console.WriteLine("Data de execução: "+dia+"/"+mes+"/"+ano);
        }
}

Main(args);
