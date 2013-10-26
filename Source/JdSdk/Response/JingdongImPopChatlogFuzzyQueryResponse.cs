#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:37.36970 +08:00
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
    /// 聊天记录模糊查询 Response
    /// </summary>
    public class JingdongImPopChatlogFuzzyQueryResponse : JdResponse
    {
        /// <summary>
        /// 聊天记录
        /// </summary>
        [XmlElement("ChatLog")]
        [JsonProperty("ChatLog")]
        public List<ChatLog> ChatLog
        {
            get;
            set;
        }

    }
}
