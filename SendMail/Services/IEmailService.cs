using SendMail.Models;

namespace SendMail.Services
{
    public interface IEmailService
    {
        void SendEmail(EmailDTO request);
    }
}
