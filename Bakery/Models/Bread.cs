namespace Bakery.Models
{
    public class Bread
    {
        public int Loaves { get; set; }
        public int BreadTotal { get; set;}
        public Bread(int loaves)
        {
            Loaves = loaves;
            BreadTotal = 0;
        }

        public void TotalBread()
        {
            int freeLoaves = Loaves/3;
            BreadTotal = (Loaves - freeLoaves) * 5;
        }

        public void AddLoaf()
        {
            Loaves += 1;
        }
    }
}