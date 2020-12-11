

namespace Bakery.Models
{
    public class Pastry
    {
        public int Pastries { get; }
        public int PastryTotal { get; set; }
        public Pastry(int pastries)
        {
            Pastries = pastries;
            PastryTotal = 0;
        }   
    }
}