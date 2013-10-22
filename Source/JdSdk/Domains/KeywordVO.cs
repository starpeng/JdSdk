#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:02:04.78327 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// KeywordVO属性
    /// </summary>
    [Serializable]
    public class KeywordVO : JdObject
    {
        /// <summary>
        /// 关键词组id
        /// </summary>
        /// <example>172039622990626</example>
        [XmlElement("wgroupId")]
        [JsonProperty("wgroupId")]
        public Int64 WgroupId
        {
            get;
            set;
        }

        /// <summary>
        /// 关键词组所属分类id
        /// </summary>
        /// <example>“3962”</example>
        [XmlElement("categoryId")]
        [JsonProperty("categoryId")]
        public String CategoryId
        {
            get;
            set;
        }

        /// <summary>
        /// 关键词组名
        /// </summary>
        /// <example>“其他”</example>
        [XmlElement("name")]
        [JsonProperty("name")]
        public String Name
        {
            get;
            set;
        }

        /// <summary>
        /// 关键词组出价
        /// </summary>
        /// <example>1.2</example>
        [XmlElement("price")]
        [JsonProperty("price")]
        public Int64 Price
        {
            get;
            set;
        }

        /// <summary>
        /// 关键词组基准价
        /// </summary>
        /// <example>0.1</example>
        [XmlElement("basePrice")]
        [JsonProperty("basePrice")]
        public Int64 BasePrice
        {
            get;
            set;
        }

        /// <summary>
        /// 关键词组类型
        /// </summary>
        /// <example>5</example>
        [XmlElement("type")]
        [JsonProperty("type")]
        public Int64 Type
        {
            get;
            set;
        }

    }
}
