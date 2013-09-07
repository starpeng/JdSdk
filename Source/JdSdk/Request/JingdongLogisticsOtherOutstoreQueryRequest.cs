#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:01:52.21555 +08:00
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
    /// 其它出库单查询 Request
    /// </summary>
    public class JingdongLogisticsOtherOutstoreQueryRequest : IJdRequest<JingdongLogisticsOtherOutstoreQueryResponse>
    {
        /// <summary>
        /// josl出库单号
        /// </summary>
        [XmlElement("josl_outbound_no")]
        [JsonProperty("josl_outbound_no")]
        public String JoslOutboundNo
        {
            get;
            set;
        }

        public String ApiName
        {
            get{ return "jingdong.logistics.otherOutstore.query"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("josl_outbound_no" ,this.JoslOutboundNo);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("josl_outbound_no", this.JoslOutboundNo);
        }

    }
}
