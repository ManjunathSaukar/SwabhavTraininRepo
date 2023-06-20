namespace MiddleWareMVCApp.Services
{
    public class OutlookService:IEmailService
    {
        public OutlookService()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("OutlookService Created");
            Console.ResetColor();
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
