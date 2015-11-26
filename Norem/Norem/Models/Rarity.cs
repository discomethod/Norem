using System.ComponentModel;
using Norem.Properties;
using System;

namespace Norem.Models
{
    public enum Rarity
    {
        Common,
        Uncommon,
        Rare,
        Exotic,
        Limited,
        Legendary
    }

    public static class RarityExt
    {
        public static string ToString(Rarity rarity)
        {
            switch (rarity)
            {
                case Rarity.Common: return Resources.RarityCommon;
                case Rarity.Uncommon: return Resources.RarityUncommon;
                case Rarity.Rare: return Resources.RarityRare;
                case Rarity.Exotic: return Resources.RarityExotic;
                case Rarity.Legendary: return Resources.RarityLegendary;
                case Rarity.Limited: return Resources.RarityLimited;
                default: throw new InvalidEnumArgumentException("rarity", (int)rarity, typeof(Rarity));
            }
        }

        public static Rarity ToRarity(string pnRarity)
        {
            if (pnRarity == Resources.RarityCommon)
            {
                return Rarity.Common;
            } else if (pnRarity == Resources.RarityUncommon)
            {
                return Rarity.Uncommon;
            } else if (pnRarity == Resources.RarityRare)
            {
                return Rarity.Rare;
            } else if (pnRarity == Resources.RarityExotic)
            {
                return Rarity.Exotic;
            } else if (pnRarity == Resources.RarityLegendary)
            { 
                return Rarity.Legendary;
            }
            else
            {
                throw new ArgumentException("The value \"{pnRarity}\" does not correspond to a rarity.","pnRarity");
            }
        }
    }
}