using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Norem.Models
{
    class PoxNoraForgeJSON
    {
        private int m_Balance;
        public int Balance
        {
            get { return m_Balance; }
            set { m_Balance = value; }
        }

        private PoxNoraRune[] m_Champions;
        public PoxNoraRune[] Champions
        {
            get { return m_Champions; }
            set { m_Champions = value; }
        }

        private PoxNoraRune[] m_Spells;
        public PoxNoraRune[] Spells
        {
            get { return m_Spells; }
            set { m_Spells = value; }
        }

        private PoxNoraRune[] m_Relics;
        public PoxNoraRune[] Relics
        {
            get { return m_Relics; }
            set { m_Relics = value; }
        }

        private PoxNoraRune[] m_Equipment;
        public PoxNoraRune[] Equipment
        {
            get { return m_Equipment; }
            set { m_Equipment = value; }
        }

        private PoxNoraKeyValue[] m_Factions;
        public PoxNoraKeyValue[] Factions
        {
            get { return m_Factions; }
            set { m_Factions = value; }
        }

        private PoxNoraKeyValue[] m_Releases;
        public PoxNoraKeyValue[] Releases
        {
            get { return m_Releases; }
            set { m_Releases = value; }
        }

        private PoxNoraKeyValue[] m_Rarities;
        public PoxNoraKeyValue[] Rarities
        {
            get { return m_Rarities; }
            set { m_Rarities = value; }
        }

        private PoxNoraKeyValue[] m_Races;
        public PoxNoraKeyValue[] Races
        {
            get { return m_Races; }
            set { m_Races = value; }
        }

        private PoxNoraKeyValue[] m_Classes;
        public PoxNoraKeyValue[] Classes
        {
            get { return m_Classes; }
            set { m_Classes = value; }
        }


    }
    class PoxNoraKeyValue
    {
        public int ID { get; set; }
        public string Value { get; set; }
    }
}
