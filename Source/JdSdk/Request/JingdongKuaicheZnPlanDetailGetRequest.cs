#region head comment
/*
Code generate by JdSdkTool.
2013-08-02 16:22:55.06773 +08:00
*/
#endregion

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using JdSdk.Response;
using Newtonsoft.Json;

namespace JdSdk.Request
{
    /// <summary>
    /// 获取投放计划详细信息 Request
    /// </summary>
    public class JingdongKuaicheZnPlanDetailGetRequest : JdRequestBase<JingdongKuaicheZnPlanDetailGetResponse>
    {
        /// <summary>
        /// 投放计划id
        /// </summary>
        [XmlElement("plan_id")]
        [JsonProperty("plan_id")]
        public Nullable<Int64> PlanId
        {
            get;
            set;
        }

        public override String ApiName
        {
            get { return "jingdong.kuaiche.zn.plan.detail.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("plan_id", this.PlanId);

        }

        public override void Validate()
        {
        }

    }
}
