using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleWinFormFrameWorkApp
{
    internal class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            this.Text = "Manjunath's Form";
            this.Width = 500;
            this.Height = 500;

            Button btnHello = new Button();
            btnHello.Text = "Hello";
            btnHello.Click += ((sender, eventArg) =>
            {
                MessageBox.Show("Hello There");
            });

            Button btnPrint = new Button();
            btnPrint.Text = "Print Infinite";
            btnPrint.Location = new Point(250, 0);
            btnPrint.Click += ((sender, eventArg) =>
            {
                PrintInfinity();
            });

            Button btnPrintWithThread = new Button();
            btnPrintWithThread.Text = "Non Blocking/Async";
            btnPrintWithThread.Location = new Point(350, 0);
            btnPrintWithThread.Click += (sender, eventArgs) =>
            {
                Thread t = new Thread(PrintInfinity);
                t.Start();
            };

            this.Controls.Add(btnHello);
            this.Controls.Add(btnPrint);
            this.Controls.Add(btnPrintWithThread);

        }
        void PrintInfinity()
        {
            DateTime startTime = DateTime.Now;
            TimeSpan futureTime = TimeSpan.FromMinutes(.10);
            //while (DateTime.Now-startTime<futureTime)
            //{
            //    Console.WriteLine(DateTime.Now.ToString("hh:mm:ss"));
            //}

            while (true)
            {
                Console.WriteLine(DateTime.Now.ToString("hh:mm:ss"));
            }

        }
    }
}