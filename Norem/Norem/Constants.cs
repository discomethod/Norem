namespace Norem
{
    class Constants
    {
        public string FilePathGlobalRunes {  get { return "data/global.data"; } } // file path for storing global data files

        /*  url for the fetchging the forge page
            {0} is timestamp, used to avoid caching */
        public string URLFetchForge { get { return "/runes/load-forge.do?m=forge&_={0}";  } }
        public string URLLogin { get { return "/security/login.do"; } } // url for the login display page
        public string URLLoginDo { get { return "/security/dologin.do"; } } // url for submitting the login form
        public string URLPoxnora { get { return "http://www.poxnora.com"; } }
    }
}
