using System.ComponentModel;
using Norem.Properties;
using System;

namespace Norem.Models
{
    public enum Faction
    {
        ForglarSwamp,
        ForsakenWastes,
        IronfistStronghold,
        SunderedLands,
        KThirForest,
        Underdepths,
        SavageTundra,
        ShatteredPeaks
    }

    public static class FactionExt
    {
        public static string ToString(Faction faction)
        {
            switch (faction)
            {
                case Faction.ForglarSwamp:          return Resources.ForglarSwamp;
                case Faction.ForsakenWastes:        return Resources.ForsakenWastes;
                case Faction.IronfistStronghold:    return Resources.IronfistStronghold;
                case Faction.KThirForest:           return Resources.KThirForest;
                case Faction.SavageTundra:          return Resources.SavageTundra;
                case Faction.ShatteredPeaks:        return Resources.ShatteredPeaks;
                case Faction.SunderedLands:         return Resources.SunderedLands;
                case Faction.Underdepths:           return Resources.Underdepths;
                default: throw new InvalidEnumArgumentException("faction", (int) faction, typeof(Faction));
            }
        }

        public static Faction ToFaction(string value)
        {
            switch (value)
            {
                case "Forglar Swamp":       return Faction.ForglarSwamp;
                case "Forsaken Wastes":     return Faction.ForsakenWastes;
                case "Ironfist Stronghold": return Faction.IronfistStronghold;
                case "K'thir Forest":       return Faction.KThirForest;
                case "Savage Tundra":       return Faction.SavageTundra;
                case "Shattered Peaks":     return Faction.ShatteredPeaks;
                case "Sundered Lands":      return Faction.SunderedLands;
                case "Underdepths":         return Faction.Underdepths;
                default: throw new ArgumentException("Faction matching \"" + value + "\"could not be found.", "value");
            }
        }
    }
}
