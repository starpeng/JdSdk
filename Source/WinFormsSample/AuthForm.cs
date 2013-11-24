#region CopyRight
/**************************************************************
   Copyright (c) 2012 StarPeng. All rights reserved.
   CLR版本        :    4.0.30319.225
   命名空间名称   :    WinFormsSample
   文件名         :    ConfigForm
   创建时间       :    2012/7/1 10:29:06
   用户所在的域   :    SWKEJIT410
   登录用户名     :    StarPeng
   文件描述       :    
   版本           :    1.0.0
   历史           :    
   最后更新人     :   
   最后更新时间   :   
 **************************************************************/
#endregion CopyRight

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using JdSdk;

namespace WinFormsSample
{
    public partial class AuthForm : Form
    {
        private OAuth oauth;
        /// <summary>
        /// AppKey
        /// </summary>
        public String AppKey { get; private set; }

        /// <summary>
        /// AppSecret
        /// </summary>
        public String AppSecret { get; private set; }

        public AccessToken AccessToken { get; private set; }

        public AuthForm()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtAppKey.Text.Trim()))
            {
                Utility.ShowError("App Key 不能为空！");
                return;
            }

            if (String.IsNullOrEmpty(txtAppSecret.Text.Trim()))
            {
                Utility.ShowError("App Secret 不能为空！");
                return;
            }

            this.AppKey = txtAppKey.Text.Trim();
            this.AppSecret = txtAppSecret.Text.Trim();

            if (String.IsNullOrEmpty(txtAuthCode.Text.Trim()))
            {
                this.AccessToken = null;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                Console.WriteLine("AccessToken未获取！");
                return;
            }

            if (oauth == null)
            {
                oauth = new OAuth(this.AppKey, this.AppSecret);
            }

            AccessToken accessToken = oauth.GetAccessTokenByAccessToken(txtAuthCode.Text.Trim());
            if (accessToken == null)
            {
                Utility.ShowError("获取AccessToken失败，原因未知！");
                return;
            }

            if (!String.IsNullOrEmpty(accessToken.ErrorMessage))
            {
                Utility.ShowError("获取AccessToken失败，失败：" + accessToken.ErrorMessage);
                return;
            }

            this.AccessToken = accessToken;
            Console.WriteLine("获取AccessToken成功！");
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnLink_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtAppKey.Text.Trim()))
            {
                Utility.ShowError("App Key 不能为空！");
                return;
            }

            if (String.IsNullOrEmpty(txtAppSecret.Text.Trim()))
            {
                Utility.ShowError("App Secret 不能为空！");
                return;
            }

            this.AppKey = txtAppKey.Text.Trim();
            this.AppSecret = txtAppSecret.Text.Trim();
            String callBackUrl = "urn:ietf:wg:oauth:2.0:oob";
            oauth = new OAuth(this.AppKey, this.AppSecret, callBackUrl);
            oauth.AuthorizeUrl = AppContext.AuthorizeUrl;
            oauth.AccessTokenUrl = AppContext.AccessTokenUrl;
            Utility.Run(oauth.GetAuthorizationUrl(), null);
            Console.WriteLine("打开授权网页！");
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {
            txtAppKey.Text = AppContext.AppKey;
            txtAppSecret.Text = AppContext.AppSecret;
        }
    }
}

