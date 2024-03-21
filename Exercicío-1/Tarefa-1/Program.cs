using Tarefa_1;

static void Main(string[] args)
{
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
}

Main(args);
