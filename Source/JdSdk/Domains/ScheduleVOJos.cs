#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:50.77347 +08:00
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
        public Int64 ShowDay
        {
            get;
            set;
        }

        /// <summary>
        /// 竞价标记（0：未竞价 1：竞价成功 2：竞价失败） 只有&quot;status&quot;为6时，才会有bid_status_字段
        /// </summary>
        [XmlElement("bid_status")]
        [JsonProperty("bid_status")]
        public Int64 BidStatus
        {
            get;
            set;
        }

    }
}
