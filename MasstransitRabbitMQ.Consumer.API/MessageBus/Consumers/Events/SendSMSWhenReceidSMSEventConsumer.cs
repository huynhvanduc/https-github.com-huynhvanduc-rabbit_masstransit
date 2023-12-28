using MasstransitRabbitMQ.Consumer.API.Abstraction.Messages;
using MasstransitRabbitMQ.Contract.Abtractions.IntegrationEvents;
using MediatR;
using Serilog;

namespace MasstransitRabbitMQ.Consumer.API.MessageBus.Consumers.Events
{
    public class SendSmsWhenReceidEmailEventConsume : Consumer<DomainEvent.SmsNotification>
    {
        public SendSmsWhenReceidEmailEventConsume(ISender sender) : base(sender)
        {
        }
    }
}
