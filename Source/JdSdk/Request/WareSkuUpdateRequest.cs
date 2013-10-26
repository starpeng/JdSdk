#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-01-31 10:56:40:553 +08:00
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
    /// 通过api 根据sku_id 修改sku Request
    /// </summary>
    public class WareSkuUpdateRequest : JdRequestBase<WareSkuUpdateResponse>
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
        /// 流水号
        /// </summary>
        /// <example>Asdf23</example>
        [XmlElement("trade_no")]
        [JsonProperty("trade_no")]
        public String TradeNo
        {
            get;
            set;
        }

        public override String ApiName
        {
            get { return "360buy.ware.sku.update"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("sku_id", this.SkuId);
            paramters.Add("outer_id", this.OuterId);
            paramters.Add("ware_id", this.WareId);
            paramters.Add("jd_price", this.JdPrice);
            paramters.Add("stock_num", this.StockNum);
            paramters.Add("trade_no", this.TradeNo);

        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("sku_id", this.SkuId);
            RequestValidator.ValidateRequired("ware_id", this.WareId);
            RequestValidator.ValidateRequired("jd_price", this.JdPrice);
            RequestValidator.ValidateRequired("stock_num", this.StockNum);
            //RequestValidator.ValidateRequired("trade_no", this.TradeNo);
        }

    }
}
