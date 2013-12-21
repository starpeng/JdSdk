#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-07-29 13:02:46.26192 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using Newtonsoft.Json;
using System.Collections.Generic;

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
        public Nullable<Int64> TotalCount
        {
            get;
            set;
        }

        /// <summary>
        /// 计划列表
        /// </summary>
        [XmlElement("planList")]
        [JsonProperty("planList")]
        public List<UnionPlan> PlanList
        {
            get;
            set;
        }

        /// <summary>
        /// 计划总页数
        /// </summary>
        [XmlElement("totalPage")]
        [JsonProperty("totalPage")]
        public Nullable<Int64> TotalPage
        {
            get;
            set;
        }

    }
}
