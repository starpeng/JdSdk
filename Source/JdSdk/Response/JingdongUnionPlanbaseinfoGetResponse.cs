#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:01:59.29296 +08:00
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
    /// 根据商家计划编号查询商家计划基本信息 Response
    /// </summary>
    public class JingdongUnionPlanbaseinfoGetResponse : JdResponse
    {
        /// <summary>
        /// 计划查询结果
        /// </summary>
        [XmlElement("resultVO")]
        [JsonProperty("resultVO")]
        public ResultVO ResultVO
        {
            get;
            set;
        }

    }
}
