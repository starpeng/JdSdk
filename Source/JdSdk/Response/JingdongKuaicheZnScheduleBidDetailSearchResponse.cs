#region head comment
/*
Code generate by JdSdkTool.
2013-08-02 16:22:55.53375 +08:00
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
    /// 获取频道页投放计划的竞价状态（未参与竞价  竞价成功  竞价失败） Response
    /// </summary>
    public class JingdongKuaicheZnScheduleBidDetailSearchResponse : JdResponse
    {
        /// <summary>
        /// 排期竞投详情
        /// </summary>
        /// <example>排期竞投详情</example>
        [XmlElement("Schedule_list")]
        [JsonProperty("Schedule_list")]
        public List<ScheduleVOJos> ScheduleList
        {
            get;
            set;
        }

    }
}
