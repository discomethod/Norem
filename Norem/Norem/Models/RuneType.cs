using System.ComponentModel;
using System.Net.NetworkInformation;
using Norem.Properties;

namespace Norem.Models
{
    public enum RuneType
    {
        Champion,
        Spell,
        Relic,
        Equipment,
    }

    public static class RuneTypeExt
    {
        public static string ToString(RuneType runetype)
        {
            switch (runetype)
            {
                case RuneType.Champion: return Resources.Champion;
                case RuneType.Spell: return Resources.Spell;
                case RuneType.Relic: return Resources.Relic;
                case RuneType.Equipment: return Resources.Equipment;
                default: throw new InvalidEnumArgumentException("runetype", (int)runetype, typeof(RuneType));
            }
        }

        public static string ToPoxNoraIdentifier(RuneType runetype)
        {
            switch (runetype)
            {
                case RuneType.Champion: return Resources.PoxNoraChampion;
                case RuneType.Spell: return Resources.PoxNoraSpell;
                case RuneType.Relic: return Resources.PoxNoraRelic;
                case RuneType.Equipment: return Resources.PoxNoraEquipment;
                default: throw new InvalidEnumArgumentException("runetype", (int)runetype, typeof(RuneType));
            }
        }
    }
}