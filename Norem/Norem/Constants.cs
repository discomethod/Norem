﻿namespace Norem
{
    class Constants
    {
        public string URLLogin { get { return "/security/login.do"; } } // url for the login display page
        //public string URLLoginDo { get { return "/security/dologin.do?username={0}&password={1}&{2}={3}";  } } // url for submitting the login form
        public string URLLoginDo { get { return "/security/dologin.do"; } } // url for submitting the login form
        public string URLPoxnora { get { return "http://www.poxnora.com"; } }
    }
}