#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:37.97773 +08:00
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
    /// 查询客服评价详情 Response
    /// </summary>
    public class JingdongImPopEvaluationlistGetResponse : JdResponse
    {
        /// <summary>
        /// 评价详情
        /// </summary>
        [XmlElement("Evaluation")]
        [JsonProperty("Evaluation")]
        public List<Evaluation> Evaluation
        {
            get;
            set;
        }

    }
}
