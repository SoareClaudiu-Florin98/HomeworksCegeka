namespace Homework03_GildedRose
{
    internal class ConjuredUpdateStrategy : IUpdateStrategy
    {
        public void Update(Item item)
        {
            if (item.Quality > 0)
            {
                item.Quality -= 2;
            }
            item.SellIn -= 1;
            if (item.SellIn < 0)
            {
                if (item.Quality > 0)
                {
                    item.Quality -= 2;
                }
            }
        }


    }
    
}