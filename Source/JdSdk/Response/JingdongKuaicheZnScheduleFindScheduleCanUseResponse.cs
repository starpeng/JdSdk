#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:01:49.99043 +08:00
*/
#endregion

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Response
{
    /// <summary>
    /// 根据广告位id获取可以投放的日期 Response
    /// </summary>
    public class JingdongKuaicheZnScheduleFindScheduleCanUseResponse : JdResponse
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
