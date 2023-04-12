using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonMultithreadRefactoredApp.Model
{
    internal class DataService
    {
        private static DataService instance = null;
        private static readonly object lockObject = new object();

        private DataService()
        {
            Console.WriteLine("Data Service Created");
        }

        public static DataService GetInstance()
        {
            lock (lockObject)
            {
                if (instance == null)
                {
                    instance = new DataService();
                }
            }
            return instance;
        }

        public void DoProcessing()
        {
            lock (lockObject)
            {
                Console.WriteLine("Processing Data by " + Thread.CurrentThread.Name);
                Thread.Sleep(1000);
            }
        }

    }
}
