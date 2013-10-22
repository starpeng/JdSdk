#region head comment
/*
Code generate by JdSdkTool.
2013-07-29 22:39:06.42928 +08:00
*/
#endregion

using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace JdSdk.Response
{
    /// <summary>
    /// 根据指定专柜id获取转化代码 Response
    /// </summary>
    public class JingdongUnionZoneCodeGetResponse : JdResponse
    {
        /// <summary>
        /// 专柜推广代码
        /// </summary>
        [XmlElement("zone_code")]
        [JsonProperty("zone_code")]
        public String ZoneCode
        {
            get;
            set;
        }

    }
}
