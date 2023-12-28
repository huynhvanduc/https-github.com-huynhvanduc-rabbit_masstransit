using MasstransitRabbitMQ.Contract.Abtractions.IntegrationEvents;
using MediatR;

namespace MasstransitRabbitMQ.Consumer.API.UseCases
{
    public class SendSmsEventConsumerHander : IRequestHandler<DomainEvent.SmsNotification>
    {
        private readonly ILogger<SendSmsEventConsumerHander> _logger;
        public SendSmsEventConsumerHander(ILogger<SendSmsEventConsumerHander> logger)
        {
            _logger = logger;
        }

        public  async Task Handle(DomainEvent.SmsNotification request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Message receiced: {message}", request);
        }
    }
}
