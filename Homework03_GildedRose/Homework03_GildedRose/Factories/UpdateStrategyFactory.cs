using System;
using System.Collections.Generic;
using System.Text;

namespace Homework03_GildedRose
{
    class UpdateStrategyFactory
    {
        public static IUpdateStrategy Create(Item item)
        {
            if (item.Name.Contains("Sulfuras"))
            {
                return new SulfurasUpdateStrategy();
            }
            else if (item.Name.Contains("Aged Brie"))
            {
                return new AgedBrieUpdateStrategy();
            }
            else if (item.Name.Contains("Backstage pass"))
            {
                return new BackstagePassUpdateStrategy();
            }
            else if (item.Name.Contains("Conjured"))
            {
                return new ConjuredUpdateStrategy();
            }
            else
            {
                return new StandardUpdateStrategy();
            }
        }
    }



}

