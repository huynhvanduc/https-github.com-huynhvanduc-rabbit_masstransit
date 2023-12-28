using MassTransit;
using MasstransitRabbitMQ.Contract.Abtractions.IntegrationEvents;
using MasstransitRabbitMQ.Contract.Constants;
using Microsoft.AspNetCore.Mvc;

namespace MasstransitRabbitMQ.Producer.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProducersController : ControllerBase
    {
        private readonly IPublishEndpoint _publishEndpoint;

        public ProducersController(IPublishEndpoint publishEndpoint)
        {
            _publishEndpoint = publishEndpoint; 
        }

        [HttpPost(Name = "publish-sms-notification")]
        public async Task<IActionResult> PublishSmsNotificationEvent()
        {
            await _publishEndpoint.Publish(new DomainEvent.SmsNotification()
            {
                Id = Guid.NewGuid(),
                Description = "Sms description",
                Name = "sms description",
                TimeStamp = DateTime.Now,
                TransactionId = Guid.NewGuid(),
                Type = "sms"
            });

            await _publishEndpoint.Publish(new DomainEvent.EmailNotification()
            {
                Id = Guid.NewGuid(),
                Description = "Email description",
                Name = "Email description",
                TimeStamp = DateTime.Now,
                TransactionId = Guid.NewGuid(),
                Type = "Email"
            });
            return Accepted();
        }
    }
}