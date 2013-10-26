#region head comment
/*
Code generate by JdSdkTool.
Copyright © starpeng@vip.qq.com
2013-10-26 10:25:45.07614 +08:00
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
    /// 根据页面id查询该页面下的广告位信息 Response
    /// </summary>
    public class JingdongKuaicheZnSpaceInfoSearchResponse : JdResponse
    {
        /// <summary>
        /// 广告位信息
        /// </summary>
        [XmlElement("space_info_list")]
        [JsonProperty("space_info_list")]
        public List<SpaceInfo> SpaceInfoList
        {
            get;
            set;
        }

    }
}
