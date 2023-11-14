namespace Mango.Services.ShoppingCartAPI.RabbitMQSender
{
    public interface IRabbitMQMessageSender
    {
        void SendMessage(Object message, string queueName);
    }
}
