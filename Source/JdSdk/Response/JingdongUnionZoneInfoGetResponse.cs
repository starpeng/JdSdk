#region head comment
/*
Code generate by JdSdkTool.
2013-07-29 22:39:06.63229 +08:00
*/
#endregion

using System.Xml.Serialization;
using JdSdk.Domain;
using Newtonsoft.Json;

namespace JdSdk.Response
{
    /// <summary>
    /// 获得指定专柜id获取专柜信息 Response
    /// </summary>
    public class JingdongUnionZoneInfoGetResponse : JdResponse
    {
        /// <summary>
        /// 专柜信息
        /// </summary>
        [XmlElement("ad_zone")]
        [JsonProperty("ad_zone")]
        public AdZoneVo AdZone
        {
            get;
            set;
        }

    }
}
