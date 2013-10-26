#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:43.65606 +08:00
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
    /// 站内推广-频道页推广计划修改 Response
    /// </summary>
    public class JingdongKuaicheZnPlanChannelModifyResponse : JdResponse
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
