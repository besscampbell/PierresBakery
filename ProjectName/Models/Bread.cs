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

        public void TotalBread()
        {
            int remainder = (Loaves % 3);
            int freeLoaves = (Loaves - remainder)/3;
            BreadTotal = (Loaves - freeLoaves) * 5;
        }
    }
}