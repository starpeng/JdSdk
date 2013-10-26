#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:50.74646 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// 针对赠品、加价购会出现相同的item
    /// </summary>
    [Serializable]
    public class Item : JdObject
    {
        /// <summary>
        /// 京东内部SKU的ID
        /// </summary>
        [XmlElement("sku_id")]
        [JsonProperty("sku_id")]
        public String SkuId
        {
            get;
            set;
        }

        /// <summary>
        /// SKU外部ID
        /// </summary>
        [XmlElement("outer_sku_id")]
        [JsonProperty("outer_sku_id")]
        public String OuterSkuId
        {
            get;
            set;
        }

        /// <summary>
        /// 商品的名称+SKU规格（比如艾米AMII2013秋装撞色休闲个性立体挖袋中长款T恤11300247 灰色 S）
        /// </summary>
        [XmlElement("sku_name")]
        [JsonProperty("sku_name")]
        public String SkuName
        {
            get;
            set;
        }

        /// <summary>
        /// SKU的京东价，优惠之前的
        /// </summary>
        [XmlElement("jd_price")]
        [JsonProperty("jd_price")]
        public String JdPrice
        {
            get;
            set;
        }

        /// <summary>
        /// 赠送积分
        /// </summary>
        [XmlElement("gift_point")]
        [JsonProperty("gift_point")]
        public String GiftPoint
        {
            get;
            set;
        }

        /// <summary>
        /// 京东内部商品ID
        /// </summary>
        [XmlElement("ware_id")]
        [JsonProperty("ware_id")]
        public String WareId
        {
            get;
            set;
        }

        /// <summary>
        /// 数量
        /// </summary>
        [XmlElement("item_total")]
        [JsonProperty("item_total")]
        public String ItemTotal
        {
            get;
            set;
        }

        /// <summary>
        /// 商品货号
        /// </summary>
        [XmlElement("product_no")]
        [JsonProperty("product_no")]
        public String ProductNo
        {
            get;
            set;
        }

    }
}
