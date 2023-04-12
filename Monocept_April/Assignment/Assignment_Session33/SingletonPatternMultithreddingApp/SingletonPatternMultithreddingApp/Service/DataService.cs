
namespace SingletonPatternMultithreddingApp.Service
{
    internal class DataService
    {
        private static DataService _instance = null;
        private DataService()
        {
            Console.WriteLine("Data Service Created");
        }
        public void DOProcessing()
        {
            Console.WriteLine("Proccessing Data by : " + this.GetHashCode());
        }
        public static DataService GetInstance()
        {
            if (_instance == null)
            {
                _instance = new DataService();
            }
            return _instance;
        }
    }
}
