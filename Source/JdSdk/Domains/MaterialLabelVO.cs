#region head comment
/*
Code generate by JdSdkTool.
2013-12-21 10:57:01.22344 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// MaterialLabelVO属性
    /// </summary>
    [Serializable]
    public class MaterialLabelVO : JdObject
    {
        /// <summary>
        /// 标签Id
        /// </summary>
        /// <example>434232</example>
        [XmlElement("id")]
        [JsonProperty("id")]
        public Int64 Id
        {
            get;
            set;
        }

        /// <summary>
        /// cpd 按天买断价格
        /// </summary>
        /// <example>2</example>
        [XmlElement("label_buyoutPrice")]
        [JsonProperty("label_buyoutPrice")]
        public Int64 LabelBuyoutPrice
        {
            get;
            set;
        }

        /// <summary>
        /// cpc价格按点击价格（/次）
        /// </summary>
        /// <example>0.1</example>
        [XmlElement("label_cpcPrice")]
        [JsonProperty("label_cpcPrice")]
        public Int64 LabelCpcPrice
        {
            get;
            set;
        }

        /// <summary>
        /// 标签名字
        /// </summary>
        /// <example>爆款</example>
        [XmlElement("label_name")]
        [JsonProperty("label_name")]
        public String LabelName
        {
            get;
            set;
        }

    }
}
