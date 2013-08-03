#region head comment
/*
Code generate by JdSdkTool.
2013-08-02 16:22:56.18179 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JdSdk.Domain
{
    /// <summary>
    /// ScheduleVOJos属性
    /// </summary>
    [Serializable]
    public class ScheduleVOJos : JdObject
    {
        /// <summary>
        /// 排期对应的播放日期
        /// </summary>
        [XmlElement("show_day")]
        [JsonProperty("show_day")]
        public Nullable<Decimal> ShowDay
        {
            get;
            set;
        }

        /// <summary>
        /// 竞价标记（0：未竞价 1：竞价成功 2：竞价失败）
        /// </summary>
        [XmlElement("bid_status")]
        [JsonProperty("bid_status")]
        public Nullable<Decimal> BidStatus
        {
            get;
            set;
        }

    }
}
