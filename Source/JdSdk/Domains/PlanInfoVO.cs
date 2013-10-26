#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:02:04.79427 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// PlanInfoVO属性
    /// </summary>
    [Serializable]
    public class PlanInfoVO : JdObject
    {
        /// <summary>
        /// 计划名称
        /// </summary>
        [XmlElement("planName")]
        [JsonProperty("planName")]
        public String PlanName
        {
            get;
            set;
        }

        /// <summary>
        /// 开始时间,格式:yyyy-MM-dd
        /// </summary>
        [XmlElement("startDate")]
        [JsonProperty("startDate")]
        public String StartDate
        {
            get;
            set;
        }

        /// <summary>
        /// 结束时间,格式:yyyy-MM-dd
        /// </summary>
        [XmlElement("endDate")]
        [JsonProperty("endDate")]
        public String EndDate
        {
            get;
            set;
        }

        /// <summary>
        /// 说明
        /// </summary>
        [XmlElement("notes")]
        [JsonProperty("notes")]
        public String Notes
        {
            get;
            set;
        }

        /// <summary>
        /// 计划状态  1未提交2待审核3未通过4审核失败5审核通过6投放中（竞投中） 7暂停8终止9已结束 10已冻结 11 提交成功  12 已删除（非物理删除）
        /// </summary>
        [XmlElement("status")]
        [JsonProperty("status")]
        public Int64 Status
        {
            get;
            set;
        }

    }
}
