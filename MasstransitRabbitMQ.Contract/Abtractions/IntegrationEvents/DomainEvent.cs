using MasstransitRabbitMQ.Contract.Abtractions.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasstransitRabbitMQ.Contract.Abtractions.IntegrationEvents
{
    public static class DomainEvent
    {
        public record class EmailNotification : INotificationEvent
        {
            public Guid Id { get ; set; }
            public string Name { get ; set ; }
            public string Description { get ; set ; }
            public string Type { get; set; }
            public Guid TransactionId { get ; set ; }
            public DateTimeOffset TimeStamp { get ; set ; }
        }

        public record class SmsNotification : INotificationEvent
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public string Type { get; set; }
            public Guid TransactionId { get; set; }
            public DateTimeOffset TimeStamp { get; set; }
        }
    }
}
