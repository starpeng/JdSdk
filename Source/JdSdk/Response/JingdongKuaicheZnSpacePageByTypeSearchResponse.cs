#region head comment
/*
Code generate by JdSdkTool.
2013-08-02 16:22:55.94678 +08:00
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
    /// 根据投放类型获取广告位页面信息 Response
    /// </summary>
    public class JingdongKuaicheZnSpacePageByTypeSearchResponse : JdResponse
    {
        /// <summary>
        /// 广告位页面信息
        /// </summary>
        [XmlElement("space_page_info_list")]
        [JsonProperty("space_page_info_list")]
        public SpacePageInfo[] SpacePageInfoList
        {
            get;
            set;
        }

    }
}
