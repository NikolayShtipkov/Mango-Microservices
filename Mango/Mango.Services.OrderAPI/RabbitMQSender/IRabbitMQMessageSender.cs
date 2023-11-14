namespace Mango.Services.OrderAPI.RabbitMQSender
{
    public interface IRabbitMQMessageSender
    {
        void SendMessage(Object message, string exchangeName);
    }
}
