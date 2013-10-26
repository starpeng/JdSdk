#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:50.75546 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// PassLog 属性
    /// </summary>
    [Serializable]
    public class PassLog : JdObject
    {
        /// <summary>
        /// 客服账号
        /// </summary>
        [XmlElement("waiter")]
        [JsonProperty("waiter")]
        public String Waiter
        {
            get;
            set;
        }

        /// <summary>
        /// 登录时间
        /// </summary>
        [XmlElement("loginTime")]
        [JsonProperty("loginTime")]
        public Nullable<DateTime> LoginTime
        {
            get;
            set;
        }

        /// <summary>
        /// 退出时间
        /// </summary>
        [XmlElement("logoutTime")]
        [JsonProperty("logoutTime")]
        public Nullable<DateTime> LogoutTime
        {
            get;
            set;
        }

        /// <summary>
        /// 登录ip
        /// </summary>
        [XmlElement("ip")]
        [JsonProperty("ip")]
        public String Ip
        {
            get;
            set;
        }

        /// <summary>
        /// 登录sid
        /// </summary>
        [XmlElement("loginSid")]
        [JsonProperty("loginSid")]
        public String LoginSid
        {
            get;
            set;
        }

        /// <summary>
        /// 统计日期
        /// </summary>
        /// <example></example>
        [XmlElement("date")]
        [JsonProperty("date")]
        public String DateTime
        {
            get;
            set;
        }

        /// <summary>
        /// 接待量
        /// </summary>
        /// <example></example>
        [XmlElement("result")]
        [JsonProperty("result")]
        public String Result
        {
            get;
            set;
        }

    }
}
