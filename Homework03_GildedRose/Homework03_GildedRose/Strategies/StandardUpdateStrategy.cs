using System;
using System.Collections.Generic;
using System.Text;

namespace Homework03_GildedRose
{
    class StandardUpdateStrategy : IUpdateStrategy
    {
        public void Update(Item item)
        {
            UpdateQualityService.DecreaseQuality(item); 
            item.SellIn -= 1;

            if (item.SellIn < 0)
            {
                UpdateQualityService.DecreaseQuality(item);
            }
        }

    }
    
}
