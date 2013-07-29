#region head comment
/*
Code generate by JdSdkTool.
2013-07-29 22:39:04.20615 +08:00
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
    /// 根据商家账号和计划编号查询商家计划详情 Request
    /// </summary>
    public class JingdongUnionPlandetailGetRequest : IJdRequest<JingdongUnionPlandetailGetResponse>
    {
        /// <summary>
        /// 计划编号
        /// </summary>
        /// <example>1</example>
        [XmlElement("planId")]
        [JsonProperty("planId")]
        public Decimal PlanId
        {
            get;
            set;
        }

        public String ApiName
        {
            get{ return "jingdong.union.plandetail.get"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("planid" ,this.PlanId);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("planId", this.PlanId);
        }

    }
}
