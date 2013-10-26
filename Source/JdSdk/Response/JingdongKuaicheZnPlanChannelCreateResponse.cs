#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:43.45305 +08:00
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
    /// 创建频道页推广计划 Response
    /// </summary>
    public class JingdongKuaicheZnPlanChannelCreateResponse : JdResponse
    {
        /// <summary>
        /// 返回信息描述
        /// </summary>
        [XmlElement("result_status")]
        [JsonProperty("result_status")]
        public ResultStatus ResultStatus
        {
            get;
            set;
        }

    }
}
