#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:02:04.79027 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// ActivityModeVO属性
    /// </summary>
    [Serializable]
    public class ActivityModeVO : JdObject
    {
        /// <summary>
        /// 活动规则编号
        /// </summary>
        /// <example>654321</example>
        [XmlElement("id")]
        [JsonProperty("id")]
        public Int64 Id
        {
            get;
            set;
        }

        /// <summary>
        /// 促销编号
        /// </summary>
        /// <example>123456</example>
        [XmlElement("promo_id")]
        [JsonProperty("promo_id")]
        public Int64 PromoId
        {
            get;
            set;
        }

        /// <summary>
        /// 参与促销的SKU总数量
        /// </summary>
        /// <example>10</example>
        [XmlElement("num_bound")]
        [JsonProperty("num_bound")]
        public Int64 NumBound
        {
            get;
            set;
        }

        /// <summary>
        /// 是否限购一个
        /// </summary>
        /// <example>0</example>
        [XmlElement("freq_bound")]
        [JsonProperty("freq_bound")]
        public Int64 FreqBound
        {
            get;
            set;
        }

        /// <summary>
        /// 单次最多可购数量
        /// </summary>
        /// <example>3</example>
        [XmlElement("per_max_num")]
        [JsonProperty("per_max_num")]
        public Int64 PerMaxNum
        {
            get;
            set;
        }

        /// <summary>
        /// 单次最少可购数量
        /// </summary>
        /// <example>1</example>
        [XmlElement("per_min_num")]
        [JsonProperty("per_min_num")]
        public Int64 PerMinNum
        {
            get;
            set;
        }

    }
}
