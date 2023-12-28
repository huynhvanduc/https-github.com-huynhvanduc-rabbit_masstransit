using MasstransitRabbitMQ.Consumer.API.Abstraction.Messages;
using MasstransitRabbitMQ.Contract.Abtractions.IntegrationEvents;
using MediatR;
using Serilog;

namespace MasstransitRabbitMQ.Consumer.API.MessageBus.Consumers.Events
{
    public class SendEmailWhenReceidEmailEventConsume : Consumer<DomainEvent.EmailNotification>
    {
        public SendEmailWhenReceidEmailEventConsume(ISender sender) : base(sender)
        {
        }
    }
}
