using Microsoft.Extensions.Logging;
using RV24.PMA.Logic.Domain.EmailManagement.Contract;

namespace RV24.PMA.Logic.Domain.EmailManagement
{
    public class EmailSender : IEmailSender
    {
        private readonly ILogger<EmailSender> _logger;

        public EmailSender(ILogger<EmailSender> logger)
        {
            _logger = logger;
        }
        public void Send(string message)
        {
            _logger.LogInformation("Email verschickt: "+message);
        }
    }
}
