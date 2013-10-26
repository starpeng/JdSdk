#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-01-31 10:56:42:375 +08:00
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
    /// 通过api 增加sku信息 Request
    /// </summary>
    public class WareSkuAddRequest : JdRequestBase<WareSkuAddResponse>
    {
        /// <summary>
        /// 商品id
        /// </summary>
        /// <example>1100000015</example>
        [XmlElement("ware_id")]
        [JsonProperty("ware_id")]
        public Int64 WareId
        {
            get;
            set;
        }

        /// <summary>
        /// Sku属性
        /// </summary>
        /// <example>100041:150041^1000046:15844</example>
        [XmlElement("attributes")]
        [JsonProperty("attributes")]
        public String Attributes
        {
            get;
            set;
        }

        /// <summary>
        /// 京东价格
        /// </summary>
        /// <example>100</example>
        [XmlElement("jd_price")]
        [JsonProperty("jd_price")]
        public Int64 JdPrice
        {
            get;
            set;
        }

        /// <summary>
        /// 库存
        /// </summary>
        /// <example>20</example>
        [XmlElement("stock_num")]
        [JsonProperty("stock_num")]
        public Int64 StockNum
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
            get { return "360buy.ware.sku.add"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("ware_id", this.WareId);
            paramters.Add("attributes", this.Attributes);
            paramters.Add("jd_price", this.JdPrice);
            paramters.Add("stock_num", this.StockNum);
            paramters.Add("trade_no", this.TradeNo);

        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("ware_id", this.WareId);
            RequestValidator.ValidateRequired("attributes", this.Attributes);
            RequestValidator.ValidateRequired("jd_price", this.JdPrice);
            RequestValidator.ValidateRequired("stock_num", this.StockNum);
        }

    }
}
