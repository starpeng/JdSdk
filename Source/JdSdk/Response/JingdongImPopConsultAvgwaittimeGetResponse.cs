#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:37.77572 +08:00
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
    /// 咨询指定日期的平均等待时长 Response
    /// </summary>
    public class JingdongImPopConsultAvgwaittimeGetResponse : JdResponse
    {
        /// <summary>
        /// 平均等待时间（秒）
        /// </summary>
        /// <example></example>
        [XmlElement("avgTime")]
        [JsonProperty("avgTime")]
        public Int64 AvgTime
        {
            get;
            set;
        }

    }
}
