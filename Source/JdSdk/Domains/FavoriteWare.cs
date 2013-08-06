#region head comment
/*
Code generate by JdSdkTool.
2013-04-03 12:45:25.18078 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// FavoriteWare结构
    /// </summary>
    [Serializable]
    public class FavoriteWare : JdObject
    {
        /// <summary>
        /// 商品id
        /// </summary>
        /// <example>1001001</example>
        [XmlElement("ware_id")]
        [JsonProperty("ware_id")]
        public Nullable<Int64> WareId
        {
            get;
            set;
        }

        /// <summary>
        /// 商品名称
        /// </summary>
        /// <example>联想IdeaPad Amor系列14寸单肩包T1645</example>
        [XmlElement("ware_name")]
        [JsonProperty("ware_name")]
        public String WareName
        {
            get;
            set;
        }

        /// <summary>
        /// 商品价格
        /// </summary>
        /// <example>12.88</example>
        [XmlElement("price")]
        [JsonProperty("price")]
        public String Price
        {
            get;
            set;
        }

        /// <summary>
        /// 广告词
        /// </summary>
        /// <example>高性价比低端</example>
        [XmlElement("ad_word")]
        [JsonProperty("ad_word")]
        public String AdWord
        {
            get;
            set;
        }

        /// <summary>
        /// m版的url地址
        /// </summary>
        [XmlElement("m_url")]
        [JsonProperty("m_url")]
        public String MUrl
        {
            get;
            set;
        }

    }
}
