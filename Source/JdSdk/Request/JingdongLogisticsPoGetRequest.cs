#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:01:52.61958 +08:00
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
    /// 获取采购单信息 Request
    /// </summary>
    public class JingdongLogisticsPoGetRequest : IJdRequest<JingdongLogisticsPoGetResponse>
    {
        /// <summary>
        /// JOSL唯一入库单号
        /// </summary>
        [XmlElement("inbound_no")]
        [JsonProperty("inbound_no")]
        public String InboundNo
        {
            get;
            set;
        }

        public String ApiName
        {
            get{ return "jingdong.logistics.po.get"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("inbound_no" ,this.InboundNo);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("inbound_no", this.InboundNo);
        }

    }
}
