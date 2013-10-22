#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:01:44.93114 +08:00
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
    /// 获取预分配的运单号 Request
    /// </summary>
    public class JingdongEtmsWaybillcodeGetRequest : JdRequestBase<JingdongEtmsWaybillcodeGetResponse>
    {
        /// <summary>
        /// 商家订单号
        /// </summary>
        [XmlElement("orderId")]
        [JsonProperty("orderId")]
        public String OrderId
        {
            get;
            set;
        }

        /// <summary>
        /// 商家id
        /// </summary>
        [XmlElement("customerId")]
        [JsonProperty("customerId")]
        public Int64 CustomerId
        {
            get;
            set;
        }

        public override String ApiName
        {
            get { return "jingdong.etms.waybillcode.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("orderid", this.OrderId);
            paramters.Add("customerid", this.CustomerId);

        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("orderId", this.OrderId);
            RequestValidator.ValidateRequired("customerId", this.CustomerId);
        }

    }
}
