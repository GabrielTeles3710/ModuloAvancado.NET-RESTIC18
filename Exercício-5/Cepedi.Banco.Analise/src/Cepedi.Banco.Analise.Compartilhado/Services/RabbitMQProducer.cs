using System.Data;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Text;
namespace Cepedi.Banco.Analise.Compartilhado.Services;

public static class RabbitMQProducer
{
    public static void EnviarMensagem()
    {
        var factory = new ConnectionFactory() { HostName = "localhost"};

        using (var connection = factory.CreateConnection())
        using (var channel = connection.CreateModel()){
            channel.QueueDeclare(
                queue: "hello",
                durable: false,
                exclusive: false,
                autoDelete: false,
                arguments: null
            );
           string message = "Hello World!";
           var body  = Encoding.UTF8.GetBytes(message);
           channel.BasicPublish(
                exchange: "",
                routingKey: "hello",
                basicProperties: null,
                body: body
           );
            Console.WriteLine(" [X] Send {0}", message);
        }    
            Console.WriteLine("Press [ENTER] to exit.");
            Console.ReadLine();
    }
}
