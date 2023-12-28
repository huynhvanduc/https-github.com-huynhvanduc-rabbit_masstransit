using MassTransit;
using MasstransitRabbitMQ.Contract.Abtractions.Messages;
using MediatR;

namespace MasstransitRabbitMQ.Consumer.API.Abstraction.Messages
{
    public abstract class Consumer<TMessage> : IConsumer<TMessage>
        where TMessage : class, INotificationEvent
    {
        private readonly ISender Sender;

        protected Consumer(ISender sender)
        {
           this.Sender = sender;
        }

        public  async Task Consume(ConsumeContext<TMessage> context)
        {
            await Sender.Send(context.Message);
        }
    }
}
