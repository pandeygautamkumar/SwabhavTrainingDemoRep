namespace AnagramCheckerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckIsAnagram("HEART","EARTH"));
            Console.WriteLine(CheckIsAnagram("heart", "earth"));
        }
        private static bool CheckIsAnagram(string s1, string s2)
        {
            if (s1.Length!=s2.Length) return false;

            const int NO_OF_CHARACTER = 256;
            int[] freq = new int[NO_OF_CHARACTER];
            
            for (int i = 0; i < NO_OF_CHARACTER; i++)
            {
                freq[i] = 0;
            }
            for (int i = 0; i < s1.Length; i++)
            {
                freq[s1[i]]++;
                freq[s2[i]]--;
            }
            for (var i = 0; i < NO_OF_CHARACTER; i++)
            {
                if (freq[i] != 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}