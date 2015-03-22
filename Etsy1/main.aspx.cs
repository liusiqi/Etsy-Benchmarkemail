using iServe.Models.F1APIServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Etsy1
{
    public partial class main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string baseUrl = "https://openapi.etsy.com/";
            string APIversion = "v2/oauth/request_token";
            string KEYSTRING = "ejjtjzd5dj5qqmfsw8fdb5ot";
            string SHARED_SECRET = "7o80ayl8y7";
            OAuthUtil oauth = new OAuthUtil(baseUrl, "", APIversion, "", KEYSTRING, SHARED_SECRET);
            Token result = oauth.GetRequestToken();
            string temp = result.Value.ToString();
            Response.Write(temp);
        }
    }
}