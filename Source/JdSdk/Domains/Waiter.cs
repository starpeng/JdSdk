#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:50.75446 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// Waiter  属性
    /// </summary>
    [Serializable]
    public class Waiter : JdObject
    {
        /// <summary>
        /// 客服账号
        /// </summary>
        /// <example></example>
        [XmlElement("waiter")]
        [JsonProperty("waiter")]
        public String WaiterId
        {
            get;
            set;
        }

        /// <summary>
        /// 是否授权
        /// </summary>
        /// <example></example>
        [XmlElement("yn")]
        [JsonProperty("yn")]
        public String Yn
        {
            get;
            set;
        }

        /// <summary>
        /// 是否管理员。true：是 false：否
        /// </summary>
        /// <example></example>
        [XmlElement("leader")]
        [JsonProperty("leader")]
        public Boolean Leader
        {
            get;
            set;
        }

        /// <summary>
        /// 客服等级
        /// </summary>
        /// <example></example>
        [XmlElement("level")]
        [JsonProperty("level")]
        public String Level
        {
            get;
            set;
        }

        /// <summary>
        /// 统计日期
        /// </summary>
        [XmlElement("date")]
        [JsonProperty("date")]
        public String DateTime
        {
            get;
            set;
        }

        /// <summary>
        /// 在线时长，单位：秒
        /// </summary>
        [XmlElement("result")]
        [JsonProperty("result")]
        public String Result
        {
            get;
            set;
        }

    }
}
