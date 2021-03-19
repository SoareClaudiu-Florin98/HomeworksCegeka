using System;
using System.Collections.Generic;
using System.Text;

namespace Homework03_GildedRose
{
    class BackstagePassUpdateStrategy : IUpdateStrategy
    {
        public void Update(Item item)
        {
            if (item.SellIn > 0)
            {

                UpdateQualityService.IncreaseQuality(item); 
            }
            if (item.SellIn < 11)
            {
                UpdateQualityService.IncreaseQuality(item);

            }
            if (item.SellIn < 6)
            {
                UpdateQualityService.IncreaseQuality(item);
            }
            item.SellIn -= 1;
            if (item.SellIn < 0)
            {
                item.Quality = 0;
            }
        }


    }
    
}
