using LaunchGildedRose;

namespace GildedRose.UnitTests
{
    public class GildedRoseTests
    {
        [Fact]
        public void Test1()
        {
            List<Item> items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            var app = new LaunchGildedRose.GildedRose(items);
            app.UpdateQuality();
            Assert.Equal("fixme", items[0].Name);
        }
    }
}