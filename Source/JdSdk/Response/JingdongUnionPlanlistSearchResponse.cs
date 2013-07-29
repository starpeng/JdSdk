#region head comment
/*
Code generate by JdSdkTool.
2013-07-29 22:39:04.40916 +08:00
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
    /// 根据商家账号查询商家计划列表 Response
    /// </summary>
    public class JingdongUnionPlanlistSearchResponse : JdResponse
    {
        /// <summary>
        /// 计划列表对象
        /// </summary>
        [XmlElement("planListVO")]
        [JsonProperty("planListVO")]
        public PlanListVO PlanListVO
        {
            get;
            set;
        }

    }
}
