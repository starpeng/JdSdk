#region CopyRight
/**************************************************************
   Copyright (c) 2012 StarPeng. All rights reserved.
   CLR版本        :    4.0.30319.269
   命名空间名称   :    WebSample
   文件名         :    DoSomeThing
   创建时间       :    2012/6/29 18:15:17
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
using System.Web.UI.WebControls;
using JdSdk;

namespace WebSample
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Utility.IsAccessTokenValid(AppContext.AccessToken))
            {
                //有效 做你想做的事
                lbMessage.Text = AppContext.AccessToken.Token;
            }
            else
            {
                if (String.IsNullOrEmpty(AppContext.AppKey)
                    || String.IsNullOrEmpty(AppContext.AppSecret)
                    || String.IsNullOrEmpty(AppContext.CallbackUrl))
                {
                    Response.Redirect("~/setting.aspx");
                }

                //失效了再获取或者用refreshToken刷新 
                //refreshToken没有测试过
                OAuth oauth = new OAuth(AppContext.AppKey, AppContext.AppSecret, AppContext.CallbackUrl);
                Response.Redirect(oauth.GetAuthorizationUrl());

            }
        }
    }
}





