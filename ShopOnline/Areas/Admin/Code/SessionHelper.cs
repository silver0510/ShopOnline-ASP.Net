using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopOnline.Areas.Admin.Code
{
    public class SessionHelper
    {
        public static void SetSession(UserSesstion session)
        {
            HttpContext.Current.Session["loginSession"] = session;
        }

        public static UserSesstion GetSession()
        {
            var session = HttpContext.Current.Session["loginSession"];
            if (session == null)
            {
                return null;
            }
            else
            {
                return session as UserSesstion;
            }
                
        }
    }
}