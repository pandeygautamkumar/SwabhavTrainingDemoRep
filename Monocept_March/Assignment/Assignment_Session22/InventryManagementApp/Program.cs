using InventryManagementApp.Model;

namespace InventryManagementApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
            //CaseStudy2();
        }

        private static void CaseStudy2()
        {
            Inventory inventry = new Inventory();
            InitializeInventry(inventry);

            Guitar searchedGuitar = new Guitar("", 0, Builder.FENDER, "Stratocastor", TypeEnum.ELECTRIC, Wood.ALDER, Wood.ALDER);
            List<Guitar> searchGuitar = inventry.Search(searchedGuitar);
            PrintGuiterDetails(searchGuitar);
        }

        private static void CaseStudy1()
        {
            Inventory inventry = new Inventory();
            InitializeInventry(inventry);

            List<Guitar> allGuiter = inventry.GetAllGuiter();
            PrintGuiterDetails(allGuiter);
        }

        private static void PrintGuiterDetails(List<Guitar> allGuitar)
        {
            foreach (var guitar in allGuitar)
            {
                Console.WriteLine($"We have a {guitar.Builder} {guitar.Model} {guitar.Type}" +
                    $" Guitar. {guitar.BackWood} back & sides {guitar.TopWood} Top.");
                Console.WriteLine($"You Can have it for Only : {guitar.Price}");
                Console.WriteLine();
            }
        }
        private static void InitializeInventry(Inventory inventry)
        {
            inventry.AddGuiter("V95693",1499.95,Builder.FENDER,"Stratocastor",TypeEnum.ELECTRIC,Wood.ALDER,Wood.ALDER);
            inventry.AddGuiter("V95983", 1300.56, Builder.FENDER, "Stratocastor", TypeEnum.ELECTRIC, Wood.ALDER, Wood.ALDER);
            inventry.AddGuiter("V95693", 1699.95, Builder.MARTIN, "Stratocastor", TypeEnum.ACOUSTIC, Wood.COCOBOLO, Wood.COCOBOLO);
            inventry.AddGuiter("V95693", 1999.95, Builder.FENDER, "Stratocastor", TypeEnum.ELECTRIC, Wood.INDIAN_ROSEWOOD, Wood.INDIAN_ROSEWOOD);
            inventry.AddGuiter("V95693", 2299.95, Builder.FENDER, "Stratocastor", TypeEnum.ELECTRIC, Wood.MAHOGANY, Wood.MAHOGANY);
        }
    }
}