
using System.Transactions;

namespace InventryManagementApp.Model
{
    internal class Inventory
    {
        private List<Guitar> guitars;
        
        public Inventory()
        {
            guitars = new List<Guitar>();
        }
        public void AddGuiter(string serialNumber, double price, Builder builder, string model, TypeEnum type, Wood backWood, Wood topWood)
        {
            Guitar guiter=new Guitar(serialNumber,price,builder,model,type,backWood,topWood);

            guitars.Add(guiter);
        }
        public List<Guitar> GetAllGuiter()
        {
            return guitars;
        }

        public List<Guitar> Search(Guitar searchGuiter)
        {
            List<Guitar> matchingGuiter = new List<Guitar>();

            foreach(Guitar guiter in guitars)
            {
                if(searchGuiter.Builder==guiter.Builder && 
                    searchGuiter.Model==guiter.Model &&
                    searchGuiter.Type==guiter.Type &&
                    searchGuiter.BackWood==guiter.BackWood &&
                    searchGuiter.TopWood == guiter.TopWood)
                {
                    matchingGuiter.Add(guiter);
                }
            }
            return matchingGuiter;
        }
    }
}
