#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:44.67012 +08:00
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
    /// 根据广告位id获取可以投放的日期 Response
    /// </summary>
    public class JingdongKuaicheZnScheduleAvailableSearchResponse : JdResponse
    {
        /// <summary>
        /// 可以投放的排期日期
        /// </summary>
        [XmlElement("schedule_day_list")]
        [JsonProperty("schedule_day_list")]
        public List<String> ScheduleDayList
        {
            get;
            set;
        }

    }
}
