#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:38.79578 +08:00
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
    /// 客服日接待量统计 Response
    /// </summary>
    public class JingdongImPopReplystatGetResponse : JdResponse
    {
        /// <summary>
        /// 客服日接待量统计数据类
        /// </summary>
        /// <example></example>
        [XmlElement("WaiterDailyStat")]
        [JsonProperty("WaiterDailyStat")]
        public List<WaiterDailyStat> WaiterDailyStat
        {
            get;
            set;
        }

    }
}
