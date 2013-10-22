#region head comment
/*
Code generate by JdSdkTool.
2013-08-02 16:22:55.73877 +08:00
*/
#endregion

using System.Xml.Serialization;
using JdSdk.Domain;
using Newtonsoft.Json;

namespace JdSdk.Response
{
    /// <summary>
    /// 根据页面id查询该页面下的广告位信息 Response
    /// </summary>
    public class JingdongKuaicheZnSpaceInfoSearchResponse : JdResponse
    {
        /// <summary>
        /// 广告位信息
        /// </summary>
        [XmlElement("space_info_list")]
        [JsonProperty("space_info_list")]
        public SpaceInfo[] SpaceInfoList
        {
            get;
            set;
        }

    }
}
