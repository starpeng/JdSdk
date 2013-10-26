#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:43.45205 +08:00
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
    public class JingdongKuaicheZnPlanChannelCreateRequest : JdRequestBase<JingdongKuaicheZnPlanChannelCreateResponse>
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

        public override String ApiName
        {
            get{ return "jingdong.kuaiche.zn.plan.channel.create"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("plan_info" ,this.PlanInfo);
        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("plan_info", this.PlanInfo);
        }

    }
}
