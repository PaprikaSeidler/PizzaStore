using static System.Formats.Asn1.AsnWriter;

namespace PizzaStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StoreController store = new StoreController();
            store.Start();
        }
    }
}
