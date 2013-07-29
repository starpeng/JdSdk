#region head comment
/*
Code generate by JdSdkTool.
2013-07-29 23:18:27.02230 +08:00
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
    /// 输入单个订单id，进行sop 出库操作 Request
    /// </summary>
    public class OverseasOrderSopOutstorageRequest : IJdRequest<OverseasOrderSopOutstorageResponse>
    {
        /// <summary>
        /// 订单id
        /// </summary>
        /// <example>123765123</example>
        [XmlElement("order_id")]
        [JsonProperty("order_id")]
        public String OrderId
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
            get{ return "360buy.overseas.order.sop.outstorage"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("order_id" ,this.OrderId);
            paramters.Add("trade_no" ,this.TradeNo);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("order_id", this.OrderId);
        }

    }
}
