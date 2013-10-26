#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:39.40282 +08:00
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
    /// 日累计在线时长 Response
    /// </summary>
    public class JingdongImPopWaiterOnlinetimeStatGetResponse : JdResponse
    {
        /// <summary>
        /// 客服日在线时长统计类
        /// </summary>
        [XmlElement("WaiterDailyStat")]
        [JsonProperty("WaiterDailyStat")]
        public List<WaiterDailyStat> WaiterDailyStat
        {
            get;
            set;
        }

    }
}
