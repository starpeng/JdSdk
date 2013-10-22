#region head comment
/*
Code generate by JdSdkTool.
2013-01-31 10:56:47:855 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// CouponDetail结构
    /// </summary>
    [Serializable]
    public class CouponDetail : JdObject
    {
        /// <summary>
        /// 优惠金额
        /// </summary>
        [XmlElement("coupon_price")]
        [JsonProperty("coupon_price")]
        public String CouponPrice
        {
            get;
            set;
        }

        /// <summary>
        /// 优惠类型:20-套装优惠, 29-团购优惠, 30-单品促销优惠, 35-满返满送(返现)
        /// </summary>
        [XmlElement("coupon_type")]
        [JsonProperty("coupon_type")]
        public String CouponType
        {
            get;
            set;
        }

        /// <summary>
        /// 订单编号
        /// </summary>
        [XmlElement("order_id")]
        [JsonProperty("order_id")]
        public String OrderId
        {
            get;
            set;
        }

        /// <summary>
        /// 京东sku编号
        /// </summary>
        [XmlElement("sku_id")]
        [JsonProperty("sku_id")]
        public String SkuId
        {
            get;
            set;
        }

    }
}
