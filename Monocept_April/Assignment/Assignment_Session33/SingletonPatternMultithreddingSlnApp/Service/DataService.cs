
namespace SingletonPatternMultithreddingSlnApp.Service
{
    internal class DataService
    {
        private static object _lockObject = new object();
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
            
            lock (_lockObject)
            {
                if (_instance == null)
                {
                    _instance = new DataService();
                }
                return _instance;
            }
        }
    }
}
