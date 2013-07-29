#region CopyRight
/**************************************************************
   Copyright (c) 2012 StarPeng. All rights reserved.
   CLR版本        :    4.0.30319.269
   命名空间名称   :    WebSample
   文件名         :    Utility
   创建时间       :    2012/6/29 16:47:35
   用户所在的域   :    SWKEJIT410
   登录用户名     :    Star
   文件描述       :    
   版本           :    1.0.0
   历史           :    
   最后更新人     :   
   最后更新时间   :   
 **************************************************************/
#endregion CopyRight

using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using JdSdk;

namespace WebSample
{
    public class Utility
    {
        public static void MessageBox(string message)
        {
            message = message ?? "";
            message = message.Replace("\r", "");
            message = message.Replace("\n", "");
            message = message.Replace("'", "\\'");

            if (!String.IsNullOrEmpty(message))
            {
                System.Web.UI.Page page = System.Web.HttpContext.Current.Handler as System.Web.UI.Page;
                if (page != null)
                    page.ClientScript.RegisterStartupScript(typeof(Utility), "AlertError", "<script language=javascript>alert('" + message + "')</script>");
            }
        }

        public static Boolean IsAccessTokenValid(AccessToken accessToken)
        {
            return (accessToken != null) && (accessToken.CreateTime.AddMilliseconds(accessToken.ExpiresIn) > DateTime.Now);
        }

    }
}





