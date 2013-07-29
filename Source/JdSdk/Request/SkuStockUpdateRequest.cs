#region head comment
/*
Code generate by JdSdkTool.
2013-01-31 10:56:40:757 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using JdSdk.Domain;
using JdSdk.Response;

namespace JdSdk.Request
{
    /// <summary>
    /// 通过api 根据sku_id /outer_id修改库存接口，skuId和outerId 至少填一个，如果都有则以sku_id为准。 Request
    /// </summary>
    public class SkuStockUpdateRequest : IJdRequest<SkuStockUpdateResponse>
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
        /// 需要更新的库存数量
        /// </summary>
        /// <example>100</example>
        [XmlElement("quantity")]
        [JsonProperty("quantity")]
        public Int64 Quantity
        {
            get;
            set;
        }

        /// <summary>
        /// 流水号
        /// </summary>
        [XmlElement("trade_no")]
        [JsonProperty("trade_no")]
        public String TradeNo
        {
            get;
            set;
        }

        public String ApiName
        {
            get{ return "360buy.sku.stock.update"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("sku_id" ,this.SkuId);
            paramters.Add("outer_id" ,this.OuterId);
            paramters.Add("quantity" ,this.Quantity);
            paramters.Add("trade_no" ,this.TradeNo);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("sku_id", this.SkuId);
            RequestValidator.ValidateRequired("quantity", this.Quantity);
            RequestValidator.ValidateRequired("trade_no", this.TradeNo);
        }

    }
}
