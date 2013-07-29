#region head comment
/*
Code generate by JdSdkTool.
2013-01-31 10:56:42:173 +08:00
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
    /// 商家订单备注修改。 Request
    /// </summary>
    public class OrderVenderRemarkUpdateRequest : IJdRequest<OrderVenderRemarkUpdateResponse>
    {
        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("order_id")]
        [JsonProperty("order_id")]
        public String OrderId
        {
            get;
            set;
        }

        /// <summary>
        /// 订单备注
        /// </summary>
        [XmlElement("remark")]
        [JsonProperty("remark")]
        public String Remark
        {
            get;
            set;
        }

        /// <summary>
        /// 流水号,不能重复的随机数
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
            get{ return "360buy.order.vender.remark.update"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("order_id" ,this.OrderId);
            paramters.Add("remark" ,this.Remark);
            paramters.Add("trade_no" ,this.TradeNo);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("order_id", this.OrderId);
            RequestValidator.ValidateRequired("remark", this.Remark);
        }

    }
}
