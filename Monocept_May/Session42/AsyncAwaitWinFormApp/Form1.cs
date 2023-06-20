using AsyncAwaitWinFormApp.Services;
using System.Diagnostics;

namespace AsyncAwaitWinFormApp
{
    public partial class Form1 : Form
    {
        PrintingService _service= new PrintingService();

        public Form1()
        {
            InitializeComponent();
        }
        private void btnHelloCode_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello Passes");
            Debug.WriteLine("Hello Pressed");
        }
        private void btnPrintSync_Click(object sender, EventArgs e)
        {
            _service.Print();
            MessageBox.Show("End of Click");
        }
        private void btnTask1_Click(object sender, EventArgs e)
        {
            Task.Run(_service.Print);
            MessageBox.Show("End of Task1 Click");
        }
        private async void btnPrintAsync1_Click(object sender, EventArgs e)
        {
            await _service.PrintAsync1();
            MessageBox.Show("End of Async1 Click");
        }
        private async void btnPrintAsync2_Click(object sender, EventArgs e)
        {
            var result=await _service.PrintAsync2();
            MessageBox.Show(result.ToString());
        }

    }
}