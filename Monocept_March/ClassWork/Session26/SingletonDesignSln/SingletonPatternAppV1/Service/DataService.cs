
namespace SingletonPatternAppV1.Service
{
    internal class DataService
    {
        private DataService()
        {
            Console.WriteLine("Data Service Created");
        }

        internal void DoProcessing()
        {
            Console.WriteLine("Processing Data by " + this.GetHashCode());
        }
        public static DataService GetInstance()
        {
            return new DataService();
        }
    }
}
