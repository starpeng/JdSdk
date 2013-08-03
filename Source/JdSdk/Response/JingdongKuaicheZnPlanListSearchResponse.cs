#region head comment
/*
Code generate by JdSdkTool.
2013-08-02 16:22:55.27474 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;
using JdSdk.Domain;

namespace JdSdk.Response
{
    /// <summary>
    /// 查询投放计划列表 Response
    /// </summary>
    public class JingdongKuaicheZnPlanListSearchResponse : JdResponse
    {
        /// <summary>
        /// 查询投放计划列表
        /// </summary>
        [XmlElement("plan_list_info")]
        [JsonProperty("plan_list_info")]
        public QueryPlanReturnInfo PlanListInfo
        {
            get;
            set;
        }

    }
}
