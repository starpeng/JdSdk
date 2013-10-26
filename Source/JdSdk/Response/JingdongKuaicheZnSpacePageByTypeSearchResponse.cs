#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:45.27815 +08:00
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
        public List<SpacePageInfo> SpacePageInfoList
        {
            get;
            set;
        }

    }
}
