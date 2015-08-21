using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Norem.Models
{
    // model of a rune based on the JSON returned by Pox Nora
    public class PoxNoraRune
    {
        private List<int> m_Clazzes;
        public List<int> clazzes
        {
            get { return m_Clazzes; }
            set { m_Clazzes = new List<int>(value); }
        }
        private List<int> m_Races;
        public List<int> races
        {
            get { return m_Races; }
            set { m_Races = new List<int>(value); }
        }
        private int m_ID;
        public int id
        {
            get { return m_ID; }
            set { m_ID = value; }
        }
        private int m_BaseID;
        public int baseID
        {
            get { return m_BaseID; }
            set { m_BaseID = value; }
        }
        private string m_Name;
        public string Name
        {
            get { return m_Name; }
            set { m_Name = value; }
        }
        private int m_Count;
        public int count
        {
            get { return m_Count; }
            set { m_Count = value; }
        }
        private int m_Rarity;
        public int rarity
        {
            get { return m_Rarity; }
            set { m_Rarity = value; }
        }
        private int m_Release;
        public int release
        {
            get { return m_Release; }
            set { m_Release = value; }
        }
        private List<int> m_Factions;
        public List<int> factions
        {
            get { return m_Factions; }
            set { m_Factions = new List<int>(value); }
        }

    }
}
