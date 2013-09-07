#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:01:51.00148 +08:00
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
    /// 订单取消 Request
    /// </summary>
    public class JingdongLogisticsOrderDeleteRequest : IJdRequest<JingdongLogisticsOrderDeleteResponse>
    {
        /// <summary>
        /// JOSL单号
        /// </summary>
        [XmlElement("receipt_no")]
        [JsonProperty("receipt_no")]
        public String ReceiptNo
        {
            get;
            set;
        }

        public String ApiName
        {
            get{ return "jingdong.logistics.order.delete"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("receipt_no" ,this.ReceiptNo);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("receipt_no", this.ReceiptNo);
        }

    }
}
