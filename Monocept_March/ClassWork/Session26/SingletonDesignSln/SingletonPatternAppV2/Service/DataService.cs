
namespace SingletonPatternAppV2.Service
{
    internal class DataService
    {
        private static DataService _bucket=null;
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
            if (_bucket == null)
                _bucket = new DataService();
            return _bucket;
        }
    }
}
