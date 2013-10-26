#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:44.26609 +08:00
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
    /// 创建搜索页推广 Request
    /// </summary>
    public class JingdongKuaicheZnPlanSearchCreateRequest : JdRequestBase<JingdongKuaicheZnPlanSearchCreateResponse>
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
            get{ return "jingdong.kuaiche.zn.plan.search.create"; }
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
