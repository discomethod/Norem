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
        public int balance
        {
            get { return m_Balance; }
            set { m_Balance = value; }
        }

        private PoxNoraRune[] m_Champions;
        public PoxNoraRune[] champions
        {
            get { return m_Champions; }
            set { m_Champions = value; }
        }

        private PoxNoraRune[] m_Spells;
        public PoxNoraRune[] spells
        {
            get { return m_Spells; }
            set { m_Spells = value; }
        }

        private PoxNoraRune[] m_Relics;
        public PoxNoraRune[] relics
        {
            get { return m_Relics; }
            set { m_Relics = value; }
        }

        private PoxNoraRune[] m_Equipment;
        public PoxNoraRune[] equipment
        {
            get { return m_Equipment; }
            set { m_Equipment = value; }
        }

        private PoxNoraKeyValue[] m_Factions;
        public PoxNoraKeyValue[] factions
        {
            get { return m_Factions; }
            set { m_Factions = value; }
        }

        private PoxNoraKeyValue[] m_Releases;
        public PoxNoraKeyValue[] releases
        {
            get { return m_Releases; }
            set { m_Releases = value; }
        }

        private PoxNoraKeyValue[] m_Rarities;
        public PoxNoraKeyValue[] rarities
        {
            get { return m_Rarities; }
            set { m_Rarities = value; }
        }

        private PoxNoraKeyValue[] m_Races;
        public PoxNoraKeyValue[] races
        {
            get { return m_Races; }
            set { m_Races = value; }
        }

        private PoxNoraKeyValue[] m_Classes;
        public PoxNoraKeyValue[] classes
        {
            get { return m_Classes; }
            set { m_Classes = value; }
        }


    }
    class PoxNoraKeyValue
    {
        public int id { get; set; }
        public string value { get; set; }
    }
}
