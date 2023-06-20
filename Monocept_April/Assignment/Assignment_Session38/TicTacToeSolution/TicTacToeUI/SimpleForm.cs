
using System;
using System.Drawing;
using System.Windows.Forms;
using TicTacToeLib.Model;

namespace TicTacToeUI
{
    public class SimpleForm : Form
    {
       public SimpleForm()
        {
            this.Text = "Simple Form";
            this.Width = 450;
            this.Height = 450;

            Button btn0= new Button();
            btn0.Text = "0";
            btn0.Location = new Point(10, 10);
            btn0.Click += PrintButtonValue;
            
            Button btn1 = new Button();
            btn1.Text = "1";
            btn1.Location = new Point(90, 10);
            btn1.Click += PrintButtonValue;
            
            Button btn2 = new Button();
            btn2.Text = "2";
            btn2.Location = new Point(170, 10);
            btn2.Click += PrintButtonValue;


            Button btn3 = new Button();
            btn3.Text = "3";
            btn3.Location = new Point(10, 40);
            btn3.Click += PrintButtonValue;

            Button btn4 = new Button();
            btn4.Text = "4";
            btn4.Location = new Point(90, 40);
            btn4.Click += PrintButtonValue;

            Button btn5 = new Button();
            btn5.Text = "5";
            btn5.Location = new Point(170, 40);
            btn5.Click += PrintButtonValue;

            Button btn6 = new Button();
            btn6.Text = "6";
            btn6.Location = new Point(10, 70);
            btn6.Click += PrintButtonValue;

            Button btn7 = new Button();
            btn7.Text = "7";
            btn7.Location = new Point(90, 70);
            btn7.Click += PrintButtonValue;

            Button btn8 = new Button();
            btn8.Text = "8";
            btn8.Location = new Point(170, 70);
            btn8.Click += PrintButtonValue;


            this.Controls.Add(btn0);
            this.Controls.Add(btn1);
            this.Controls.Add(btn2);
            this.Controls.Add(btn3);
            this.Controls.Add(btn4);
            this.Controls.Add(btn5);
            this.Controls.Add(btn6);
            this.Controls.Add(btn7);
            this.Controls.Add(btn8);
        }
        private void PrintButtonValue(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string s = button.Text;
            Console.WriteLine("Button Value is : "+s);
            MessageBox.Show("Button Value is : " + s);
        }
    }
}
