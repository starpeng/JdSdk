#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:50.75346 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// WaiterDailyEvaStat 属性
    /// </summary>
    [Serializable]
    public class WaiterDailyEvaStat : JdObject
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
        /// 评价得分 0 ：非常不满意 25 ：不满意 50 ：一般 75 ：满意 100：非常满意
        /// </summary>
        /// <example></example>
        [XmlElement("score")]
        [JsonProperty("score")]
        public Int32 Score
        {
            get;
            set;
        }

        /// <summary>
        /// 数量
        /// </summary>
        /// <example></example>
        [XmlElement("count")]
        [JsonProperty("count")]
        public Int32 Count
        {
            get;
            set;
        }

    }
}
