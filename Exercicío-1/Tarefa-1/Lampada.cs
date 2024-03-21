namespace Tarefa_1;

public class Lampada
{
    public Lampada(){
        ligada = true;
    }
    public bool ligada {get; private set;}
    public void Ligar(){
        ligada = true;
    }
    public void Desligar(){
        ligada = false;
    }
    public void Imprimir(){
        if (ligada == true){
            Console.WriteLine("Lampada ligada");
        }else{
            Console.WriteLine("Lampada desligada");
        }
        
    }
}
