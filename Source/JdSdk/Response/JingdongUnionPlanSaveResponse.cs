#region head comment
/*
Code generate by JdSdkTool.
2013-09-07 15:01:59.09095 +08:00
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
    /// 根据商家输入的计划信息新建或修改商家计划 Response
    /// </summary>
    public class JingdongUnionPlanSaveResponse : JdResponse
    {
        /// <summary>
        /// 计划保存结果
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
