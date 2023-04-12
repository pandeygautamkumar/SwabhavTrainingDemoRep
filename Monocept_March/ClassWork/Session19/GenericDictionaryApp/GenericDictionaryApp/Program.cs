namespace GenericDictionaryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stateCodes = new Dictionary<string, string>();

            stateCodes.Add("MH", "Maharastra");
            stateCodes.Add("KA", "Karnataka");
            stateCodes.Add("KL", "Kerala");
            
            if (stateCodes.ContainsKey("KL"))
            {
                stateCodes.Remove("KL");
                stateCodes.Add("KL", "New Kerala");
            }
            Console.WriteLine(stateCodes.Count);

            foreach(var row in stateCodes)
            {
                Console.WriteLine("Key is {0} -- Value is {1} ",row.Key,row.Value);
            }

            stateCodes["MH"] = "New Maharastra";
            Console.WriteLine(stateCodes["MH"]);
        }
    }
}