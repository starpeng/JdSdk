#region head comment
/*
Code generate by JdSdkTool.
2013-01-31 10:56:47:642 +08:00
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
    /// 输入单个订单id，得到面单打印内容 Request
    /// </summary>
    public class OrderPrintRequest : IJdRequest<OrderPrintResponse>
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
        /// 商家希望返回的订单的信息字段,每个字段以逗号分隔
        /// </summary>
        [XmlElement("optional_fields")]
        [JsonProperty("optional_fields")]
        public String OptionalFields
        {
            get;
            set;
        }

        public String ApiName
        {
            get{ return "360buy.order.print"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("order_id" ,this.OrderId);
            paramters.Add("optional_fields" ,this.OptionalFields);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("order_id", this.OrderId);
        }

    }
}
