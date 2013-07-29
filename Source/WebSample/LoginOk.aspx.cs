#region CopyRight
/**************************************************************
   Copyright (c) 2012 StarPeng. All rights reserved.
   CLR版本        :    4.0.30319.269
   命名空间名称   :    WebSample
   文件名         :    LoginOk
   创建时间       :    2012/6/29 16:59:29
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
using System.Web;
using System.Web.UI;
using JdSdk;

namespace WebSample
{
    public partial class LoginOk : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                if (!String.IsNullOrEmpty(Request.QueryString["code"]))
                {
                    String code = Request.QueryString["code"];
                    String appKey = Application.Get("OAuthAppKey") as String;
                    String appSecret = Application.Get("OAuthAppSecret") as String;
                    String callbackUrl = Application.Get("OAuthCallbackUrl") as String;
                    OAuth oauth = new OAuth(appKey, appSecret, callbackUrl);
                    AccessToken accessToken = oauth.GetAccessTokenByAuthorizationCode(code);
                    if (accessToken == null)
                    {
                        this.lbMessage.Text = "获取AccessToken,失败，原因未知！";
                    }

                    if (!String.IsNullOrEmpty(accessToken.ErrorMessage))
                    {
                        this.lbMessage.Text = "获取AccessToken,失败：" + accessToken.ErrorMessage;
                    }

                    AppContext.AppKey = appKey;
                    AppContext.AppSecret = appSecret;
                    AppContext.CallbackUrl = callbackUrl;
                    AppContext.AccessToken = accessToken;
                    Response.Redirect("~/default.aspx");
                }
                else
                {

                }
            }
        }
    }
}





