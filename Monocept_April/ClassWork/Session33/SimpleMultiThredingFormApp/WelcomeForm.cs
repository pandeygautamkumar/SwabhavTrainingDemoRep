
using System;
using System.Drawing;
using System.Runtime.Remoting.Channels;
using System.Threading;
using System.Windows.Forms;

namespace SimpleMultiThredingFormApp
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
            btnHello.Click += ((IChannelSender, eventArg) =>
            {
                MessageBox.Show("Hello There");
            });

            Button btnPrint = new Button();
            btnPrint.Text = "Print Infinity";
            btnPrint.Location = new Point(250,0);

            btnPrint.Click += (sender, eventArgs) =>
            {
                PrintInfinity();
            };



            Button btnPrintWithThread = new Button();
            btnPrintWithThread.Text = "Non Blocking/Async";
            btnPrintWithThread.Location = new Point(350, 0);

            btnPrintWithThread.Click += (sender, eventArgs) =>
            {
                Thread t = new Thread(PrintInfinity);
                t.Start();
            };



            this.Controls.Add(btnPrintWithThread);
            this.Controls.Add(btnPrint);
            this.Controls.Add(btnHello);
        }

        private static void PrintInfinity()
        {
            DateTime startTime= DateTime.Now;
            TimeSpan future = TimeSpan.FromMinutes(.15);
           // while(true)
            while (DateTime.Now - startTime < future)
            {
                Console.WriteLine(DateTime.Now.ToString("hh:mm:ss"));
            }
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
