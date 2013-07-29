#region head comment
/*
Code generate by JdSdkTool.
2013-07-29 13:02:46.26192 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// 简要描述 计划列表对象
    /// </summary>
    [Serializable]
    public class PlanListVO : JdObject
    {
        /// <summary>
        /// 计划总数
        /// </summary>
        [XmlElement("totalCount")]
        [JsonProperty("totalCount")]
        public Nullable<Decimal> TotalCount
        {
            get;
            set;
        }

        /// <summary>
        /// 计划列表
        /// </summary>
        [XmlElement("planList")]
        [JsonProperty("planList")]
        public UnionPlan[] PlanList
        {
            get;
            set;
        }

        /// <summary>
        /// 计划总页数
        /// </summary>
        [XmlElement("totalPage")]
        [JsonProperty("totalPage")]
        public Nullable<Decimal> TotalPage
        {
            get;
            set;
        }

    }
}
