using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// 促销SKU属性
    /// </summary>
    [Serializable]
    public class PromoSkuVO : JdObject
    {
        ﻿        /// <summary>
        /// 商品编号
        /// </summary>
        /// <example>123</example>
        [XmlElement("ware_id")]
        [JsonProperty("ware_id")]
        public Nullable<Int64> WareId
        {
            get;
            set;
        }

        /// <summary>
        /// 商品货号
        /// </summary>
        /// <example>456</example>
        [XmlElement("item_num")]
        [JsonProperty("item_num")]
        public String ItemNum
        {
            get;
            set;
        }

        /// <summary>
        /// SKU编号
        /// </summary>
        /// <example>654321</example>
        [XmlElement("sku_id")]
        [JsonProperty("sku_id")]
        public Nullable<Int64> SkuId
        {
            get;
            set;
        }

        /// <summary>
        /// SKU名称
        /// </summary>
        /// <example>红星二锅头</example>
        [XmlElement("sku_name")]
        [JsonProperty("sku_name")]
        public String SkuName
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
        public Nullable<Int64> PromoId
        {
            get;
            set;
        }

        /// <summary>
        /// 京东价，以元为单位，精确到小数点后一位
        /// </summary>
        /// <example>20.0</example>
        [XmlElement("jd_price")]
        [JsonProperty("jd_price")]
        public String JdPrice
        {
            get;
            set;
        }

        /// <summary>
        /// 促销价，以元为单位，精确到小数点后一位，且必须小于京东价（注：1.套装促销必填；2.fbp商家设置赠品促销时，赠品SKU的该字段必填，将作为订单拆分价使用；3.单品促销选填，不填时系统将默认设置为京东价，此时单品促销必须添加促销道具；4.其它促销不需要设置。）
        /// </summary>
        /// <example>18.8</example>
        [XmlElement("promo_price")]
        [JsonProperty("promo_price")]
        public String PromoPrice
        {
            get;
            set;
        }

        /// <summary>
        /// 套装商品展示次序，相同商品的SKU上次序必须一致。（只对套装促销有效）
        /// </summary>
        [XmlElement("seq")]
        [JsonProperty("seq")]
        public Nullable<Int64> Seq
        {
            get;
            set;
        }

        /// <summary>
        /// 赠品赠送数量，只能送1-3个。(只对赠品促销有效)
        /// </summary>
        /// <example>1</example>
        [XmlElement("num")]
        [JsonProperty("num")]
        public Nullable<Int64> Num
        {
            get;
            set;
        }

        /// <summary>
        /// 绑定类型, 可选值：主商品（1），赠品（2）。(赠品促销、满减送促销中的赠品需要设置为2，其余均设置为1)
        /// </summary>
        /// <example>1</example>
        [XmlElement("bind_type")]
        [JsonProperty("bind_type")]
        public Nullable<Int64> BindType
        {
            get;
            set;
        }
    }
}
