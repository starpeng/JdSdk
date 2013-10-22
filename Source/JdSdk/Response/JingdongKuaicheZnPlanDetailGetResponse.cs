#region head comment
/*
Code generate by JdSdkTool.
2013-08-02 16:22:55.06873 +08:00
*/
#endregion

using System.Xml.Serialization;
using JdSdk.Domain;
using Newtonsoft.Json;

namespace JdSdk.Response
{
    /// <summary>
    /// 获取投放计划详细信息 Response
    /// </summary>
    public class JingdongKuaicheZnPlanDetailGetResponse : JdResponse
    {
        /// <summary>
        /// 计划详细信息
        /// </summary>
        [XmlElement("plan_detail_info")]
        [JsonProperty("plan_detail_info")]
        public PlanDetailInfo PlanDetailInfo
        {
            get;
            set;
        }

    }
}
