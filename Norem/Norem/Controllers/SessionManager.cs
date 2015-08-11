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
            System.IO.File.WriteAllText(@"out.txt", doLoginResponse.Content);

            // var request = new RestRequest(m_Constants.URLLogin);)
            return true;
        }
    }
}
