#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:50.75246 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// Evaluation 属性
    /// </summary>
    [Serializable]
    public class Evaluation : JdObject
    {
        /// <summary>
        /// 咨询的顾客
        /// </summary>
        [XmlElement("customer")]
        [JsonProperty("customer")]
        public String Customer
        {
            get;
            set;
        }

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
        /// 评价语
        /// </summary>
        [XmlElement("desc")]
        [JsonProperty("desc")]
        public String Desc
        {
            get;
            set;
        }

        /// <summary>
        /// 评价得分。 0 ：非常不满意； 25 ：不满意； 50 ：一般； 75 ：满意 100：非常满意
        /// </summary>
        [XmlElement("score")]
        [JsonProperty("score")]
        public Int64 Score
        {
            get;
            set;
        }

        /// <summary>
        /// 评价时间
        /// </summary>
        [XmlElement("evaTime")]
        [JsonProperty("evaTime")]
        public Nullable<DateTime> EvaTime
        {
            get;
            set;
        }

    }
}
