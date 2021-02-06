using System;
using System.Collections.Generic;
using System.Text;

namespace GildedRose.Interfaces
{
    public interface IConvertedItem
    {
        void UpdateQuality();
        void ApplyMinQuality();
        // public void ApplyMaxQuality();
    }
}
