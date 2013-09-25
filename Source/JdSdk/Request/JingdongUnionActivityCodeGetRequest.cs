#region head comment
/*
Code generate by JdSdkTool.
2013-07-29 22:39:03.16409 +08:00
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
    /// 根据活动ID查询活动推广代码 Request
    /// </summary>
    public class JingdongUnionActivityCodeGetRequest : IJdRequest<JingdongUnionActivityCodeGetResponse>
    {
        /// <summary>
        /// 活动ID
        /// </summary>
        /// <example>31345235</example>
        [XmlElement("activity_id")]
        [JsonProperty("activity_id")]
        public Int64 ActivityId
        {
            get;
            set;
        }

        public String ApiName
        {
            get{ return "jingdong.union.activity.code.get"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("activity_id" ,this.ActivityId);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("activity_id", this.ActivityId);
        }

    }
}
