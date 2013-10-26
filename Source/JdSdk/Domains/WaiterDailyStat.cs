#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:50.75646 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// WaiterDailyStat 属性
    /// </summary>
    [Serializable]
    public class WaiterDailyStat : JdObject
    {
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
        /// 客服账号
        /// </summary>
        /// <example></example>
        [XmlElement("waiter")]
        [JsonProperty("waiter")]
        public String Waiter
        {
            get;
            set;
        }

        /// <summary>
        /// 未回复量
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
