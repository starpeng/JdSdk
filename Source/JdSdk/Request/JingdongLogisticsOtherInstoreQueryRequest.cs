#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:01:51.81153 +08:00
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
    /// 其它入库单查询 Request
    /// </summary>
    public class JingdongLogisticsOtherInstoreQueryRequest : IJdRequest<JingdongLogisticsOtherInstoreQueryResponse>
    {
        /// <summary>
        /// 其它入库入库单号
        /// </summary>
        /// <example>JBI0000000033</example>
        [XmlElement("in_bound_no")]
        [JsonProperty("in_bound_no")]
        public String InBoundNo
        {
            get;
            set;
        }

        public String ApiName
        {
            get{ return "jingdong.logistics.otherInstore.query"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("in_bound_no" ,this.InBoundNo);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("in_bound_no", this.InBoundNo);
        }

    }
}
