#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:01:59.29296 +08:00
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
    /// 根据商家计划编号查询商家计划基本信息 Request
    /// </summary>
    public class JingdongUnionPlanbaseinfoGetRequest : JdRequestBase<JingdongUnionPlanbaseinfoGetResponse>
    {
        /// <summary>
        /// 计划编号
        /// </summary>
        [XmlElement("planId")]
        [JsonProperty("planId")]
        public String PlanId
        {
            get;
            set;
        }

        public override String ApiName
        {
            get { return "jingdong.union.planbaseinfo.get"; }
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
