#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:31.91339 +08:00
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
    /// 输入单个订单id，得到所有相关订单信息 Request
    /// </summary>
    public class OrderFbpGetRequest : JdRequestBase<OrderFbpGetResponse>
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
        /// 商家希望返回的订单的信息字段, 可选值: OrderInfo数据结构中的以下字段:        order_id,vender_id,pay_type等每个字段以逗号分隔
        /// </summary>
        [XmlElement("optional_fields")]
        [JsonProperty("optional_fields")]
        public String OptionalFields
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "360buy.order.fbp.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("order_id" ,this.OrderId);
            paramters.Add("optional_fields" ,this.OptionalFields);
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("order_id", this.OrderId);
        }

    }
}
