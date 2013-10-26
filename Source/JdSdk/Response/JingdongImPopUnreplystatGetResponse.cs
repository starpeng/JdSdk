#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:39.19980 +08:00
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
    /// 客服日未回复量统计 Response
    /// </summary>
    public class JingdongImPopUnreplystatGetResponse : JdResponse
    {
        /// <summary>
        /// 客服日未回复量统计类
        /// </summary>
        /// <example></example>
        [XmlElement("WaiterDailyStat")]
        [JsonProperty("WaiterDailyStat")]
        public WaiterDailyStat[] WaiterDailyStat
        {
            get;
            set;
        }

    }
}
