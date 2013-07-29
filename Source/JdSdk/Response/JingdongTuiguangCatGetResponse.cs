#region head comment
/*
Code generate by JdSdkTool.
2013-04-03 12:45:23.32767 +08:00
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
    /// 获得频道页的推广链接信息 Response
    /// </summary>
    public class JingdongTuiguangCatGetResponse : JdResponse
    {
        /// <summary>
        /// 频道页推广信息
        /// </summary>
        [XmlElement("tuiguang_ware")]
        [JsonProperty("tuiguang_ware")]
        public PromoteWare[] TuiguangWare
        {
            get;
            set;
        }
    }
}
