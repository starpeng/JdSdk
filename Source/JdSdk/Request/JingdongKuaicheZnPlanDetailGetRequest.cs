#region head comment
/*
Code generate by JdSdkTool.
2013-08-02 16:22:55.06773 +08:00
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
    /// 获取投放计划详细信息 Request
    /// </summary>
    public class JingdongKuaicheZnPlanDetailGetRequest : IJdRequest<JingdongKuaicheZnPlanDetailGetResponse>
    {
        /// <summary>
        /// 投放计划id
        /// </summary>
        [XmlElement("plan_id")]
        [JsonProperty("plan_id")]
        public Nullable<Decimal> PlanId
        {
            get;
            set;
        }

        public String ApiName
        {
            get{ return "jingdong.kuaiche.zn.plan.detail.get"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("plan_id" ,this.PlanId);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
        }

    }
}
