using System.ComponentModel;
using Norem.Properties;

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
                default: throw new InvalidEnumArgumentException("rarity",(int) rarity, typeof(Rarity));
            }
        }
    }
}