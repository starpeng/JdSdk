#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-07-29 22:39:04.20715 +08:00
*/
#endregion

using System.Xml.Serialization;
using JdSdk.Domain;
using Newtonsoft.Json;

namespace JdSdk.Response
{
    /// <summary>
    /// 根据商家账号和计划编号查询商家计划详情 Response
    /// </summary>
    public class JingdongUnionPlandetailGetResponse : JdResponse
    {
        /// <summary>
        /// 计划详情对象
        /// </summary>
        [XmlElement("planVO")]
        [JsonProperty("planVO")]
        public PlanVO PlanVO
        {
            get;
            set;
        }

    }
}
