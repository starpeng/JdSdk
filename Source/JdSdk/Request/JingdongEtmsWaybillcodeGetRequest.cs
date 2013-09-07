#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:01:44.93114 +08:00
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
    /// 获取预分配的运单号 Request
    /// </summary>
    public class JingdongEtmsWaybillcodeGetRequest : IJdRequest<JingdongEtmsWaybillcodeGetResponse>
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

        public String ApiName
        {
            get{ return "jingdong.etms.waybillcode.get"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("orderid" ,this.OrderId);
            paramters.Add("customerid" ,this.CustomerId);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("orderId", this.OrderId);
            RequestValidator.ValidateRequired("customerId", this.CustomerId);
        }

    }
}
