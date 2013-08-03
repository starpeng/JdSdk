#region head comment
/*
Code generate by JdSdkTool.
2013-08-02 16:22:55.48075 +08:00
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
    /// 获取频道页投放计划的竞价状态（未参与竞价  竞价成功  竞价失败） Request
    /// </summary>
    public class JingdongKuaicheZnScheduleBidDetailSearchRequest : IJdRequest<JingdongKuaicheZnScheduleBidDetailSearchResponse>
    {
        /// <summary>
        /// 投放计划id
        /// </summary>
        [XmlElement("plan_id")]
        [JsonProperty("plan_id")]
        public Decimal PlanId
        {
            get;
            set;
        }

        public String ApiName
        {
            get{ return "jingdong.kuaiche.zn.schedule.bid.detail.search"; }
        }

        public String GetParamJson()
        {
            Dictionary<String, Object> paramters = new Dictionary<string, object>();
            paramters.Add("plan_id" ,this.PlanId);
            return JsonConvert.SerializeObject(paramters, JdUtils.GetJsonConverters());
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("plan_id", this.PlanId);
        }

    }
}
