#region head comment
/*
Code generate by JdSdkTool.
2013-08-02 16:22:55.48075 +08:00
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
    /// 获取频道页投放计划的竞价状态（未参与竞价  竞价成功  竞价失败） Request
    /// </summary>
    public class JingdongKuaicheZnScheduleBidDetailSearchRequest : JdRequestBase<JingdongKuaicheZnScheduleBidDetailSearchResponse>
    {
        /// <summary>
        /// 投放计划id
        /// </summary>
        [XmlElement("plan_id")]
        [JsonProperty("plan_id")]
        public Int64 PlanId
        {
            get;
            set;
        }

        public override String ApiName
        {
            get { return "jingdong.kuaiche.zn.schedule.bid.detail.search"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("plan_id", this.PlanId);

        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("plan_id", this.PlanId);
        }

    }
}
