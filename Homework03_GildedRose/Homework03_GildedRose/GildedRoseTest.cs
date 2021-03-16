using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
namespace Homework03_GildedRose
{
    public class GildedRoseTest
    {
        [Fact]
        public void foo()
        {
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equals("fixme", Items[0].Name);
        }
    }
}
