#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:38.18075 +08:00
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
    /// 客服日评价统计 Response
    /// </summary>
    public class JingdongImPopEvaluationstatGetResponse : JdResponse
    {
        /// <summary>
        /// 客服日评价统计数据
        /// </summary>
        /// <example></example>
        [XmlElement("WaiterDailyEvaStat")]
        [JsonProperty("WaiterDailyEvaStat")]
        public WaiterDailyEvaStat[] WaiterDailyEvaStat
        {
            get;
            set;
        }

    }
}
