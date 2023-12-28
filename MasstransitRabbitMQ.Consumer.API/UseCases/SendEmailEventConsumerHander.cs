using MasstransitRabbitMQ.Contract.Abtractions.IntegrationEvents;
using MediatR;

namespace MasstransitRabbitMQ.Consumer.API.UseCases
{
    public class SendEmailEventConsumerHander : IRequestHandler<DomainEvent.EmailNotification>
    {
        private readonly ILogger<SendEmailEventConsumerHander> _logger;
        public SendEmailEventConsumerHander(ILogger<SendEmailEventConsumerHander> logger)
        {
            _logger = logger;
        }

        public async Task Handle(DomainEvent.EmailNotification request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Message receiced: {message}", request);
        }
    }
}
