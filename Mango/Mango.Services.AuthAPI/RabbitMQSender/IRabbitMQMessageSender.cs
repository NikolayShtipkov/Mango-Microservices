namespace Mango.Services.AuthAPI.RabbitMQSender
{
    public interface IRabbitMQMessageSender
    {
        void SendMessage(Object message, string queueName);
    }
}
