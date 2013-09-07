#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:01:51.40651 +08:00
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
    /// 获取多订单信息 Request
    /// </summary>
    public class JingdongLogisticsOrderSearchRequest : IJdRequest<JingdongLogisticsOrderSearchResponse>
    {
        /// <summary>
        /// JOSL唯一单号(多订单请用英文','分割,最大支持200单)
        /// </summary>
        [XmlElement("receipt_nos")]
        [JsonProperty("receipt_nos")]
        public String ReceiptNos
        {
            get;
            set;
        }

        /// <summary>
        /// 状态值集(,)
        /// </summary>
        [XmlElement("status")]
        [JsonProperty("status")]
        public String Status
        {
            get;
            set;
        }

        public String ApiName
        {
            get{ return "jingdong.logistics.order.search"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("receipt_nos" ,this.ReceiptNos);
            paramters.Add("status" ,this.Status);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("receipt_nos", this.ReceiptNos);
        }

    }
}
