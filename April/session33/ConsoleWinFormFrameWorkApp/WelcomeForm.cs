using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            btnHello.Click += GodListener;
            btnHello.Click += DevilListener;

            this.Controls.Add(btnHello);
        }
        public void GodListener(object sender, EventArgs e)
        {
            Console.WriteLine("God is Listening");
        }
        public void DevilListener(object sender, EventArgs e)
        {
            Console.WriteLine("Devil is Listening");
        }
    }
}
