#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:01:48.97737 +08:00
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
    /// 创建频道页推广计划 Request
    /// </summary>
    public class JingdongKuaicheZnPlanChannelCreateRequest : IJdRequest<JingdongKuaicheZnPlanChannelCreateResponse>
    {
        /// <summary>
        /// 投放计划内容
        /// </summary>
        [XmlElement("plan_info")]
        [JsonProperty("plan_info")]
        public String PlanInfo
        {
            get;
            set;
        }

        public String ApiName
        {
            get{ return "jingdong.kuaiche.zn.plan.channel.create"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("plan_info" ,this.PlanInfo);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("plan_info", this.PlanInfo);
        }

    }
}
