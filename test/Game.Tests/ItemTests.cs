using System;
using System.IO;
using System.Collections.Generic;
using Xunit;

namespace Game.Tests
{
    public class ItemTests
    {
    List<Item> item;
        [Fact]
        public void ItemTest()
        {
            Item itm = item[0];
            {
                Assert.Equal("Potion", itm.Name);
                Assert.Equal("Small", itm.Size);
                Assert.Equal(10, itm.Strength);
                Assert.Equal(5, itm.Price);
                Assert.Equal("Heals10hp", itm.Description);
            }
        } 
    }
}