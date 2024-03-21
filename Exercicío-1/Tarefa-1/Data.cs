namespace Tarefa_1;

public class Data
{
    public int dia {get; private set;}
    public int mes {get; private set;}
    public int ano {get; private set;}
    public int seg {get; private set;}
    public Data(int _dia,int _mes,int _ano){
        setDia(_dia);
        mes = _mes;
        ano = _ano;
    }
    public void setDia(int _dia){
        if (dia <= 31)
        {
            dia = _dia;
        }else{
            Console.WriteLine("Dia inválido");
        }
    }
}
