using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using HtmlAgilityPack;
using Newtonsoft.Json;
using Norem.Models;
using RestSharp;

namespace Norem.Controllers
{
    public class SessionManager
    {
        private readonly CookieContainer m_CookieContainer = new CookieContainer();

        /// <summary>
        /// FactionMap maps a Pox Nora integer (key) to the corresponding Norem Faction enumeration (value).
        /// </summary>
        private readonly Dictionary<int, Faction> m_FactionMap = new Dictionary<int, Faction>();

        private readonly Dictionary<int, Rarity> m_RarityMap = new Dictionary<int, Rarity>();
        private List<Rune> m_Runes = new List<Rune>();
        private readonly RestClient m_Client;
        private string m_Username;

        public List<Rune> Runes
        {
            get { return m_Runes; }
            set { m_Runes = new List<Rune>(value); }
        }

        public string Username
        {
            get { return m_Username; }
            set { m_Username = value; }
        }

        public SessionManager(string username)
        {
            m_Username = username;
            m_Client = new RestClient(Constants.URLPoxnora);
            m_Client.CookieContainer = m_CookieContainer;
        }

        public bool CheckLogin()
        {
            // make a request to the login screen and look for the username
            RestRequest loginRequest = new RestRequest(Constants.URLLogin);
            RestResponse loginResponse = (RestResponse) m_Client.Execute(loginRequest);
            HtmlDocument loginDoc = new HtmlDocument();
            loginDoc.LoadHtml(loginResponse.Content);
            string xpath = "//div[@class=\"myprofile_menu\"]/span[span=\"" + m_Username + "\"]";
            var result = loginDoc.DocumentNode.SelectSingleNode(xpath);
            return result != null;
        }

        public bool DoLogin(string password)
        {
            // first make a request to the login screen
            RestRequest loginRequest = new RestRequest(Constants.URLLogin);
            RestResponse loginResponse = (RestResponse) m_Client.Execute(loginRequest);
            HtmlDocument loginDoc = new HtmlDocument();
            loginDoc.LoadHtml(loginResponse.Content);

            // parse the login page to find the hidden token
            HtmlNode loginHiddenToken = loginDoc.DocumentNode.SelectSingleNode("//input[@type='hidden']");

            //string endpoint = String.Format(m_Constants.URLLoginDo, m_Username, password, loginHiddenToken.Attributes["name"].Value, loginHiddenToken.Attributes["value"].Value);
            //RestRequest doLoginRequest = new RestRequest(endpoint, Method.POST);
            RestRequest doLoginRequest = new RestRequest(Constants.URLLoginDo, Method.POST);
            doLoginRequest.AddQueryParameter("username", m_Username);
            doLoginRequest.AddQueryParameter("password", password);
            doLoginRequest.AddQueryParameter(loginHiddenToken.Attributes["name"].Value,
                loginHiddenToken.Attributes["value"].Value);

            IRestResponse doLoginResponse = m_Client.Execute(doLoginRequest);

            return CheckLogin();
        }

        private void PopulateRunes(PoxNoraRune[] pnRunes, RuneType runeType)
        {
            foreach (PoxNoraRune item in pnRunes)
            {
                // create a Rune object by populating it with data from the PoxNoraRune object
                Rune r = new Rune
                {
                    Name = item.Name,
                    BaseID = item.BaseID,
                    Factions = new List<Faction>(item.Factions.Select(faction => m_FactionMap[faction])),
                    Rarity = m_RarityMap[item.Rarity],
                    RuneType = runeType,
                };
                m_Runes.Add(r);
            }
        }

        /// <summary> FetchGlobalData returns the json data from the "Rune Forge" page.
        /// 
        /// </summary>
        /// <returns></returns>
        public void FetchGlobalData()
        {
            // fetches all rune data from the Pox Nora rune forge
            // generate epoch time
            TimeSpan t = DateTime.UtcNow - new DateTime(1970, 1, 1);
            int secondsSinceEpoch = (int) t.TotalSeconds;
            // format 
            RestRequest forgeRequest = new RestRequest(string.Format(Constants.URLFetchForge, secondsSinceEpoch));
            RestResponse forgeResponse = (RestResponse) m_Client.Execute(forgeRequest);
            PoxNoraForgeJSON parsedJSON = JsonConvert.DeserializeObject<PoxNoraForgeJSON>(forgeResponse.Content);

            foreach (PoxNoraKeyValue item in parsedJSON.Factions)
                m_FactionMap.Add(item.ID, FactionExt.ToFaction(item.Value));
            foreach (PoxNoraKeyValue item in parsedJSON.Rarities)
                m_RarityMap.Add(item.ID, RarityExt.ToRarity(item.Value));

            PopulateRunes(parsedJSON.Champions,RuneType.Champion);
            m_Runes.First().GetForgeValues(m_Client);
            PopulateRunes(parsedJSON.Spells, RuneType.Spell);
            PopulateRunes(parsedJSON.Relics, RuneType.Relic);
            PopulateRunes(parsedJSON.Equipment, RuneType.Equipment);
        }
    }
}