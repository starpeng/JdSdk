#region head comment
/*
Code generate by JdSdkTool.
2013-01-31 10:56:47:855 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// category结构
    /// </summary>
    [Serializable]
    public class Category : JdObject
    {
        /// <summary>
        /// 类目id
        /// </summary>
        /// <example>2323</example>
        [XmlElement("id")]
        [JsonProperty("id")]
        public Nullable<Int64> Id
        {
            get;
            set;
        }

        /// <summary>
        /// 排序（越小越靠前）
        /// </summary>
        /// <example>12314</example>
        [XmlElement("index_id")]
        [JsonProperty("index_id")]
        public Nullable<Int64> IndexId
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
        public Nullable<Int64> Fid
        {
            get;
            set;
        }

        /// <summary>
        /// 类目名称
        /// </summary>
        [XmlElement("name")]
        [JsonProperty("name")]
        public String Name
        {
            get;
            set;
        }

        /// <summary>
        /// 该类目是否为父类目(即：该类目是否还有子类目)
        /// </summary>
        /// <example>true</example>
        [XmlElement("Is_parent")]
        [JsonProperty("Is_parent")]
        public Nullable<Boolean> IsParent
        {
            get;
            set;
        }

        /// <summary>
        /// 类目状态（deleted，unvalid, valid）
        /// </summary>
        /// <example>valid</example>
        [XmlElement("status")]
        [JsonProperty("status")]
        public String Status
        {
            get;
            set;
        }

        /// <summary>
        /// 等级(类目分为1、2、3级)
        /// </summary>
        /// <example>1</example>
        [XmlElement("lev")]
        [JsonProperty("lev")]
        public Nullable<Int64> Lev
        {
            get;
            set;
        }

    }
}
