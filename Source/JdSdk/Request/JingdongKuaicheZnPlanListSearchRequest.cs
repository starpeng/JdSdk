#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:44.06208 +08:00
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
    /// 查询投放计划列表 Request
    /// </summary>
    public class JingdongKuaicheZnPlanListSearchRequest : JdRequestBase<JingdongKuaicheZnPlanListSearchResponse>
    {
        /// <summary>
        /// 投放计划名称
        /// </summary>
        [XmlElement("plan_name")]
        [JsonProperty("plan_name")]
        public String PlanName
        {
            get;
            set;
        }

        /// <summary>
        /// 投放模式2：买断（cpd按日）  3：cpc按点击
        /// </summary>
        [XmlElement("mode")]
        [JsonProperty("mode")]
        public String Mode
        {
            get;
            set;
        }

        /// <summary>
        /// 状态 1未提交2待审核3未通过    5审核通过6竞投中7暂停8终止9已结束'
        /// </summary>
        [XmlElement("status")]
        [JsonProperty("status")]
        public Int64 Status
        {
            get;
            set;
        }

        /// <summary>
        /// 是否是按状态查询（1: 是 ; 0: 否）
        /// </summary>
        [XmlElement("is_query_by_status")]
        [JsonProperty("is_query_by_status")]
        public String IsQueryByStatus
        {
            get;
            set;
        }

        /// <summary>
        /// 排期开始时间
        /// </summary>
        [XmlElement("begin")]
        [JsonProperty("begin")]
        public Int64 Begin
        {
            get;
            set;
        }

        /// <summary>
        /// 排期结束时间
        /// </summary>
        [XmlElement("end")]
        [JsonProperty("end")]
        public Int64 End
        {
            get;
            set;
        }

        /// <summary>
        /// 分页大小
        /// </summary>
        [XmlElement("page_size")]
        [JsonProperty("page_size")]
        public Int64 PageSize
        {
            get;
            set;
        }

        /// <summary>
        /// 第几页
        /// </summary>
        [XmlElement("page_index")]
        [JsonProperty("page_index")]
        public Int64 PageIndex
        {
            get;
            set;
        }

        public override String ApiName
        {
            get{ return "jingdong.kuaiche.zn.plan.list.search"; }
        }

        protected override void PrepareParam(IDictionary<String, Object> paramters)
        {
            paramters.Add("plan_name" ,this.PlanName);
            paramters.Add("mode" ,this.Mode);
            paramters.Add("status" ,this.Status);
            paramters.Add("is_query_by_status" ,this.IsQueryByStatus);
            paramters.Add("begin" ,this.Begin);
            paramters.Add("end" ,this.End);
            paramters.Add("page_size" ,this.PageSize);
            paramters.Add("page_index" ,this.PageIndex);
        }

        public override void Validate()
        {
        }

    }
}
