#region head comment
/*
Code generate by JdSdkTool.
2013-01-31 10:56:39:348 +08:00
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
    /// 输入单个订单id，得到面单打印单的数据 Request
    /// </summary>
    public class OrderLbpPrintDataGetRequest : IJdRequest<OrderLbpPrintDataGetResponse>
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

        public String ApiName
        {
            get{ return "360buy.order.lbp.print.data.get"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("order_id" ,this.OrderId);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("order_id", this.OrderId);
        }

    }
}
