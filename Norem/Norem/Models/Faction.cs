using System.ComponentModel;
using Norem.Properties;

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
                case Faction.ForglarSwamp:  return Resources.ForglarSwamp;
                case Faction.ForsakenWastes: return Resources.ForsakenWastes;
                case Faction.IronfistStronghold: return Resources.IronfistStronghold;
                case Faction.KThirForest: return Resources.KThirForest;
                case Faction.SavageTundra: return Resources.SavageTundra;
                case Faction.ShatteredPeaks: return Resources.ShatteredPeaks;
                case Faction.SunderedLands: return Resources.SunderedLands;
                case Faction.Underdepths: return Resources.Underdepths;
                default: throw new InvalidEnumArgumentException("faction", (int) faction, typeof(Faction));
            }
        }
    }
}
