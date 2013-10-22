#region head comment
/*
Code generate by JdSdkTool.
2013-07-29 22:39:04.20615 +08:00
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
    /// 根据商家账号和计划编号查询商家计划详情 Request
    /// </summary>
    public class JingdongUnionPlandetailGetRequest : JdRequestBase<JingdongUnionPlandetailGetResponse>
    {
        /// <summary>
        /// 计划编号
        /// </summary>
        /// <example>1</example>
        [XmlElement("planId")]
        [JsonProperty("planId")]
        public Int64 PlanId
        {
            get;
            set;
        }

        public override String ApiName
        {
            get { return "jingdong.union.plandetail.get"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {

            paramters.Add("planid", this.PlanId);

        }

        public override void Validate()
        {
            RequestValidator.ValidateRequired("planId", this.PlanId);
        }

    }
}
