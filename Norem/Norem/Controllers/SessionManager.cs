using HtmlAgilityPack;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Norem.Controllers
{
    class SessionManager
    {
        private Constants m_Constants = new Constants();
        private CookieContainer m_CookieContainer = new CookieContainer();
        private RestClient m_Client;
        private RuneManager m_RuneManager = new RuneManager();
        private string m_Username;

        public string Username
        {
            get { return m_Username; }
            set { m_Username = value; }
        }

        public SessionManager(string username)
        {
            m_Username = username;
            m_Client = new RestClient(m_Constants.URLPoxnora);
            m_Client.CookieContainer = m_CookieContainer;
        }

        public bool CheckLogin()
        {
            // make a request to the login screen and look for the username
            RestRequest loginRequest = new RestRequest(m_Constants.URLLogin);
            RestResponse loginResponse = (RestResponse)m_Client.Execute(loginRequest);
            HtmlDocument loginDoc = new HtmlDocument();
            loginDoc.LoadHtml(loginResponse.Content);
            string xpath = "//div[@class=\"myprofile_menu\"]/span[span=\"" + m_Username + "\"]";
            var result = loginDoc.DocumentNode.SelectSingleNode(xpath);
            return  result != null;
        }

        public bool DoLogin(string password)
        {
            // first make a request to the login screen
            RestRequest loginRequest = new RestRequest(m_Constants.URLLogin);
            RestResponse loginResponse = (RestResponse) m_Client.Execute(loginRequest);
            HtmlDocument loginDoc = new HtmlDocument();
            loginDoc.LoadHtml(loginResponse.Content);

            // parse the login page to find the hidden token
            HtmlNode loginHiddenToken = loginDoc.DocumentNode.SelectSingleNode("//input[@type='hidden']");

            //string endpoint = String.Format(m_Constants.URLLoginDo, m_Username, password, loginHiddenToken.Attributes["name"].Value, loginHiddenToken.Attributes["value"].Value);
            //RestRequest doLoginRequest = new RestRequest(endpoint, Method.POST);
            RestRequest doLoginRequest = new RestRequest(m_Constants.URLLoginDo, Method.POST);
            doLoginRequest.AddQueryParameter("username", m_Username);
            doLoginRequest.AddQueryParameter("password", password);
            doLoginRequest.AddQueryParameter(loginHiddenToken.Attributes["name"].Value, loginHiddenToken.Attributes["value"].Value);

            IRestResponse doLoginResponse = m_Client.Execute(doLoginRequest);

            return CheckLogin();
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
            int secondsSinceEpoch = (int)t.TotalSeconds;
            // format 
            RestRequest forgeRequest = new RestRequest(string.Format(m_Constants.URLFetchForge, secondsSinceEpoch));
            RestResponse forgeResponse = (RestResponse) m_Client.Execute(forgeRequest);
            File.WriteAllText("out.json", forgeResponse.Content);
            return;
        }
    }
}
