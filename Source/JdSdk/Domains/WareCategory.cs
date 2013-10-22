#region head comment
/*
Code generate by JdSdkTool.
2013-04-03 12:45:25.18478 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// WareCategory结构
    /// </summary>
    [Serializable]
    public class WareCategory : JdObject
    {
        /// <summary>
        /// 类目id，默认为0
        /// </summary>
        /// <example>2323</example>
        [XmlElement("cid")]
        [JsonProperty("cid")]
        public Nullable<Int64> Cid
        {
            get;
            set;
        }

        /// <summary>
        /// 父类目id
        /// </summary>
        /// <example>123122</example>
        [XmlElement("fid")]
        [JsonProperty("fid")]
        public Nullable<Decimal> Fid
        {
            get;
            set;
        }

        /// <summary>
        /// 等级(类目分为1、2、3级，对应值为0、1、2)
        /// </summary>
        /// <example>1</example>
        [XmlElement("level")]
        [JsonProperty("level")]
        public Nullable<Decimal> Level
        {
            get;
            set;
        }

        /// <summary>
        /// 类目名称
        /// </summary>
        /// <example>男装</example>
        [XmlElement("name")]
        [JsonProperty("name")]
        public String Name
        {
            get;
            set;
        }

        /// <summary>
        /// 排序（越小越靠前）
        /// </summary>
        /// <example>12314</example>
        [XmlElement("index")]
        [JsonProperty("index")]
        public Nullable<Decimal> Index
        {
            get;
            set;
        }

    }
}
