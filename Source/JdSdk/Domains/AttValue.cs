#region head comment
/*
Code generate by JdSdkTool.
2013-01-31 10:56:47:856 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// AttValue结构
    /// </summary>
    [Serializable]
    public class AttValue : JdObject
    {
        /// <summary>
        /// 属性id
        /// </summary>
        /// <example>2323</example>
        [XmlElement("aid")]
        [JsonProperty("aid")]
        public Nullable<Int64> Aid
        {
            get;
            set;
        }

        /// <summary>
        /// 属性值id
        /// </summary>
        /// <example>12314</example>
        [XmlElement("vid")]
        [JsonProperty("vid")]
        public Nullable<Int64> Vid
        {
            get;
            set;
        }

        /// <summary>
        /// 属性值名字
        /// </summary>
        [XmlElement("name")]
        [JsonProperty("name")]
        public String Name
        {
            get;
            set;
        }

        /// <summary>
        /// 状态（deleted，unvalid，valid）
        /// </summary>
        /// <example>unvalid</example>
        [XmlElement("status")]
        [JsonProperty("status")]
        public String Status
        {
            get;
            set;
        }

        /// <summary>
        /// 排序(越小越靠前)
        /// </summary>
        [XmlElement("index_id")]
        [JsonProperty("index_id")]
        public Nullable<Int64> IndexId
        {
            get;
            set;
        }

    }
}
