namespace Bakery.Models
{
    public class Bread
    {
        public int Loaves { get; }
        public int BreadTotal { get; set;}
        public Bread(int loaves)
        {
            Loaves = loaves;
            BreadTotal = 0;
        }
    }
}