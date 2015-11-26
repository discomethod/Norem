using System.Collections.Generic;
using Newtonsoft.Json;
using RestSharp;

namespace Norem.Models
{
   
    public class Rune
    {
        private List<Faction> m_Factions;
        public List<Faction> Factions
        {
            get { return m_Factions; }
            set { m_Factions = value; }
        }
        public bool InFaction(Faction faction)
        {
            return m_Factions.Contains(faction);
        }

        private int m_BaseID;

        public int BaseID
        {
            get { return m_BaseID; }
            set { m_BaseID = value; }
        }

        private int m_DeckLimit;
        public int DeckLimit
        {
            get { return m_DeckLimit; }
            set { m_DeckLimit = value; }
        }
        private int m_NoraCost;
        public int NoraCost
        {
            get { return m_NoraCost; }
            set { m_NoraCost = value; }
        }

        private Rarity m_Rarity;
        public Rarity Rarity
        {
            get { return m_Rarity; }
            set { m_Rarity = value; }
        }

        private RuneType m_RuneType;
        public RuneType RuneType
        {
            get { return m_RuneType; }
            set { m_RuneType = value; }
        }

        private string m_Name;
        public string Name
        {
            get { return m_Name; }
            set { m_Name = value; }
        }

        /// <summary>
        /// Retreive the "Trade In" and "Trade Out" forge nora values for this rune.
        /// </summary>
        public void GetForgeValues(RestClient client)
        {
            RestRequest launchForgeRequest = new RestRequest(string.Format(Constants.URLLaunchForge, BaseID, RuneTypeExt.ToPoxNoraIdentifier(RuneType)));
            RestResponse launchForgeResponse = (RestResponse)client.Execute(launchForgeRequest);
            return;
        }
    }
}
