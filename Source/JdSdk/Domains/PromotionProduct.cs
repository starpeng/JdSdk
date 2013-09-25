#region head comment
/*
Code generate by JdSdkTool.
2013-01-31 10:56:47:853 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// PromotionProduct 促销中的商品信息
    /// </summary>
    [Serializable]
    public class PromotionProduct : JdObject
    {
        /// <summary>
        /// skuid
        /// </summary>
        [XmlElement("sku_id")]
        [JsonProperty("sku_id")]
        public Int64 SkuId
        {
            get;
            set;
        }

        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("prod_id")]
        [JsonProperty("prod_id")]
        public String ProdId
        {
            get;
            set;
        }

        /// <summary>
        /// 商品的名称+SKU规格（比如 XXX商品 红色 XL）
        /// </summary>
        [XmlElement("promo_name")]
        [JsonProperty("promo_name")]
        public String PromoName
        {
            get;
            set;
        }

        /// <summary>
        /// 京东价
        /// </summary>
        [XmlElement("price")]
        [JsonProperty("price")]
        public String Price
        {
            get;
            set;
        }

        /// <summary>
        /// 促销价
        /// </summary>
        [XmlElement("promo_price")]
        [JsonProperty("promo_price")]
        public String PromoPrice
        {
            get;
            set;
        }

        /// <summary>
        /// 主、增 (针对套装促销时，需要分那个商品是主商品，那个商品是赠品)
        /// </summary>
        [XmlElement("is_main")]
        [JsonProperty("is_main")]
        public String IsMain
        {
            get;
            set;
        }

    }
}
