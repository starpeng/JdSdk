#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-09-07 15:01:52.82259 +08:00
*/
#endregion

using System.Collections.Generic;
using System.Xml.Serialization;
using JdSdk.Domain;
using Newtonsoft.Json;

namespace JdSdk.Response
{
    /// <summary>
    /// 退货入库单申请 Response
    /// </summary>
    public class JingdongLogisticsReturnorderAddResponse : JdResponse
    {
        /// <summary>
        /// 
        /// </summary>
        /// <example>申请结果</example>
        [XmlElement("process_result")]
        [JsonProperty("process_result")]
        public List<ProcessResult> ProcessResult
        {
            get;
            set;
        }

    }
}
