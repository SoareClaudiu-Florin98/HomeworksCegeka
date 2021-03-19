using System;
using System.Collections.Generic;
using System.Text;

namespace Homework03_GildedRose
{
    class AgedBrieUpdateStrategy : IUpdateStrategy
    {
        public void Update(Item item)
        {
            UpdateQualityService.IncreaseQuality(item);
            item.SellIn -= 1;
            if (item.SellIn < 0)
            {
                UpdateQualityService.IncreaseQuality(item);               
            }
        }

    }
}
