#region CopyRight
/**************************************************************
   Copyright (c) 2012 StarPeng. All rights reserved.
   CLR版本        :    4.0.30319.269
   命名空间名称   :    $rootnamespace$
   文件名         :    Default
   创建时间       :    2012/6/29 16:32:09
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
    public partial class Setting : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAuthon_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtAppKey.Text.Trim()))
            {
                Utility.MessageBox("App Key 不能为空！");
                return;
            }

            if (String.IsNullOrEmpty(txtAppSecret.Text.Trim()))
            {
                Utility.MessageBox("App Secret 不能为空！");
                return;
            }

            if (String.IsNullOrEmpty(txtCallbackUrl.Text.Trim()))
            {
                Utility.MessageBox("Callback Url 不能为空！");
                return;
            }
            try
            {
                Uri uri = new Uri(txtCallbackUrl.Text.Trim(), UriKind.Absolute);
                if (!String.Equals(uri.Host, Request.Url.Host))
                {
                    Utility.MessageBox("回调地址与当前主域不匹配！");
                    return;
                }
            }
            catch (UriFormatException ex)
            {
                Utility.MessageBox(ex.Message);
                return;
            }

            OAuth oauth = new OAuth(txtAppKey.Text.Trim(), txtAppSecret.Text.Trim(), txtCallbackUrl.Text.Trim());
            Application.Set("OAuthAppKey",txtAppKey.Text.Trim());
            Application.Set("OAuthAppSecret", txtAppSecret.Text.Trim());
            Application.Set("OAuthCallbackUrl", txtCallbackUrl.Text.Trim());
            Response.Redirect(oauth.GetAuthorizationUrl());
        }
    }
}





