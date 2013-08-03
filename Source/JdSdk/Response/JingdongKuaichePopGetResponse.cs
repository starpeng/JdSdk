#region head comment
/*
Code generate by JdSdkTool.
2013-08-02 16:22:54.45569 +08:00
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
    /// 经用户授权后，可以获得商家在快车系统的用户信息。 Response
    /// </summary>
    public class JingdongKuaichePopGetResponse : JdResponse
    {
        /// <summary>
        /// 专柜信息
        /// </summary>
        [XmlElement("result")]
        [JsonProperty("result")]
        public PopDetailJos Result
        {
            get;
            set;
        }

    }
}
