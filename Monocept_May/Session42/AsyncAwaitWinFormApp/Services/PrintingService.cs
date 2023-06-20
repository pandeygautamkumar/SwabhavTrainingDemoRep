
using System.Diagnostics;

namespace AsyncAwaitWinFormApp.Services
{
    internal class PrintingService
    {
        public void Print()
        {
            DateTime startDate = DateTime.UtcNow;
            TimeSpan future = TimeSpan.FromSeconds(8);

            while(DateTime.UtcNow - startDate < future)
            {
                Debug.WriteLine("Delay : " + DateTime.Now.ToString("hh:mm:ss"));
            }
            Debug.WriteLine("Delay Over");
        }
        public Task PrintAsync1()
        {
            return Task.Run(Print);
        }
        public Task<string> PrintAsync2()
        {
            return Task.Run(() =>
            {
                Print();
                Random r = new Random();
                return "Success -->" +r.Next(1,15);
            });
        }
    }
}
