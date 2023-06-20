namespace MiddleWareMVCApp.Services
{
    public class GmailService : IEmailService
    {
        public GmailService()
        {
            Console.WriteLine("GmailService Created");
        }
        public Task SendEmail(string from, string to, string details)
        {
            return Task.Run(() =>
            {
                Console.WriteLine("Sending Email via Gmail");
                Console.WriteLine($"From {from} to {to} details {details}");
            });
        }
    }
}
