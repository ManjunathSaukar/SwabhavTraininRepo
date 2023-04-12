using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonMultithreadVoilationApp.Model
{
    internal class DataService
    {
        private static DataService instance = null;

        private DataService()
        {
            Console.WriteLine("Data Service Created");
        }

        public static DataService GetInstance()
        {
            if (instance == null)
            {
                instance = new DataService();
            }
            return instance;
        }

        public void DoProcessing()
        {
            Console.WriteLine("Processing Data by " + Thread.CurrentThread.Name);
            Thread.Sleep(1000);
        }

    }
}
