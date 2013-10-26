#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:01:57.07083 +08:00
*/
#endregion

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using JdSdk.Response;
using Newtonsoft.Json;

namespace JdSdk.Request
{
    /// <summary>
    /// 添加参加促销的sku，最多支持300个SKU，当基于套装促销添加SKU时，最多可设置3个商品的SKU，并且相同商品的次序要一致；当基于赠品促销添加SKU时，赠品SKU只能是1-5个，每个赠品只能赠送1-3个，赠品的总价应低于主商品中的最小京东价。 Request
    /// </summary>
    public class JingdongSellerPromotionSkuAddRequest : JdRequestBase<JingdongSellerPromotionSkuAddResponse>
    {
        /// <summary>
        /// 促销编号
        /// </summary>
        /// <example>21113</example>
        [XmlElement("promo_id")]
        [JsonProperty("promo_id")]
        public Int64 PromoId
        {
            get;
            set;
        }

        /// <summary>
        /// SKU编号
        /// </summary>
        [XmlElement("sku_ids")]
        [JsonProperty("sku_ids")]
        public List<Int64> SkuIds
        {
            get;
            set;
        }

        /// <summary>
        /// 京东价，以元为单位，精确到小数点后一位
        /// </summary>
        /// <example>20.0</example>
        [XmlElement("jd_prices")]
        [JsonProperty("jd_prices")]
        public List<String> JdPrices
        {
            get;
            set;
        }

        /// <summary>
        /// 促销价，以元为单位，精确到小数点后一位，且必须小于京东价;注意：在FBP商家设置赠品促销时作为订单拆分价使用
        /// </summary>
        /// <example>18.9</example>
        [XmlElement("promo_prices")]
        [JsonProperty("promo_prices")]
        public List<String> PromoPrices
        {
            get;
            set;
        }

        /// <summary>
        /// 套装商品展示次序，相同商品的SKU上次序必须一致，只对套装促销有效
        /// </summary>
        [XmlElement("seq")]
        [JsonProperty("seq")]
        public List<Int64> Seq
        {
            get;
            set;
        }

        /// <summary>
        /// 赠品赠送数量，只能送1-3个。(只对赠品促销有效)
        /// </summary>
        [XmlElement("num")]
        [JsonProperty("num")]
        public List<Int64> Num
        {
            get;
            set;
        }

        /// <summary>
        /// 绑定类型, 可选值：主商品（1），赠品（2）。(赠品促销需要设置，单品、赠品促销时默认设置为1)
        /// </summary>
        /// <example>1</example>
        [XmlElement("bind_type")]
        [JsonProperty("bind_type")]
        public List<String> BindType
        {
            get;
            set;
        }

        public override String ApiName
        {
            get { return "jingdong.seller.promotion.sku.add"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("promo_id", this.PromoId);
            paramters.Add("sku_ids", this.SkuIds);
            paramters.Add("jd_prices", this.JdPrices);
            paramters.Add("promo_prices", this.PromoPrices);
            paramters.Add("seq", this.Seq);
            paramters.Add("num", this.Num);
            paramters.Add("bind_type", this.BindType);

        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("promo_id", this.PromoId);
            RequestValidator.ValidateRequired("sku_ids", this.SkuIds);
            RequestValidator.ValidateRequired("jd_prices", this.JdPrices);
        }

    }
}
