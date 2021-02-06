using System;
using System.Collections.Generic;

namespace GildedRose
{
    class Program
    {
        private static List<ConvertedItem> Items;
        static void Main(string[] args)
        {
            Init();
            Display(31);
        }

        static void Init()
        {
            Items = new List<ConvertedItem>{
                new NormalItem("+5 Dexterity Vest", 10, 20),
                new AgingItem("Aged Brie", 2, 0),
                new NormalItem("Elixir of the Mongoose", 5, 7),
                new ArtifactItem("Sulfuras, Hand of Ragnaros", 0, 80),
                new ArtifactItem("Sulfuras, Hand of Ragnaros", -1, 80),
                new TicketItem("Backstage passes to a TAFKAL80ETC concert", 15, 20),
                new TicketItem("Backstage passes to a TAFKAL80ETC concert", 10, 49),
                new TicketItem("Backstage passes to a TAFKAL80ETC concert", 5, 49),
                new ConjuredItem("Conjured Mana Cake", 3, 6)
            };
        }
        static void Display(int days)
        {
            Console.WriteLine("OMGHAI!");
            for (var i = 0; i < days; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                ConvertedItem convertedItem;
                foreach (var item in Items)
                {
                    System.Console.WriteLine(item);
                    convertedItem = (ConvertedItem) item;
                    convertedItem.UpdateQuality();
                }
                Console.WriteLine("");
                // alternative to individual strategies:
                // GildedRose.UpdateQuality(Items);
            }
        }

    }
}

// TO DO:
// 7) review apply min and max qualities - use additional conditions whether to call them at all

// possible maybes:
// 1) separate projects for pure logic and model logic - both runnable
// 2) tests that compare output to pregenerated test output - separate classes and maybe projects
// 3) unit tests? by what strategy?
// 4) try to someday implement interface members x2