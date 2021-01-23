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
                new DexterityVest 
                {
                    Name = "+5 Dexterity Vest", 
                    SellIn = 10, 
                    Quality = 20
                },
                new AgedBrie
                {
                    Name = "Aged Brie", 
                    SellIn = 2, 
                    Quality = 0
                },
                new ElixirOfMongoose {
                    Name = "Elixir of the Mongoose", 
                    SellIn = 5, 
                    Quality = 7
                },
                new HandOfRagnaros {
                    Name = "Sulfuras, Hand of Ragnaros", 
                    SellIn = 0, 
                    Quality = 80
                },
                new HandOfRagnaros
                {
                    Name = "Sulfuras, Hand of Ragnaros",
                    SellIn = -1,
                    Quality = 80
                },
                new BackstagePasses
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 15,
                    Quality = 20
                },
                new BackstagePasses
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 10,
                    Quality = 49
                },
                new BackstagePasses
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 5,
                    Quality = 49
                },
				new ManaCake 
                {
                    Name = "Conjured Mana Cake",
                    SellIn = 3,
                    Quality = 6
                }
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
// 1) separate projects for pure logic and model logic - both runnable
// 2) tests that compare output to pregenerated test output - separate classes and maybe projects
// 3) unit tests? by what strategy?
// 4) Models implement an interface
// 5) maybe rename Item classes
// 6) merge Elixir and Vest into a generic class
// 7) review apply min and max qualities - use additional conditions whether to call them at all