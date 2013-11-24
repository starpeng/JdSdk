#region CopyRight
/**************************************************************
   Copyright (c) 2012 StarPeng. All rights reserved.
   CLR版本        :    4.0.30319.225
   命名空间名称   :    WinFormsSample
   文件名         :    AppContext
   创建时间       :    2012/7/1 10:43:02
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
using System.Text;
using JdSdk;
using System.Configuration;

namespace WinFormsSample
{
    internal static class AppContext
    {
        private const String APPKEY_SETTING = "AppKey";
        private const String APPSECRET_SETTING = "AppSecret";
        private static Configuration _config;

        public readonly static String ServerURL = "http://gw.api.sandbox.360buy.com/routerjson";
        public readonly static String AuthorizeUrl = "http://auth.sandbox.360buy.com/oauth/authorize";
        public readonly static String AccessTokenUrl = "http://auth.sandbox.360buy.com/oauth/token";

        static AppContext()
        {
            _config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            AppKey = GetAppSetting(APPKEY_SETTING);
            AppSecret = GetAppSetting(APPSECRET_SETTING);
        }

        public static String AppKey
        {
            get;
            set;
        }

        public static String AppSecret
        {
            get;
            set;
        }

        public static String CallbackUrl
        {
            get;
            set;
        }

        public static JdSdk.AccessToken AccessToken
        {
            get;
            set;
        }

        public static Boolean CheckAccessToken()
        {
            return (AppContext.AccessToken != null) && (AppContext.AccessToken.CreateTime.AddMilliseconds(AppContext.AccessToken.ExpiresIn) > DateTime.Now);
        }

        internal static void Save()
        {
            _config.AppSettings.Settings.Remove(APPKEY_SETTING);
            _config.AppSettings.Settings.Remove(APPSECRET_SETTING);
            _config.AppSettings.Settings.Add(APPKEY_SETTING, AppKey);
            _config.AppSettings.Settings.Add(APPSECRET_SETTING, AppSecret);
            _config.Save();
        }

        private static String GetAppSetting(String key)
        {
            var appsetting = _config.AppSettings.Settings[key];
            if (appsetting != null)
            {
                return appsetting.Value;
            }

            return null;
        }
    }
}

