#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:02:04.34725 +08:00
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
    ///  Request
    /// </summary>
    public class JingdongWosWorkinfoGetRequest : IJdRequest<JingdongWosWorkinfoGetResponse>
    {
        /// <summary>
        /// 工单号 (通过jingdong.wos.worklist.get接口获取)
        /// </summary>
        [XmlElement("work_id")]
        [JsonProperty("work_id")]
        public Int64 WorkId
        {
            get;
            set;
        }

        public String ApiName
        {
            get{ return "jingdong.wos.workinfo.get"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("work_id" ,this.WorkId);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("work_id", this.WorkId);
        }

    }
}
