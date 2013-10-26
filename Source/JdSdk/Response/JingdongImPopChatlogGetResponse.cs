#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:37.57271 +08:00
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
    /// 聊天记录查询 Response
    /// </summary>
    public class JingdongImPopChatlogGetResponse : JdResponse
    {
        /// <summary>
        /// 聊天记录
        /// </summary>
        /// <example></example>
        [XmlElement("ChatLog")]
        [JsonProperty("ChatLog")]
        public ChatLog[] ChatLog
        {
            get;
            set;
        }

    }
}
