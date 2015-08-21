using System.ComponentModel;
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
    }
}