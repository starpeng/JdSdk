#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-07-29 22:21:36.42722 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// price_change属性
    /// </summary>
    [Serializable]
    public class PriceChange : JdObject
    {
        /// <summary>
        /// 商品编号
        /// </summary>
        /// <example>J_100012</example>
        [XmlElement("sku_id")]
        [JsonProperty("sku_id")]
        public Int64 SkuId
        {
            get;
            set;
        }

        /// <summary>
        /// 商品价格
        /// </summary>
        /// <example>66.00</example>
        [XmlElement("price")]
        [JsonProperty("price")]
        public String Price
        {
            get;
            set;
        }

        /// <summary>
        /// 市场价
        /// </summary>
        [XmlElement("market_price")]
        [JsonProperty("market_price")]
        public String MarketPrice
        {
            get;
            set;
        }

    }
}
