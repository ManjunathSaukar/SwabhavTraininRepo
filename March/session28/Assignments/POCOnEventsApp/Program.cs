using POCOnEventsApp.Model;

namespace POCOnEventsApp
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();

            customer.OnAdded += Email.Send;
            customer.OnAdded += SMS.Send;

            customer.Add("Manjunath");
        }
    }
}