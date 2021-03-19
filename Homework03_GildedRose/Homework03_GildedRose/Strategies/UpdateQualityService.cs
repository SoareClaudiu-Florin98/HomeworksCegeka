using System;
using System.Collections.Generic;
using System.Text;

namespace Homework03_GildedRose
{
    internal class UpdateQualityService
    {
        public static void DecreaseQuality(Item item)
        {
            if (item.Quality > 0)
            {
                item.Quality -= 1;
            }
        }
        public static void IncreaseQuality(Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality += 1;
            }
        }


    }
}
