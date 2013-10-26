#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-01-31 10:56:40:351 +08:00
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
    /// 通过api 根据sku_id /outer_id修改价格接口，skuId和outerId 至少填一个，如果都有则以sku_id为准 Request
    /// </summary>
    public class SkuPriceUpdateRequest : JdRequestBase<SkuPriceUpdateResponse>
    {
        /// <summary>
        /// sku的id
        /// </summary>
        /// <example>1100000015</example>
        [XmlElement("sku_id")]
        [JsonProperty("sku_id")]
        public Int64 SkuId
        {
            get;
            set;
        }

        /// <summary>
        /// 外部id
        /// </summary>
        /// <example>12345</example>
        [XmlElement("outer_id")]
        [JsonProperty("outer_id")]
        public String OuterId
        {
            get;
            set;
        }

        /// <summary>
        /// 京东价格
        /// </summary>
        /// <example>100</example>
        [XmlElement("price")]
        [JsonProperty("price")]
        public Int64 Price
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

        /// <summary>
        /// 商品京东价
        /// </summary>
        [XmlElement("jd_price")]
        [JsonProperty("jd_price")]
        public String JdPrice
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        [XmlElement("trade_no")]
        [JsonProperty("trade_no")]
        public String TradeNo
        {
            get;
            set;
        }

        public override String ApiName
        {
            get { return "360buy.sku.price.update"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("sku_id", this.SkuId);
            paramters.Add("outer_id", this.OuterId);
            paramters.Add("price", this.Price);
            paramters.Add("market_price", this.MarketPrice);
            paramters.Add("jd_price", this.JdPrice);
            paramters.Add("trade_no", this.TradeNo);

        }

        public override void Validate()
        {
            //RequestValidator.ValidateRequired("sku_id", this.SkuId);
            RequestValidator.ValidateRequired("price", this.Price);
        }

    }
}
