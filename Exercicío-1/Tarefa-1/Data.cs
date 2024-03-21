namespace Tarefa_1;

public class Data
{
    public int dia {get; private set;}
    public int mes {get; private set;}
    public int ano {get; private set;}
    public int hora {get; private set;}
    public int minuto {get; private set;}
    public int segundo {get; private set;}
    
    public Data(int _dia,int _mes,int _ano){
        setDia(_dia);
        mes = _mes;
        ano = _ano;
    }
    public Data(int _dia, int _mes, int _ano,int _hora,int _minuto,int _segundo) : this(_dia, _mes, _ano){
    
    setHora(_hora);
    setMinuto(_minuto);
    setSegundo(_segundo);
    }
    private void setDia(int _dia)
    {
        if (_dia <= 31)
        {
            dia = _dia;
        }else{
            throw new Exception("Dia invalido");
        }
    }
    private void setHora(int _hora){
        if(_hora < 24){
            hora = _hora;
        }else{
            throw new Exception("Hora invalida");
        }
    }
    private void setMinuto(int _minuto){
        if(_minuto <= 60){
            minuto = _minuto;
        }else{
            throw new Exception("Minutos invalidos");
        }
    }
    private void setSegundo(int _segundo){
        if(_segundo <= 60){
            segundo = _segundo;
        }else{
            throw new Exception("Segundos invalidos");
        }
    }
    public void imprimir(int formato){
        if(formato == 1){
            var _hora = new DateTime(ano, mes, dia, hora, minuto, segundo);
            Console.WriteLine(_hora);
        }
        //erro ao formatar am/pm
        if(formato == 2){
            var _hora = new DateTime(ano, mes, dia, hora, minuto, segundo);
            var horaFormat12 = _hora.ToString("dd/MM/yyyy hh:mm:ss tt");
            Console.WriteLine(horaFormat12);
        }
    }

}
