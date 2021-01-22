﻿using System;
using System.Collections.Generic;

namespace GildedRose
{
    class Program
    {
        private static IList<Item> Items;
        static void Main(string[] args)
        {
            Console.WriteLine("OMGHAI!");
            Init();
            Display(31);
        }

        static void Init()
        {
            // can't create item subtypes???
            Items = new List<Item>{
                new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80},
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 15,
                    Quality = 20
                },
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 10,
                    Quality = 49
                },
                new Item
                {
                    Name = "Backstage passes to a TAFKAL80ETC concert",
                    SellIn = 5,
                    Quality = 49
                },
				new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
            };
        }
        static void Display(int days)
        {
            var app = new GildedRose(Items);
            for (var i = 0; i < days; i++)
            {
                Console.WriteLine("-------- day " + i + " --------");
                Console.WriteLine("name, sellIn, quality");
                foreach (var item in Items)
                {
                    System.Console.WriteLine(item);
                }
                Console.WriteLine("");
                app.UpdateQuality();
            }
        }

    }
}