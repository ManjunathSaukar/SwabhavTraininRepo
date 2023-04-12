using SingletonMultithreadVoilationApp.Model;

namespace SingletonMultithreadVoilationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(() =>
            {
                DataService.GetInstance().DoProcessing();
            });
            t1.Name = "Thread 1";

            Thread t2 = new Thread(() =>
            {
                DataService.GetInstance().DoProcessing();
            });
            t2.Name = "Thread 2";

            Thread t3 = new Thread(() =>
            {
                DataService.GetInstance().DoProcessing();
            });
            t3.Name = "Thread 3";

            t1.Start();
            t2.Start();
            t3.Start();
        }
    }
}