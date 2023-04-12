
using System;
using System.Windows.Forms;

namespace ConsoleWinFormFrameWorkApp
{
    internal class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            this.Text = "Gautam's Form";
            this.Width = 500;
            this.Height = 500;
            Button btnHello=new Button();
            btnHello.Text = "Hello";
            btnHello.Click += GoodListener;
            btnHello.Click += DevilListener;

            this.Controls.Add(btnHello);
        }
        public void GoodListener(object sender,EventArgs e)
        {
            Console.WriteLine("God is Listening");
        }
        public void DevilListener(object sender, EventArgs e)
        {
            Console.WriteLine("Devil is Listening");
        }
    }
}
