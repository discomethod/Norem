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
        KthirForest,
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
                case Faction.KthirForest:           return Resources.KthirForest;
                case Faction.SavageTundra:          return Resources.SavageTundra;
                case Faction.ShatteredPeaks:        return Resources.ShatteredPeaks;
                case Faction.SunderedLands:         return Resources.SunderedLands;
                case Faction.Underdepths:           return Resources.Underdepths;
                default: throw new InvalidEnumArgumentException("faction", (int) faction, typeof(Faction));
            }
        }

        public static Faction ToFaction(string factionName)
        {
            // use if...else rather than switch so we can compare to resource values
            if (factionName == Resources.ForglarSwamp)
            {
                return Faction.ForglarSwamp;
            } else if (factionName == Resources.ForsakenWastes) {
                return Faction.ForsakenWastes;
            } else if (factionName == Resources.IronfistStronghold) {
                return Faction.IronfistStronghold;
            } else if (factionName == Resources.KthirForest) {
                return Faction.KthirForest;
            } else if (factionName == Resources.SavageTundra) {
                return Faction.SavageTundra;
            } else if (factionName == Resources.ShatteredPeaks) {
                return Faction.ShatteredPeaks;
            } else if (factionName == Resources.SunderedLands) {
                return Faction.SunderedLands;
            } else if (factionName == Resources.Underdepths) {
                return Faction.Underdepths;
            } else {
                throw new ArgumentException(String.Format("The faction name \"{0}\" could not be matched.", factionName), "value");
            }
        }
    }
}
