namespace Norem
{
    class Constants
    {
        // file path for storing global data files
        public static string FilePathGlobalRunes { get { return "data/global.data"; } } // file path for storing global data files

        /*  url for the fetchging the forge page
            {0} is timestamp, used to avoid caching */
        public static string URLFetchForge { get { return "/runes/load-forge.do?m=forge&_={0}"; } }
        /*  url for fetching an individual rune's information in the forge
            {0} is the id of the rune as descrbied in its JSON
            {1} is the type of the rune, which can be accessed from RuneTypeExt
        */
        public static string URLLaunchForge { get { return @"/runes/launch-forge.do?m=forge&i={0}&t={1}"; } }
        // url for the login display page
        public static string URLLogin { get { return "/security/login.do"; } }
        // url for submitting the login form
        public static string URLLoginDo { get { return "/security/dologin.do"; } }
        public static string URLPoxnora { get { return "http://www.poxnora.com"; } }
    }
}
