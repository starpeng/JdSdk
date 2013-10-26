#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:43.65506 +08:00
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
    /// 站内推广-频道页推广计划修改 Request
    /// </summary>
    public class JingdongKuaicheZnPlanChannelModifyRequest : JdRequestBase<JingdongKuaicheZnPlanChannelModifyResponse>
    {
        /// <summary>
        /// 修改计划计划内容
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
            get{ return "jingdong.kuaiche.zn.plan.channel.modify"; }
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
